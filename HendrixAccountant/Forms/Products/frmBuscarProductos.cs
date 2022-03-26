using HendrixAccountant.ApplicationCore.Constants;
using HendrixAccountant.ApplicationCore.DTOs;
using HendrixAccountant.ApplicationCore.Entities;
using HendrixAccountant.ApplicationCore.Interfaces.Forms;
using HendrixAccountant.ApplicationCore.Interfaces.Repositories;
using HendrixAccountant.Common;
using HendrixAccountant.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace HendrixAccountant
{
    public partial class frmBuscarProductos : Form
    {
        private readonly IProductTempRepository _rpsProduct;
        private IFindElement _caller;
        private bool _esRegistroCompra;
        public frmBuscarProductos()
        {
            InitializeComponent();
            SetCompanyColors();
            _rpsProduct = new ProductTempRepository();
        }

        public frmBuscarProductos(IFindElement caller, bool esRegistroCompra = false)
        {
            InitializeComponent();
            SetCompanyColors();
            _caller = caller;
            _rpsProduct = new ProductTempRepository();
            _esRegistroCompra = esRegistroCompra;
        }

        private void frmBuscarProductos_Load(object sender, EventArgs e)
        {
            Search();
        }

        #region Private methods

        private void Search()
        {
            try
            {
                var filters = new ProductFilterDto
                {
                    Codigo = txtCodProducto.Text,
                    NombreProducto = txtNombreProd.Text,
                    EsServicio = _esRegistroCompra ? 0 : -1 //solo productos
                };

                var products = _rpsProduct.GetAll(filters);
                if (products == null)
                {
                    MessageBox.Show("No se encontraron productos.", CString.DEFAULT_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                FillGrid(products);
            }
            catch (Exception ex)
            {
                Utils.GrabarLog("Search", ex.ToString());
                MessageBox.Show("No se pudo obtener los productos.", CString.DEFAULT_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FillGrid(List<Product> data)
        {
            dgvProductos.DataSource = null;
            dgvProductos.Rows.Clear();
            dgvProductos.AutoGenerateColumns = false;
            int i = 0;
            foreach (var item in data)
            {
                dgvProductos.Rows.Add(item.codigo, item.nombre, item.stock, item.precio_venta, item.categoria);
                dgvProductos.Rows[i].Tag = item;
                i++;
            }
                
        }

        private ProductIdentityDto MapRowToProduct(DataGridViewRow row)
        {
            ProductIdentityDto product = null;
            try
            {
                var rowProduct = (row.Tag as Product);
                product = new ProductIdentityDto
                {
                    IdProducto = rowProduct.id_producto,
                    Codigo = rowProduct.codigo,
                    Nombre = rowProduct.nombre,
                    Precio = rowProduct.precio_venta,
                    Stock = rowProduct.stock,
                    TarifaIva = rowProduct.tarifa_iva,
                    EsServicio = rowProduct.es_servicio
                };
            }
            catch (Exception ex)
            {
                Utils.GrabarLog("MapRowToProduct", ex.ToString());
            }
            return product;
        }
        #endregion

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void dgvProductos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            ProductIdentityDto product = MapRowToProduct(dgvProductos.Rows[e.RowIndex]);

            if (!_esRegistroCompra && !product.EsServicio)
            {
                if (product.Stock <= 0)
                {
                    MessageBox.Show("Stock insuficiente de artículo: " + product.Nombre, CString.DEFAULT_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

            if (_caller.GetType() == typeof(frmProductos))
                _caller.Selected((dgvProductos.Rows[e.RowIndex].Tag as Product));
            else
                _caller.Selected(product);
            
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void frmBuscarProductos_Activated(object sender, EventArgs e)
        {
            txtCodProducto.Focus();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombreProd.Clear();
            txtCodProducto.Clear();
            dgvProductos.Rows.Clear();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNombreProd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter){
                Search();
                e.Handled = e.SuppressKeyPress = true;
            }
        }

        private void txtCodProducto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter){
                Search();
                e.Handled = e.SuppressKeyPress = true;
            }
        }

        private void SetCompanyColors()
        {
            pnAside.BackColor = DataOperator.Instance.ColorPrimary;
            btnConsultar.BackColor = DataOperator.Instance.ColorSecondary;
            btnCerrar.BackColor = DataOperator.Instance.ColorSecondary;
            btnLimpiar.BackColor = DataOperator.Instance.ColorSecondary;
            dgvProductos.ColumnHeadersDefaultCellStyle.BackColor = DataOperator.Instance.ColorPrimary;
        }

        private void txtCodProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetterOrDigit(e.KeyChar) || e.KeyChar == '\b')
            {
                if (!e.KeyChar.ToString().Contains("Ñ"))
                {
                    e.Handled = false;
                    e.KeyChar = Char.ToUpper(e.KeyChar);
                }
                else { e.Handled = true; }
            }
            else e.Handled = true;
        }
    }
}