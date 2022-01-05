using HendrixAccountant.ApplicationCore.Constants;
using HendrixAccountant.ApplicationCore.DTOs;
using HendrixAccountant.ApplicationCore.Interfaces.Forms;
using HendrixAccountant.ApplicationCore.Interfaces.Repositories;
using HendrixAccountant.ApplicationCore.Models;
using HendrixAccountant.Common;
using HendrixAccountant.Data.Repositories;
using System;
using System.Windows.Forms;

namespace HendrixAccountant.Forms.Products
{
    public partial class frmBajaProductos : Form, IFindElement
    {
        private ProductIdentityDto _product;
        private IProductTempRepository _rpsProduct;

        public frmBajaProductos()
        {
            InitializeComponent();
            _rpsProduct = new ProductTempRepository();
            _product = null;
        }

        public void Selected(ISaleElement entity)
        {
            if (entity == null) return;

            switch (entity.GetType().Name)
            {
                case "ProductIdentityDto":
                    _product = entity as ProductIdentityDto;
                    SetProduct();
                    txtCantidad.Focus();
                    break;
                default:
                    break;
            }
        }

        private void btnDarBaja_Click(object sender, EventArgs e)
        {

        }

        private void btnDarBaja_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (_product == null)
                {
                    MessageBox.Show("Seleccione el producto a dar de baja.", CString.DEFAULT_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtCodProducto.Focus();
                    return;
                }

                if (txtCantidad.Text.Length == 0 || txtCantidad.Text.Equals("0"))
                {
                    MessageBox.Show("Ingrese la cantidad de productos que va a dar de baja.", CString.DEFAULT_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtCantidad.Focus();
                    return;
                }

                if (cboMotivo.SelectedIndex == -1)
                {
                    MessageBox.Show("Seleccione el motivo para dar de baja al producto.", CString.DEFAULT_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cboMotivo.Focus();
                    return;
                }

                var dataOp = DataOperator.Instance;
                var product = new ProductWithdrawal
                {
                    IdProducto = _product.IdProducto,
                    Cantidad = int.Parse(txtCantidad.Text.Trim()),
                    IdMotivo = cboMotivo.SelectedIndex + 1,
                    OtroMotivo = txtOtroMotivo.Text,
                    Usuario = dataOp.Username
                };
                
                if (!_rpsProduct.UnsuscribeProduct(product))
                {
                    MessageBox.Show("No se pudo dar de baja a los productos.", CString.DEFAULT_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                MessageBox.Show($"Se ha dado de baja a {_product.Cantidad} {_product.Nombre}.", CString.DEFAULT_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                _product = null;
                txtCantidad.Clear();
                txtCodProducto.Clear();
                txtNombreProducto.Clear();
                txtOtroMotivo.Clear();
                cboMotivo.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                Utils.GrabarLog("DarBaja", ex.ToString());
                MessageBox.Show(ex.Message, CString.DEFAULT_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void frmBajaProductos_Load(object sender, EventArgs e)
        {

        }

        private void frmBajaProductos_Activated(object sender, EventArgs e)
        {
            txtCodProducto.Focus();
        }

        private void btnBuscarProductos_Click(object sender, EventArgs e)
        {
            frmBuscarProductos frmBuscarProductos = new frmBuscarProductos(this, true);
            frmBuscarProductos.ShowDialog();
        }

        private void txtCodProducto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter){
                SearchProduct();
                e.Handled = e.SuppressKeyPress = true;
            }
        }

        protected void SearchProduct()
        {
            _product = _rpsProduct.GetByCode(txtCodProducto.Text.Trim());
            if (_product == null)
            {
                MessageBox.Show($"No se encontró el producto con código {txtCodProducto.Text}.", CString.DEFAULT_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCodProducto.Clear();
                txtNombreProducto.Clear();
                txtCodProducto.Focus();
                return;
            }

            SetProduct();
            txtCantidad.Focus();
        }

        private void SetProduct()
        {
            txtCodProducto.Text = _product.Codigo;
            txtNombreProducto.Text = _product.Nombre;
        }

    }
}
