using HendrixAccountant.ApplicationCore.Constants;
using HendrixAccountant.ApplicationCore.DTOs;
using HendrixAccountant.ApplicationCore.Entities;
using HendrixAccountant.ApplicationCore.Interfaces.Forms;
using HendrixAccountant.ApplicationCore.Interfaces.Repositories;
using HendrixAccountant.ApplicationCore.Interfaces.Services;
using HendrixAccountant.Common;
using HendrixAccountant.Data.Repositories;
using HendrixAccountant.Data.Services;
using HendrixAccountant.Infrastructure.Shared.Services;
using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Color = System.Drawing.Color;

namespace HendrixAccountant
{
    public partial class frmProductos : Form, IFindElement
    {
        private IProductTempRepository _rpsProduct;
        private Product _product;
        private ICatalogueRepository _rpsCatalogue;
        private SupplierDto _supplier;
        private readonly IBarCodeService _barcodeService;
        private readonly PdfService _pdfService;

        public frmProductos()
        {
            InitializeComponent();
            pnHeader.BackColor = DataOperator.Instance.ColorPrimary;
            _rpsProduct = new ProductTempRepository();
            _rpsCatalogue = new CatalogueRepository();
            LoadCatalogs();
            _supplier = null;
            _barcodeService = new BarCodeService();
            _pdfService = new PdfService();
        }

        public void Selected(ISaleElement entity)
        {
            if (entity == null) return;

            switch (entity.GetType().Name)
            {
                case "Product":
                    _product = entity as Product;
                    _supplier = new SupplierDto { IdProveedor = _product.proveedor_id, Nombre = _product.proveedor };
                    SetProduct();
                    break;
                case "SupplierDto":
                    _supplier = entity as SupplierDto;
                    SetSupplier();
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
            Clear();
            EnabledTextboxs(true);
            btnBuscarProveedor.Enabled = true;
            DisabledRemove();
            DisabledSearch();
            EnabledCombos(true);
            txtNombre.Focus();
        }

        private void SetProduct()
        {
            if (_product == null || _supplier == null) return;
            txtNombre.Text = _product.nombre;
            txtDescripcion.Text = _product.descripcion;
            txtCosto.Text = _product.costo.ToString();
            txtPrecioVenta.Text = _product.precio_venta.ToString();
            txtStock.Text = _product.stock.ToString();
            txtCodProveedor.Text = _supplier.IdProveedor.ToString();
            txtNombreProveedor.Text = _supplier.Nombre;
            cmbTalla.SelectedValue = _product.id_talla;
            cboCategoria.SelectedValue = _product.categoria_id;
            EnabledTextboxs(true);
            EnabledCombos(true);
            btnBuscarProveedor.Enabled = true;
            txtNombre.Focus();
        }

        private void SetSupplier()
        {
            if (_supplier == null) return;
            txtCodProveedor.Text = _supplier.IdProveedor.ToString();
            txtNombreProveedor.Text = _supplier.Nombre.ToString();
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

            if(_supplier == null)
            {
                MessageBox.Show("Seleccione al proveedor. Campo obligatorio", CString.DEFAULT_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            bool isUpdate = false;
            string mensaje = "Producto registrado con éxito.";
            var dataOp = DataOperator.Instance;
            var product = new ProductDto
            {
                IdProducto = _product == null? -1 :_product.id_producto,
                Nombre = txtNombre.Text,
                Descripcion = txtDescripcion.Text,
                Costo = Convert.ToDecimal(txtCosto.Text.Trim().Substring(1).Replace(",", ""), Utils.GetCulture()),
                Precio = Convert.ToDecimal(txtPrecioVenta.Text.Trim().Substring(1).Replace(",", ""), Utils.GetCulture()),
                Stock = Convert.ToInt32(txtStock.Text),
                IdCategoria = Convert.ToInt32(cboCategoria.SelectedValue),
                IdProveedor = _supplier.IdProveedor,
                IdTalla = Convert.ToInt32(cmbTalla.SelectedValue),
                Usuario = dataOp.Username
            };

            if (rbnModificar.Checked) { isUpdate = true; mensaje = mensaje.Replace("registrado", "actualizado"); }
            if (_rpsProduct.Save(product, isUpdate))
            {
                Clear();
                MessageBox.Show(mensaje, CString.DEFAULT_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNombre.Focus();
                return;
            }
            else
            {
                MessageBox.Show("No se pudo registrar/modificar el producto.", CString.DEFAULT_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            txtCosto.Clear();
            txtPrecioVenta.Clear();
            txtCodProveedor.Clear();
            txtNombreProveedor.Clear();
            txtStock.Clear();
        }

        private void EnabledTextboxs(bool valor)
        {
            txtNombre.Enabled = valor;
            txtDescripcion.Enabled = valor;
            txtCosto.Enabled = valor;
            txtPrecioVenta.Enabled = valor;
            txtStock.Enabled = valor;
        }

        private void frmProductos_Load(object sender, EventArgs e)
        {
            DisabledSearch();
            DisabledRemove();
            txtNombreProveedor.Enabled = false;
            txtCodProveedor.Enabled = false;
        }

        private void LoadComboBoxTallas()
        {
            BindingSource source = new BindingSource();
            cmbTalla.DisplayMember = "Descripcion";
            cmbTalla.ValueMember = "Id";
            var data = _rpsCatalogue.GetByName("tallas");
            source.DataSource = data;
            cmbTalla.DataSource = source.DataSource;
        }

        private void LoadComboBoxCategorias()
        {
            BindingSource source = new BindingSource();
            cboCategoria.DisplayMember = "Descripcion";
            cboCategoria.ValueMember = "Id";
            var data = _rpsCatalogue.GetByName("categorias");
            source.DataSource = data;
            cboCategoria.DataSource = source.DataSource;
        }

        private void LoadCatalogs()
        {
            LoadComboBoxTallas();
            LoadComboBoxCategorias();
            txtNombre.Focus();
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
                caja.Text = string.Format(Utils.GetCulture(), "{0:C2}", ul);
                caja.TextChanged += nombreMetodo;
                caja.Select(caja.Text.Length, 0);
            }
            bool goodToGo = TextisValid(caja.Text);

            if (!goodToGo)
            {
                caja.Text = "$0.00";
                caja.Select(caja.Text.Length, 0);
            }
        }

        private bool TextisValid(string text)
        {
            Regex money = new Regex(@"^\$(\d{1,3}(\,\d{3})*|(\d+))(\.\d{2})?$");
            return money.IsMatch(text);
        }

        private void txtCosto_TextChanged(object sender, EventArgs e)
        {
            ValidadorFormatoMoneda(txtCosto, txtCosto_TextChanged);
        }

        private void txtPrecioVenta_TextChanged(object sender, EventArgs e)
        {
            ValidadorFormatoMoneda(txtPrecioVenta, txtCosto_TextChanged);
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

        private void EnableSearch()
        {
            btnBuscar.Enabled = true;
            btnBuscar.BackColor = Color.FromArgb(253, 184, 39);
        }

        private void DisabledSearch()
        {
            btnBuscar.Enabled = false;
            btnBuscar.BackColor = SystemColors.Control;
        }

        private void rbnModificar_CheckedChanged(object sender, EventArgs e)
        {
            Clear();
            EnabledTextboxs(false);
            btnBuscarProveedor.Enabled = false;
            EnableSearch();
            EnableRemove();
            EnabledCombos(false);
        }

        private void EnabledCombos(bool valor)
        {
            cboCategoria.Enabled = valor;
            cmbTalla.Enabled = valor;
        }

        private void frmProductos_Activated(object sender, EventArgs e)
        {
            txtNombre.Focus();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (_product == null)
            {
                MessageBox.Show("Busque y seleccione un producto para continuar.", CString.DEFAULT_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            bool resp = _rpsProduct.Remove(_product.id_producto, DataOperator.Instance.Username);
            if (resp)
            {
                MessageBox.Show("Producto eliminado con éxito.", CString.DEFAULT_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear();
            }
            else MessageBox.Show("No se pudo eliminar el producto.", CString.DEFAULT_TITLE, MessageBoxButtons.OK);
        }

        private void btnBuscarProveedor_Click(object sender, EventArgs e)
        {
            try
            {
                frmBuscarProveedor frmBuscarProveedor = new frmBuscarProveedor(this);
                frmBuscarProveedor.ShowDialog();
            }
            catch (Exception ex)
            {
                Utils.GrabarLog("btnBuscarProveedor_Click", ex.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //_barcodeService.Generate(txtCodBarras.Text.Trim());
            _pdfService.Generate("asdasd");
        }
    }
}
