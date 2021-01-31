using HendrixAccountant.ApplicationCore.Constants;
using HendrixAccountant.ApplicationCore.DTOs;
using HendrixAccountant.ApplicationCore.Entities;
using HendrixAccountant.ApplicationCore.Interfaces.Forms;
using HendrixAccountant.ApplicationCore.Interfaces.Repositories;
using HendrixAccountant.Common;
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
    public partial class frmProductos : Form, IFindElement
    {
        private IProductTempRepository _rpsProduct;
        private Product _product;
        public frmProductos()
        {
            InitializeComponent();
            _rpsProduct = new ProductTempRepository();
        }

        public void Selected(ISaleElement entity)
        {
            if (entity == null) return;

            switch (entity.GetType().Name)
            {
                case "Product":
                    _product = entity as Product;
                    SetProduct();
                    break;
                default:
                    break;
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                frmBuscarProductos frmBuscarProductos = new frmBuscarProductos(this);
                frmBuscarProductos.ShowDialog();
            }
            catch (Exception ex)
            {
                Utils.GrabarLog("Search", ex.ToString());
                MessageBox.Show("Error no controlado en el proceso.", "Productos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rbnNuevo_CheckedChanged(object sender, EventArgs e)
        {
            btnBuscar.Enabled = false;
            btnEliminar.Enabled = true;
            btnEliminar.BackColor = SystemColors.Control;
            btnBuscar.BackColor = SystemColors.Control;
        }

        private void SetProduct()
        {
            if (_product == null) return;
            txtNombre.Text = _product.nombre;
            txtDescripcion.Text = _product.descripcion;
            txtCosto.Text = _product.costo.ToString();
            txtPrecioVenta.Text = _product.precio_venta.ToString();
            txtStock.Text = _product.stock.ToString();
            txtCodProveedor.Text = "";
            txtNombreProveedor.Text = "";
            //EnabledTextboxs(false);
            //txtIdentificacion.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Length == 0 ||
               txtCosto.Text.Trim().Length == 0 ||
               txtPrecioVenta.Text.Trim().Length == 0 ||
               txtStock.Text.Trim().Length == 0 ||
               txtStock.Text.Trim().Length == 0)
            {
                MessageBox.Show("Complete los datos del producto para proceder con su registro.", CString.DEFAULT_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            var product = new ProductDto
            {
                Nombre = txtNombre.Text,
                Descripcion = txtDescripcion.Text,
                Costo = Convert.ToDecimal(txtCosto.Text, Utils.GetCulture()),
                Precio = Convert.ToDecimal(txtPrecioVenta.Text, Utils.GetCulture()),
                Stock = Convert.ToInt32(txtStock.Text),
                IdCategoria = 1,
                IdProveedor = 1,
                IdTalla = 1
            };
            if (_rpsProduct.Save(product))
            {
                MessageBox.Show("Producto registrado con éxito.", CString.DEFAULT_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                MessageBox.Show("No se pudo registrar el producto.", CString.DEFAULT_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Clear();
        }
        private void Clear()
        {
            txtNombre.Clear();
            txtDescripcion.Clear();
            txtCosto.Text = "0.00";
            txtPrecioVenta.Text = "0.00";
            txtCodProveedor.Clear();
            txtNombreProveedor.Clear();
            txtStock.Text = "0";
        }

        private void frmProductos_Load(object sender, EventArgs e)
        {
           
        }
    }
}
