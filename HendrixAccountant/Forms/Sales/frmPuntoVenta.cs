using HendrixAccountant.ApplicationCore.Constants;
using HendrixAccountant.ApplicationCore.DTOs;
using HendrixAccountant.ApplicationCore.Interfaces.Forms;
using HendrixAccountant.ApplicationCore.Models;
using HendrixAccountant.ApplicationCore.Services;
using HendrixAccountant.Common;
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
        public frmPuntoVenta()
        {
            InitializeComponent();
            _product = null;
            _lsProducts = new List<ProductIdentityDto>();
            _client = null;
            _invoice = null;
            _descuento = 0;
        }

        private void frmPuntoVenta_Load(object sender, EventArgs e)
        {
            
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
           frmBuscarProductos frmBuscarProductos = new frmBuscarProductos(this);
           frmBuscarProductos.ShowDialog();
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
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
                    txtCodCliente.Text = _client.Identificacion;
                    txtNombresCliente.Text = _client.NombresCompletos;
                    if (_client != null)
                        btnAgregar.Enabled = true;
                    lblInfo.Text = "Cliente seleccionado.";
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
        }

        //implement member IQuantity
        public void GetQuantity(int quantity)
        {
            if (_product == null) return;
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
                        IdUser = 1,
                        Username = "prueba",
                        SerialMainboard = Utils.GetSerial()
                    }
                };
                var sale = new SaleService();
                if (sale.Generate(_invoice))
                {
                    dgvPuntoVenta.Rows.Clear();
                    MessageBox.Show("Venta registrada con éxito", "Proceso exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                    
                else
                    MessageBox.Show("No se pudo procesar la venta.", "Proceso fallido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
            txtValorSubtotal.Clear();
            txtValorDscto.Clear();
            txtValorIva.Clear();
            txtTotalPagar.Clear();
            txtNombresCliente.Clear();
            txtCodCliente.Clear();
            txtDireccionCliente.Clear();
        }

    }
}
