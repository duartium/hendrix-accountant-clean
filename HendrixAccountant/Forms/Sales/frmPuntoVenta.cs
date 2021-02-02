using HendrixAccountant.ApplicationCore.Constants;
using HendrixAccountant.ApplicationCore.DTOs;
using HendrixAccountant.ApplicationCore.Interfaces.Forms;
using HendrixAccountant.ApplicationCore.Interfaces.Repositories;
using HendrixAccountant.ApplicationCore.Models;
using HendrixAccountant.ApplicationCore.Services;
using HendrixAccountant.Common;
using HendrixAccountant.Data;
using HendrixAccountant.Data.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
        public frmPuntoVenta()
        {
            InitializeComponent();
            _product = null;
            _lsProducts = new List<ProductIdentityDto>();
            _client = null;
            _invoice = null;
            _descuento = 0;
            _rpsClient = null;
            _rpsProduct = new ProductTempRepository();
        }

        private void frmPuntoVenta_Load(object sender, EventArgs e)
        {
            DisableAdd();
            DisabledRemove();
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
            dgvPuntoVenta.Rows.Add(_product.IdProducto, _product.Nombre, _product.Cantidad, _product.Precio, _product.Total);
            dgvPuntoVenta.FirstDisplayedScrollingRowIndex = dgvPuntoVenta.RowCount - 1;
            EnableRemove();
        }

        //implement member IQuantity
        public void GetQuantity(int quantity)
        {
            if (_product == null) return;

            if (quantity > _product.Stock)
            {
                _product = null;
                MessageBox.Show("No hay suficientes productos en stock.", CString.DEFAULT_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //actualiza stock
            _rpsProduct.UpdateStock(new StockDto{ IdProducto = _product.IdProducto, Cantidad = quantity }, true);

            _product.Cantidad = quantity;
            decimal total = _product.Precio * quantity;
            _product.Total = Math.Round(total, 2);
            _lsProducts.Add(_product);
            FillGrid();
            CalcularTotales();
            lblInfo.Text = "Producto agregado.";
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CalcularTotales()
        {
            if (_lsProducts == null) return;
            if (_lsProducts.Count <= 0) return;
            decimal subtotal = _lsProducts.Select(x => x.Total).Sum();
            decimal totalGeneral = subtotal - _descuento;

            txtValorSubtotal.Text = subtotal.ToString().Replace(",", ".");
            txtTotalPagar.Text = totalGeneral.ToString().Replace(",", ".");
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
                    BaseImponible = Convert.ToDecimal(txtValorSubtotal.Text, Utils.GetCulture()),
                    TotalDescuento = Convert.ToDecimal(txtValorDscto.Text, Utils.GetCulture()),
                    IVA = Convert.ToDecimal(txtValorIva.Text, Utils.GetCulture()),
                    Total = Convert.ToDecimal(txtTotalPagar.Text, Utils.GetCulture()),
                    Detalle = _lsProducts,
                    Auditoria = new Audit{
                        IdUser = dataOp.IdUser,
                        Username = dataOp.Username,
                        SerialMainboard = Utils.GetSerial()
                    }
                };
                var sale = new SaleService();
                if (sale.Generate(_invoice))
                {
                    MessageBox.Show("Venta registrada con éxito", "Proceso exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear();
                    DisableAdd();
                    DisabledRemove();
                }
                else MessageBox.Show("No se pudo procesar la venta.", "Proceso fallido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                Utils.GrabarLog("btnGuardar_Click", ex.ToString());
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
            txtNombresCliente.Clear();
            txtIdentCliente.Clear();
            txtDireccionCliente.Clear();
            _lsProducts.Clear();
            _client = null;
            _invoice = null;
            _product = null;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            RemoveProduct();
        }

        private void RemoveProduct()
        {
            try
            {
                if (dgvPuntoVenta.SelectedRows.Count <= 0) return;
                if (MessageBox.Show("¿Está seguro que desea eliminar el artículo seleccionado?", CString.DEFAULT_TITLE, MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.Cancel) return;

                foreach (DataGridViewRow row in dgvPuntoVenta.SelectedRows)
                {
                    var product = _lsProducts[row.Index];
                    _rpsProduct.UpdateStock(new StockDto { IdProducto = product.IdProducto, Cantidad = product.Cantidad }, false);
                    _lsProducts.RemoveAt(row.Index);
                    dgvPuntoVenta.Rows.RemoveAt(row.Index);

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
            if (e.KeyCode == Keys.Delete)
                RemoveProduct();
        }

        private void frmPuntoVenta_Activated(object sender, EventArgs e)
        {
            txtIdentCliente.Focus();
        }

        private void txtIdentCliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter){
                GetClient();
                e.Handled = e.SuppressKeyPress = true;
            }
        }

        private void GetClient()
        {
            if (txtIdentCliente.Text.Length <= 0)
            {
                MessageBox.Show("Ingrese la identifiación para buscar el cliente.", CString.DEFAULT_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
                
            if (txtIdentCliente.Text.Length < 10)
            {
                MessageBox.Show("Ingrese una identifiación válida.", CString.DEFAULT_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
                
            _rpsClient = new ClienteRepository();
            var client = _rpsClient.GetByIdentification(txtIdentCliente.Text);
            if (client == null)
            {
                MessageBox.Show("No se econtró el cliente con la identificación: " + txtIdentCliente.Text + ".", CString.DEFAULT_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}
