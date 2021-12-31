using HendrixAccountant.ApplicationCore.Constants;
using HendrixAccountant.ApplicationCore.DTOs;
using HendrixAccountant.ApplicationCore.Interfaces.Forms;
using HendrixAccountant.ApplicationCore.Interfaces.Repositories;
using HendrixAccountant.ApplicationCore.Interfaces.Services;
using HendrixAccountant.ApplicationCore.Map;
using HendrixAccountant.ApplicationCore.Models;
using HendrixAccountant.ApplicationCore.Services;
using HendrixAccountant.Common;
using HendrixAccountant.Data;
using HendrixAccountant.Data.Repositories;
using HendrixAccountant.Data.Services;
using HendrixAccountant.Forms.Sales;
using HendrixAccountant.Reports.Tickets;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace HendrixAccountant
{
    public partial class frmPuntoVenta : Form, IFindElement, IQuantity
    {
        private ProductIdentityDto _product;
        private List<ProductIdentityDto> _lsProducts;
        private decimal _descuento;
        private ClientIdentity _client;
        private InvoiceDto _invoice;
        private IClientRepository _rpsClient;
        private IProductTempRepository _rpsProduct;
        private IParameterRepository _rpsParams;
        private readonly IReports _rpsReport;
        public frmPuntoVenta()
        {
            InitializeComponent();
            SetCompanyColors();
            _product = null;
            _lsProducts = new List<ProductIdentityDto>();
            _client = null;
            _invoice = null;
            _descuento = 0;
            _rpsClient = null;
            _rpsProduct = new ProductTempRepository();
            _rpsParams = new CompanyRepository();
            _rpsReport = new SaleReportService();
            SetFinalConsumer();
        }

        private void frmPuntoVenta_Load(object sender, EventArgs e)
        {
            //DisableAdd();
            //DisabledRemove();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
           frmBuscarProductos frmBuscarProductos = new frmBuscarProductos(this);
           frmBuscarProductos.ShowDialog();
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            _client = null;
            txtIdentCliente.Clear();
            txtNombresCliente.Clear();
            txtDireccionCliente.Clear();
            frmBuscarClientes frmBuscarClientes = new frmBuscarClientes(this);
            frmBuscarClientes.ShowDialog();
        }

        public void Selected(ISaleElement entity)
        {
            if (entity == null) return;

            switch (entity.GetType().Name)
            {
                case "ClientIdentity":
                    _client = entity as ClientIdentity;
                    SetClient();
                    break;
                case "ProductIdentityDto":
                    _product = entity as ProductIdentityDto;
                    frmCantidad frmCantidad = new frmCantidad(this);
                    frmCantidad.ShowDialog();
                    break;
                default:
                    break;
            }
        }

        private void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            frmBuscarProductos frmBuscarProductos = new frmBuscarProductos(this);
            frmBuscarProductos.ShowDialog();
        }

        private void FillGrid()
        {
            if (_product == null) return;
            dgvPuntoVenta.Rows.Add(_product.Codigo, _product.Nombre, _product.Cantidad, _product.Precio, _product.Total);
            dgvPuntoVenta.FirstDisplayedScrollingRowIndex = dgvPuntoVenta.RowCount - 1;
            EnableRemove();
        }

        //implement member IQuantity
        public void GetQuantity(int quantity)
        {
            if (_product == null) return;

            if (!_product.EsServicio)
            {
                if (quantity > _product.Stock)
                {
                    _product = null;
                    MessageBox.Show("No hay suficientes productos en stock.", CString.DEFAULT_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                //actualiza stock
                _rpsProduct.UpdateStock(new StockDto { IdProducto = _product.IdProducto, Cantidad = quantity }, true);
            }

            _product.Cantidad = quantity;
            decimal total = _product.Precio * quantity;
            _product.Total = Math.Round(total, 2);
            _lsProducts.Add(_product);
            FillGrid();
            CalcularTotales();
            CalcularCambio();
            lblInfo.Text = _product.EsServicio ? "Servicio agregado." : "Producto agregado.";
        }

        protected void SearchProduct()
        {
            _product = _rpsProduct.GetByCode(txtCodProducto.Text.Trim());
            if (_product == null)
            {
                MessageBox.Show($"No se encontró el producto con código {txtCodProducto.Text}.", CString.DEFAULT_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCodProducto.Clear();
                txtCodProducto.Focus();
                return;
            }
            GetQuantity(1);
            txtCodProducto.Clear();
            txtCodProducto.Focus();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CalcularTotales()
        {
            if (_lsProducts == null) return;
            if (_lsProducts.Count <= 0) {
                ResetTotals();
                return;
            }

            decimal subtotal0 = _lsProducts.Where(x => x.TarifaIva == 0).Select(x => x.Total).Sum();
            decimal subtotal12 = _lsProducts.Where(x => x.TarifaIva == 12).Select(x => x.Total).Sum();
            decimal subtotal = subtotal0 + subtotal12;
            decimal totalGeneral = subtotal - _descuento;
            decimal iva = Math.Round((subtotal12 * 0.12M), 2);

            txtValorSubtotal0.Text = subtotal0.ToString().Replace(",", ".");
            txtValorSubtotal.Text = subtotal12.ToString().Replace(",", ".");
            txtValorSubtotalGral.Text = subtotal.ToString().Replace(",", ".");
            txtValorIva.Text = iva.ToString().Replace(",", ".");
            txtTotalPagar.Text = totalGeneral.ToString().Replace(",", ".");
        }

        private void CalcularCambio()
        {
            decimal pago = Convert.ToDecimal(txtPago.Text.Replace("$", "").Replace(",", "."), Utils.GetCulture());
            decimal totalPagar = Convert.ToDecimal(txtTotalPagar.Text.Replace(",", "."), Utils.GetCulture());
            
            if(pago > totalPagar)
            {
                decimal cambio = Math.Round(pago - totalPagar, 2);
                txtCambio.Text = cambio.ToString().Replace(",", ".");
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(_client == null){
                MessageBox.Show("Seleccione un cliente para continuar.", CString.DEFAULT_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtIdentCliente.Focus();
                return;
            }
                
            if (_lsProducts == null || dgvPuntoVenta.Rows.Count <= 0){
                MessageBox.Show("Ingrese al menos un producto para registrar la venta.", CString.DEFAULT_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCodProducto.Focus();
                return;
            }

            if(txtPago.Text.Equals("0.00") || txtPago.Text.Length == 0)
            {
                MessageBox.Show("Ingrese el valor que paga el cliente.", CString.DEFAULT_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPago.Focus();
                return;
            }

            decimal pago = Convert.ToDecimal(txtPago.Text.Replace("$", "").Replace(",", "."), Utils.GetCulture());
            decimal totalPagar = Convert.ToDecimal(txtTotalPagar.Text.Replace(",", "."), Utils.GetCulture());
            if (pago < totalPagar)
            {
                MessageBox.Show($"El pago del cliente ${pago}, no puede ser menor al Total a pagar ${totalPagar}.", CString.DEFAULT_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPago.Focus();
                return;
            }

            if (MessageBox.Show("¿Está seguro que desea registrar la venta?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            try
            {
                var dataOp = DataOperator.Instance;
                _invoice = new InvoiceDto()
                {
                    FechaEmision = dtpFechaEmision.Value,
                    ClienteId = _client.IdCliente,
                    FormaPago = GetPaymentMethod(),
                    BaseImponible = Convert.ToDecimal(txtValorSubtotal.Text, Utils.GetCulture()),
                    TotalDescuento = Convert.ToDecimal(txtValorDscto.Text, Utils.GetCulture()),
                    IVA = Convert.ToDecimal(txtValorIva.Text, Utils.GetCulture()),
                    Subtotal0 = Convert.ToDecimal(txtValorSubtotal0.Text, Utils.GetCulture()),
                    Subtotal2 = Convert.ToDecimal(txtValorSubtotal.Text, Utils.GetCulture()),
                    SubtotaGeneral = Convert.ToDecimal(txtValorSubtotalGral.Text, Utils.GetCulture()),
                    Total = Convert.ToDecimal(txtTotalPagar.Text, Utils.GetCulture()),
                    Pago = Convert.ToDecimal(txtPago.Text.Replace("$", ""), Utils.GetCulture()),
                    Cambio = Convert.ToDecimal(txtCambio.Text, Utils.GetCulture()),
                    Detalle = _lsProducts,
                    Auditoria = new Audit{
                        IdUser = dataOp.IdUser,
                        Username = dataOp.Username,
                        SerialMainboard = Utils.GetSerial()
                    }
                };

                var sale = new SaleService();
                int secuencial = sale.Generate(_invoice);
                if (secuencial > 0)
                {
                    PrintSale(secuencial);
                    MessageBox.Show($"Se registró la venta con comprobante nº {secuencial}.", "Proceso exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear();
                    DisableAdd();
                    DisabledRemove();
                    SetFinalConsumer();
                    txtCodProducto.Focus();
                }
                else MessageBox.Show("No se pudo procesar la venta.", "Proceso fallido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                Utils.GrabarLog("btnGuardar_Click", ex.ToString());
                MessageBox.Show(ex.Message, "Proceso fallido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Clear()
        {
            dgvPuntoVenta.Rows.Clear();
            dtpFechaEmision.Value = DateTime.Now;
            txtValorSubtotal.Text = "0.00";
            txtValorDscto.Text = "0.00";
            txtValorIva.Text = "0.00";
            txtTotalPagar.Text = "0.00";
            txtValorSubtotal0.Text = "0.00";
            txtValorSubtotalGral.Text = "0.00";
            txtPago.Text = "0.00";
            txtCambio.Text = "0.00";

            txtNombresCliente.Clear();
            txtIdentCliente.Clear();
            txtDireccionCliente.Clear();
            _lsProducts.Clear();
            _client = null;
            _invoice = null;
            _product = null;
        }

        private void ResetTotals()
        {
            txtValorSubtotal.Text = "0.00";
            txtValorDscto.Text = "0.00";
            txtValorIva.Text = "0.00";
            txtTotalPagar.Text = "0.00";
            txtValorSubtotal0.Text = "0.00";
            txtValorSubtotalGral.Text = "0.00";
            txtPago.Text = "0.00";
            txtCambio.Text = "0.00";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            RemoveProduct();
        }

        private void RemoveProduct()
        {
            try
            {
                if (dgvPuntoVenta.SelectedRows.Count <= 0) {
                    MessageBox.Show("Ningún producto seleccionado para eliminar.", CString.DEFAULT_TITLE, MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                    return;
                }
                
                if (MessageBox.Show("¿Está seguro que desea eliminar el artículo seleccionado?", CString.DEFAULT_TITLE, MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.Cancel) return;

                foreach (DataGridViewRow row in dgvPuntoVenta.SelectedRows)
                {
                    var product = _lsProducts[row.Index];
                    _rpsProduct.UpdateStock(new StockDto { IdProducto = product.IdProducto, Cantidad = product.Cantidad }, false);
                    _lsProducts.RemoveAt(row.Index);
                    dgvPuntoVenta.Rows.RemoveAt(row.Index);

                }
                CalcularTotales();
                CalcularCambio();
            }
            catch (Exception ex)
            {
                Utils.GrabarLog("RemoveProduct", ex.ToString());
            }
        }

        private void RemoveAllProducts()
        {
            try
            {
                if (dgvPuntoVenta.Rows.Count<= 0) return;

                int i = 0;
                foreach (DataGridViewRow row in dgvPuntoVenta.Rows)
                {
                    var product = _lsProducts[i];
                    _rpsProduct.UpdateStock(new StockDto { IdProducto = product.IdProducto, Cantidad = product.Cantidad }, false);
                    _lsProducts.RemoveAt(row.Index);
                    i++;
                }
            }
            catch (Exception ex)
            {
                Utils.GrabarLog("RemoveAllProducts", ex.ToString());
            }
        }

        private void dgvPuntoVenta_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Delete)
            //    RemoveProduct();
            
        }

        private void frmPuntoVenta_Activated(object sender, EventArgs e)
        {
            txtCodProducto.Focus();
        }

        private void txtIdentCliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter){
                GetClient();
                e.Handled = e.SuppressKeyPress = true;
            }
        }

        private int GetPaymentMethod()
        {
            int idPaymentMethod = 0;

            if (rbEfectivo.Checked)
                idPaymentMethod = 1;
            else if (rbTarjeta.Checked)
                idPaymentMethod = 2;

            return idPaymentMethod;
        }

        private void GetClient()
        {
            if (txtIdentCliente.Text.Length <= 0)
            {
                MessageBox.Show("Ingrese la identificación para buscar el cliente.", CString.DEFAULT_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
                
            if (!txtIdentCliente.Text.Trim().Equals("1") && txtIdentCliente.Text.Length < 10)
            {
                MessageBox.Show("Ingrese una identificación válida.", CString.DEFAULT_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
                
            _rpsClient = new ClienteRepository();
            var client = _rpsClient.GetByIdentification(txtIdentCliente.Text);
            if (client == null)
            {
                var result = MessageBox.Show($"No se encontró el cliente con identificación: {txtIdentCliente.Text}. ¿Desea registrarlo?", CString.DEFAULT_TITLE, MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if(result == DialogResult.Yes)
                {
                    var frmClientes = new frmClientes();
                    //frmClientes.MdiParent = this.MdiParent;
                    frmClientes.Location = new Point(300, 60);
                    frmClientes.ShowDialog();
                }
                return;
            }
            _client = new ClientIdentity
            {
                IdCliente = client.id_cliente,
                Identificacion = client.identificacion,
                NombresCompletos = client.nombres + " " + client.apellidos,
                Direccion = client.direccion
            };
            SetClient();
        }

        private void SetClient()
        {
            if (_client == null) return;
            txtIdentCliente.Text = _client.Identificacion;
            txtNombresCliente.Text = _client.NombresCompletos;
            txtDireccionCliente.Text = _client.Direccion;
            EnableAdd();
            lblInfo.Text = "Cliente seleccionado.";
        }

        private void btnEliminar_MouseEnter(object sender, EventArgs e)
        {
        }

        private void DisableAdd()
        {
            btnAgregar.Enabled = false;
            btnAgregar.BackColor = SystemColors.Control;
            btnAgregar.Focus();
        }
        private void EnableAdd()
        {
            btnAgregar.Enabled = true;
            btnAgregar.BackColor = Color.FromArgb(40, 167, 89);
            btnAgregar.Focus();
        }

        private void EnableRemove()
        {
            btnEliminar.Enabled = true;
            btnEliminar.BackColor = Color.FromArgb(220, 53, 69);
            btnEliminar.Focus();
        }

        private void DisabledRemove()
        {
            btnEliminar.Enabled = false;
            btnEliminar.BackColor = SystemColors.Control;
        }

        private void frmPuntoVenta_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(dgvPuntoVenta.Rows.Count > 0)
            {
                var result = MessageBox.Show("Si cierra la ventana no se registrará la venta ¿desea continuar?", CString.DEFAULT_TITLE, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    RemoveAllProducts();
                    e.Cancel = false;
                }
                else e.Cancel = true;

            }
        }

        private void SetFinalConsumer()
        {
            _client = new ClientIdentity
            {
                IdCliente = 1,
                Identificacion = "9999999999",
                NombresCompletos = "CONSUMIDOR FINAL",
                Direccion = String.Empty
            };
            SetClient();
            btnBuscarCliente.Focus();
        }

        private void PrintSale(int secuencial)
        {
            DataSet dsFactura = _rpsReport.GetByInvoice(secuencial.ToString());
            Company company = _rpsParams.Get() as Company;
            var dtCompany = new CompanyMapper().JsonCompanyToDataTable(company);
            dsFactura.Tables.Add(dtCompany);

            var printParams = _rpsParams.GetPrintParams();
            var printerSettings = new PrinterSettings
            {
                PrinterName = printParams.Where(x => x.Nombre.Equals("impresora"))
                .Select(x => x.Valor).FirstOrDefault()
            };

            if (!printerSettings.IsValid)
            {
                MessageBox.Show($"No se pudo conectar con la impresora {printerSettings.PrinterName}.", CString.DEFAULT_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            //var frmReportVentas = new frmReportVentas(new ReportData { Data = dsFactura, TipoReporte = TipoReporte.FACTURA_VENTA, Criterios = null });
            //frmReportVentas.ShowDialog();

            var ticketVenta = new ticketVenta();
            ticketVenta.DataSource = dsFactura.Tables["table"];
            ticketVenta.tblDetailInvoice.DataSource = dsFactura.Tables["table1"];

            var reportSource = new Telerik.Reporting.InstanceReportSource();
            reportSource.ReportDocument = ticketVenta;

            //IMPRIMIR DIRECTO
            var reportProcessor = new Telerik.Reporting.Processing.ReportProcessor();
            reportProcessor.PrintReport(reportSource, printerSettings);

            //var x = new frmTicketVenta(reportSource);
            //x.ShowDialog();

            //frmReportVentas frmReportVentas = new frmReportVentas(new ReportData { Data = dsFactura, TipoReporte = TipoReporte.FACTURA_VENTA, Criterios = null });
            //frmReportVentas.ShowDialog();
        }

        private void SetCompanyColors()
        {
            pnAside.BackColor = DataOperator.Instance.ColorPrimary;
            pnAside2.BackColor = DataOperator.Instance.ColorPrimary;
            lblDivisor.BackColor = DataOperator.Instance.ColorSecondary;
            btnGuardar.BackColor = DataOperator.Instance.ColorSecondary;
            txtValorDscto.BackColor = DataOperator.Instance.ColorPrimary;
            txtValorDscto.BackColor = DataOperator.Instance.ColorPrimary;
            txtValorIva.BackColor = DataOperator.Instance.ColorPrimary;
            txtTotalPagar.ForeColor = DataOperator.Instance.ColorPrimary;
            txtValorSubtotal.BackColor = DataOperator.Instance.ColorPrimary;
            dgvPuntoVenta.ColumnHeadersDefaultCellStyle.BackColor = DataOperator.Instance.ColorPrimary;
        }

        private void txtCodProducto_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                SearchProduct();
            }
        }

        private void txtPago_TextChanged(object sender, EventArgs e)
        {
            ValidadorFormatoMoneda(txtPago, txtPago_TextChanged);
            CalcularCambio();
        }

        private void ValidadorFormatoMoneda(TextBox caja, EventHandler nombreMetodo)
        {
            string value = caja.Text.Replace(",", "").Replace("$", "").Replace(".", "").TrimStart('0');
            decimal ul;
            //Check we are indeed handling a number
            if (decimal.TryParse(value, out ul))
            {
                ul /= 100;
                //Unsub the event so we don't enter a loop
                caja.TextChanged -= nombreMetodo;
                //Format the text as currency
                caja.Text = string.Format(Utils.GetCulture(), "{0:C2}", ul).Replace(",", "");
                caja.TextChanged += nombreMetodo;
                caja.Select(caja.Text.Length, 0);
            }
            bool goodToGo = TextisValid(caja.Text);

            if (!goodToGo)
            {
                caja.Text = "0.00";
                caja.Select(caja.Text.Length, 0);
            }
        }

        private bool TextisValid(string text)
        {
            Regex money = new Regex(@"^\$(\d{1,3}(\d{3})*|(\d+))(\.\d{2})?$");
            return money.IsMatch(text);
        }

        private void txtPago_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
                e.Handled = e.SuppressKeyPress = true;
        }

        private void dgvPuntoVenta_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            e.Cancel = true;
            //RemoveProduct();
        }
    }
}
