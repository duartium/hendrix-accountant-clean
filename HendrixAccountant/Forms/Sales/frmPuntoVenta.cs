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
        private bool isKeyValid;
        private bool isEditingPrice;
        TextBox tbChangeQuantity;
        TextBox tbPrecioChanged;
        bool quantityHasEvent;
        bool priceHasEvent;
        public frmPuntoVenta()
        {
            InitializeComponent();
            SetCompanyColors();
            _product = null;
            _lsProducts = new List<ProductIdentityDto>();
            _client = null;
            _invoice = null;
            _descuento = 0;
            _rpsClient = new ClienteRepository();
            _rpsProduct = new ProductTempRepository();
            _rpsParams = new CompanyRepository();
            _rpsReport = new SaleReportService();
            SetFinalConsumer();
            isKeyValid = false;
            this.dgvPuntoVenta.AutoGenerateColumns = false;
            quantityHasEvent = false;
            priceHasEvent = false;
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
            //dgvPuntoVenta.DataSource = _lsProducts;
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

            decimal subtotal0 = Math.Round(_lsProducts.Where(x => x.TarifaIva == 0).Select(x => x.Total).Sum(), 2);
            decimal subtotal12 = Math.Round(_lsProducts.Where(x => x.TarifaIva == 12).Select(x => x.Total).Sum(), 2);
            decimal subtotal = Math.Round(subtotal0 + subtotal12, 2);
            decimal totalGeneral = Math.Round(subtotal - _descuento, 2);
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
            
            if(pago >= totalPagar)
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

            if (rbEfectivo.Checked)
            {
                if (txtPago.Text.Equals("0.00") || txtPago.Text.Length == 0)
                {
                    MessageBox.Show("Ingrese el valor que paga el cliente.", CString.DEFAULT_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtPago.Focus();
                    return;
                }
            }
            else
                txtPago.Text = txtTotalPagar.Text;

            decimal pago = Convert.ToDecimal(txtPago.Text.Replace("$", "").Replace(",", "."), Utils.GetCulture());
            decimal totalPagar = Convert.ToDecimal(txtTotalPagar.Text.Replace(",", "."), Utils.GetCulture());
            if (pago < totalPagar)
            {
                MessageBox.Show($"El pago del cliente ${pago} no puede ser menor al Total a pagar ${totalPagar}.", CString.DEFAULT_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                    Observaciones = txtObservaciones.Text,
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
                    if(chbImprimir.Checked)
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
            txtObservaciones.Clear();

            _lsProducts.Clear();
            _client = null;
            _invoice = null;
            _product = null;
            rbEfectivo.Checked = true;
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

        private void RemoveStockProducts()
        {
            try
            {
                if (dgvPuntoVenta.SelectedRows.Count > 0)
                {
                    foreach (DataGridViewRow row in dgvPuntoVenta.SelectedRows)
                    {
                        var product = _lsProducts[row.Index];
                        _rpsProduct.UpdateStock(new StockDto { IdProducto = product.IdProducto, Cantidad = product.Cantidad }, false);
                    }
                }
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
            if (_rpsClient == null) _rpsClient = new ClienteRepository();

            var finalConsumer = _rpsClient.GetByIdentification("9999999999999");
            _client = new ClientIdentity
            {
                IdCliente = finalConsumer.id_cliente,
                Identificacion = finalConsumer.identificacion,
                NombresCompletos = finalConsumer.nombres + " "+finalConsumer.apellidos,
                Direccion = finalConsumer.direccion
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

        private void txtCodProducto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SearchProduct();
                e.Handled = e.SuppressKeyPress = true;
            }
        }

        private void dgvPuntoVenta_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {

            try
            {
                string x = dgvPuntoVenta.Columns[dgvPuntoVenta.CurrentCell.ColumnIndex].HeaderText;
                if (dgvPuntoVenta.CurrentCell.ColumnIndex == 3)//precio
                {
                    TextBox tbPrecio = e.Control as TextBox;
                    tbPrecio.MaxLength = 10;
                    if (tbPrecio != null)
                    {
                        tbPrecio.TextChanged -= new EventHandler(tb_TextChanged);
                        tbPrecio.TextChanged += new EventHandler(tb_TextChanged);
                    }
                }
                else if (dgvPuntoVenta.CurrentCell.ColumnIndex == 2) //cantidad
                {
                    isEditingPrice = false;
                    TextBox tbCantidad = e.Control as TextBox;
                    tbCantidad.MaxLength = 10;
                    tbCantidad.TextChanged -= new EventHandler(tb_TextChangedInt);
                    tbCantidad.TextChanged += new EventHandler(tb_TextChangedInt);
                }
            }
            catch (ArgumentException)
            {

            }
            catch (Exception ex)
            {
                Utils.GrabarLog("dgvPuntoVenta_EditingControlShowing", ex.ToString());
            }
        }

        private void tb_TextChanged(object sender, EventArgs e)
        {
            if (!isEditingPrice) return;

            tbPrecioChanged = sender as TextBox;
            tbPrecioChanged.MaxLength = 10;

            if (!priceHasEvent)
            {
                tbPrecioChanged.KeyPress -= new KeyPressEventHandler(column_keypress_Validation);
                tbPrecioChanged.KeyPress += new KeyPressEventHandler(column_keypress_Validation);
            }

            string valor = (sender as TextBox).Text;
            if (valor.StartsWith("."))
            {
                tbPrecioChanged.Text = "";
                return;
            }


            if (valor != "" && !valor.StartsWith("."))
            {
                int rowIndex = dgvPuntoVenta.CurrentRow.Index;
                var product = _lsProducts[rowIndex];

                product.Precio = Convert.ToDecimal(valor, Utils.GetCulture());
                _lsProducts[rowIndex].Precio = Convert.ToDecimal(valor, Utils.GetCulture());
                //_product.Cantidad = product.Cantidad;
                
                decimal total = product.Precio * product.Cantidad;
                _lsProducts[rowIndex].Total = Math.Round(total, 2);
                
                dgvPuntoVenta.Rows[rowIndex].Cells[4].Value = total.ToString();
               
                CalcularTotales();
            }
        }

        private void tb_TextChangedInt(object sender, EventArgs e)
        {
            if (isEditingPrice) return;

            tbChangeQuantity = sender as TextBox;
            tbChangeQuantity.MaxLength = 10;

            if (!quantityHasEvent)
            {
                tbChangeQuantity.KeyPress -= new KeyPressEventHandler(column_keypress_Validation);
                tbChangeQuantity.KeyPress += new KeyPressEventHandler(column_keypress_Validation);
            }
            

            string cantidad = (sender as TextBox).Text;

            if (cantidad != "" && !cantidad.Contains("."))
            {
                int rowIndex = dgvPuntoVenta.CurrentRow.Index;
                var product = _lsProducts[rowIndex];
                _lsProducts[rowIndex].Cantidad = Convert.ToInt32(cantidad, Utils.GetCulture());
                //_product.Cantidad = _lsProducts[rowIndex].Cantidad;

                decimal total = product.Precio * product.Cantidad;
                _lsProducts[rowIndex].Total = Math.Round(total, 2);
                dgvPuntoVenta.Rows[rowIndex].Cells[4].Value = total.ToString();

                CalcularTotales();
            }
            quantityHasEvent = true;
        }

        private void columns_keydown(object sender, KeyEventArgs e)
        {
            string valor = (sender as TextBox).Text;

            int rowIndex = dgvPuntoVenta.CurrentRow.Index;
            var product = _lsProducts[rowIndex];

            _lsProducts[rowIndex].Precio = Convert.ToDecimal(valor, Utils.GetCulture());
            _product.Cantidad = product.Cantidad;

            decimal total = _product.Precio * product.Cantidad;
            _lsProducts[rowIndex].Total = Math.Round(total, 2);

            CalcularTotales();

        }

        private void column_int_keypress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                isKeyValid = false;
                return;
            }
            else
                isKeyValid = true;

            string valor = (sender as TextBox).Text;
                
            //solo un punto decimal
            if ((e.KeyChar == '.') && (valor.IndexOf('.') > -1))
            {
                e.Handled = true;
                isKeyValid = false;
            }else
                isKeyValid = true;

        }

        private void column_keypress_Validation(object sender, KeyPressEventArgs e)
        {
            if (isEditingPrice)
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
                {
                    e.Handled = true;
                    isKeyValid = false;
                    return;
                }
                else
                    isKeyValid = true;

                string valor = (sender as TextBox).Text;

                //solo un punto decimal
                if ((e.KeyChar == '.') && (valor.IndexOf('.') > -1))
                {
                    e.Handled = true;
                    isKeyValid = false;
                }
                else
                    isKeyValid = true;
            }
            else
            {
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                    isKeyValid = false;
                    return;
                }
                else
                    isKeyValid = true;
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            RemoveAllProducts();
            Clear();
            SetFinalConsumer();
            txtCodProducto.Focus();
        }

        private void rbTarjeta_CheckedChanged(object sender, EventArgs e)
        {
            lblPagoCliente.Visible = false;
            txtPago.Text = txtTotalPagar.Text;
            txtPago.Visible = false;
            lblCambio.Visible = false;
            txtCambio.Visible = false;
        }

        private void rbEfectivo_CheckedChanged(object sender, EventArgs e)
        {
            lblPagoCliente.Visible = true;
            txtPago.Text = "0.00";
            txtPago.Visible = true;
            lblCambio.Visible = true;
            txtCambio.Visible = true;
        }

        private void dgvPuntoVenta_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            isEditingPrice = e.ColumnIndex == 3;
        }
    }
}
