using HendrixAccountant.ApplicationCore.Constants;
using HendrixAccountant.ApplicationCore.DTOs;
using HendrixAccountant.ApplicationCore.Entities;
using HendrixAccountant.ApplicationCore.Enums;
using HendrixAccountant.ApplicationCore.Interfaces.Forms;
using HendrixAccountant.ApplicationCore.Interfaces.Repositories;
using HendrixAccountant.ApplicationCore.Interfaces.Services;
using HendrixAccountant.ApplicationCore.Models;
using HendrixAccountant.Common;
using HendrixAccountant.Data.Repositories;
using HendrixAccountant.Data.Services;
using HendrixAccountant.Forms.PdfViewer;
using HendrixAccountant.Infrastructure.Shared.Services;
using HendrixAccountant.Reports.Labels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Color = System.Drawing.Color;
using HendrixAccountant.Forms.Sales;

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
        private EstadoPantalla _eEstadoPantalla;
        private readonly ISupplierRepository _rpsSupplier;
        private bool _isSearch;
        public frmProductos()
        {
            InitializeComponent();
            SetCompanyColors();
            _rpsProduct = new ProductTempRepository();
            _rpsCatalogue = new CatalogueRepository();
            LoadCatalogs();
            _supplier = null;
            _barcodeService = new BarCodeService();
            _pdfService = new PdfService();
            _rpsSupplier = new SupplierRepository();
            _product = null;
            _isSearch = false;
            LoadSupplierDefault();
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
           
        }

        private void SetProduct()
        {
            if (_product == null || _supplier == null) return;
            
            int indexTabPage = tcProductos.SelectedIndex;
            if(indexTabPage == 1)
            {
                txtCodigo2.Text = _product.codigo;
                txtNombre2.Text = _product.nombre;
            }

            txtCodBarras.Text = _product.codigo;
            txtNombre.Text = _product.nombre;
            txtDescripcion.Text = _product.descripcion;
            txtCosto.Text = _product.costo.ToString();
            txtPrecioVenta.Text = _product.precio_venta.ToString();
            //txtStock.Text = _product.stock.ToString();
            //txtCodProveedor.Text = _supplier.IdProveedor.ToString();
            //txtNombreProveedor.Text = _supplier.Nombre;
            cmbTalla.SelectedValue = _product.id_talla;
            cboCategoria.SelectedValue = _product.categoria_id;
            SetBarcodeImage(_product.codigo);
            cmbTarifaIva.SelectedItem = _product.tarifa_iva;

            if (_product.es_servicio)
                rbServicio.Checked = true;
            else
                rbProducto.Checked = true;
        }

        private void SetBarcodeImage(string code)
        {
            if (String.IsNullOrEmpty(code)) return;

            try
            {
                string folderPath = DataOperator.Instance.PathBarcodes;
                if (String.IsNullOrEmpty(folderPath))
                {
                    string path = new ParameterServices().Get(CString.PATH_BARCODES);
                    DataOperator.Instance.PathBarcodes = path;
                    folderPath = path;
                }
                string pathImg = Path.Combine(folderPath, $"PROD_{code}.jpg");

                if(tcProductos.SelectedIndex == 0)
                    pbBarcode.Image = GetCopyImage(pathImg);
                else
                    pbBarcode2.Image = GetCopyImage(pathImg);
            }
            catch (Exception ex)
            {
                pbBarcode.Image = null;
                Utils.GrabarLog("SetBarcodeImage", ex.ToString());
            }
        }

        private void SetSupplier()
        {
            if (_supplier == null) return;
            //txtCodProveedor.Text = _supplier.IdProveedor.ToString();
            //txtNombreProveedor.Text = _supplier.Nombre.ToString();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtCodBarras.Text.Trim().Length == 0 ||
                txtNombre.Text.Length == 0 ||
               txtCosto.Text.Trim().Length == 0 ||
               txtPrecioVenta.Text.Trim().Length == 0)
            {
                MessageBox.Show("Complete los datos del producto para proceder con su registro.", CString.DEFAULT_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if(_supplier == null)
            {
                MessageBox.Show("Seleccione al proveedor. Campo obligatorio", CString.DEFAULT_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            
            _isSearch = false;
            bool isUpdate = false;
            string mensaje = "Producto registrado con éxito.";
            var dataOp = DataOperator.Instance;
            var product = new ProductDto
            {
                IdProducto = _product == null ? -1 : _product.id_producto,
                CodigoBarras = txtCodBarras.Text.Trim().ToUpper(),
                EsServicio = rbServicio.Checked,
                Nombre = txtNombre.Text,
                Descripcion = txtDescripcion.Text,
                Costo = Convert.ToDecimal(txtCosto.Text.Trim().Substring(1).Replace(",", ""), Utils.GetCulture()),
                Precio = Convert.ToDecimal(txtPrecioVenta.Text.Trim().Substring(1).Replace(",", ""), Utils.GetCulture()),
                TarifaIva = cmbTarifaIva.SelectedIndex == 0 ? 0 : 12,
                Stock = 0,
                IdCategoria = Convert.ToInt32(cboCategoria.SelectedValue),
                IdProveedor = _supplier.IdProveedor,
                IdTalla = Convert.ToInt32(cmbTalla.SelectedValue),
                Usuario = dataOp.Username
            };

            if (rbServicio.Checked) 
                mensaje = "Servicio registrado con éxito.";

            if (_eEstadoPantalla == EstadoPantalla.MODIFICACION) { isUpdate = true; mensaje = mensaje.Replace("registrado", "actualizado"); }

            if (!isUpdate && _rpsProduct.IsDuplicateCode(product.CodigoBarras))
            {
                MessageBox.Show($"Ya existe un producto registrado con el código {product.CodigoBarras}.", CString.DEFAULT_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!_rpsProduct.Save(product, isUpdate))
            {
                MessageBox.Show("No se pudo registrar/modificar el producto.", CString.DEFAULT_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            _barcodeService.Generate(txtCodBarras.Text.Trim());
            Clear();
            SetScreen(EstadoPantalla.INICIAL);
            MessageBox.Show(mensaje, CString.DEFAULT_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtCodBarras.Focus();
            return;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Clear();
        }
        private void Clear(bool clearSupplier = false)
        {
            txtNombre.Clear();
            txtCodBarras.Clear();
            txtDescripcion.Clear();
            txtCosto.Clear();
            txtPrecioVenta.Clear();
            //txtStock.Clear();
            pbBarcode.Image = null;
            _product = null;
            dgvProductos.Rows.Clear();
            txtCodProducto.Clear();
            txtNombreProd.Clear();
            if (clearSupplier)
            {
                //txtCodProveedor.Clear();
                //txtNombreProveedor.Clear();
            }
        }

        private void EnabledForm(bool valor)
        {
            pnNombres.Enabled = valor;
            txtCodBarras.Enabled = valor;
            txtNombre.Enabled = valor;
            txtDescripcion.Enabled = valor;
            txtCosto.Enabled = valor;
            txtPrecioVenta.Enabled = valor;
            //txtStock.Enabled = valor;
            gbTipo.Enabled = valor;
            cmbTarifaIva.Enabled = valor;
            //pnProveedor.Enabled = valor;
            EnabledCombos(valor);
        }

        private void SetLabelsBottomColor(EstadoPantalla estadoPantalla)
        {
            Color backColor = Color.FromArgb(30, 107, 247); //azul
            switch (estadoPantalla)
            {
                case EstadoPantalla.INICIAL:
                    Color.FromArgb(30, 107, 247); //azul
                    break;
                case EstadoPantalla.CREACION:
                    backColor = Color.FromArgb(40, 167, 69);//verde
                    break;
                case EstadoPantalla.MODIFICACION:
                    backColor = Color.FromArgb(253, 184, 39);//amarillo
                    break;
            }
            
            lblPnCodigo.BackColor = backColor;
            lblPnNombre.BackColor = backColor;
            lblPnDescripcion.BackColor = backColor;
            lblPnCosto.BackColor = backColor;
            lblPnPrecioVenta.BackColor = backColor;
            //lblPnStock.BackColor = backColor;
            //lblPnCodigoProv.BackColor = backColor;
            //lblPnNombreProv.BackColor = backColor;
        }

        private void frmProductos_Load(object sender, EventArgs e)
        {
            SetScreen(EstadoPantalla.INICIAL);
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

        //private void EnableSearch()
        //{
        //    btnBuscar.Enabled = true;
        //    btnBuscar.BackColor = Color.FromArgb(253, 184, 39);
        //}

        //private void DisabledSearch()
        //{
        //    btnBuscar.Enabled = false;
        //    btnBuscar.BackColor = SystemColors.Control;
        //}

        private void SetScreen(EstadoPantalla estadoPantalla)
        {
            switch (estadoPantalla)
            {
                case EstadoPantalla.INICIAL:
                    btnLimpiar.Visible = false;
                    btnGuardar.Visible = false;
                    btnEliminar.Visible = false;
                    cmbTarifaIva.SelectedIndex = 0;
                    EnabledForm(false);
                    txtCodProducto.Focus();
                    break;
                case EstadoPantalla.CREACION:
                    btnLimpiar.Visible = true;
                    btnGuardar.Visible = true;
                    Clear();
                    EnabledForm(true);
                    txtCodBarras.Focus();
                    break;
                case EstadoPantalla.MODIFICACION:
                    EnabledForm(true);
                    btnEliminar.Visible = false;
                    btnLimpiar.Visible = true;
                    btnGuardar.Visible = true;
                    break;
                case EstadoPantalla.ELIMINACION:
                    break;
            }
            SetLabelsBottomColor(estadoPantalla);
        }

        private void rbnModificar_CheckedChanged(object sender, EventArgs e)
        {
           
        }

        private void EnabledCombos(bool valor)
        {
            cboCategoria.Enabled = valor;
            cmbTalla.Enabled = valor;
        }

        private void frmProductos_Activated(object sender, EventArgs e)
        {
            txtCodProducto.Focus();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (_product == null)
            {
                MessageBox.Show("Busque y seleccione un producto para continuar.", CString.DEFAULT_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            _isSearch = false;
            string code = _product.codigo;
            bool resp = _rpsProduct.Remove(_product.id_producto, DataOperator.Instance.Username);
            if (resp)
            {
                RemoveBarcodeImage(code);
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
           
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            var barcodes = new List<BarcodeCard>();
            if(rbGenerarIndividual.Checked)
            {
                if (_product == null)
                {
                    MessageBox.Show("Busque y seleccione un producto para continuar.", CString.DEFAULT_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                _barcodeService.Generate(_product.codigo);
                barcodes.Add(new BarcodeCard { 
                    Codigo = _product.codigo, 
                    Precio = _product.precio_venta.ToString(),
                    NombreProducto = _product.nombre
                });
            }
            else
            {
                List<BarcodeCard> lsBarcodes = _rpsProduct.GetBarcodes();
                foreach (var cards in lsBarcodes)
                    _barcodeService.Generate(cards.Codigo);
                barcodes = lsBarcodes;
            }

            if (MessageBox.Show("¿Desea imprimir los códigos generados?", CString.DEFAULT_TITLE, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;
            

            string pathPdfCreated = _pdfService.Generate(barcodes);
            string execute = new ParameterServices().Get(CString.PDF_EXECUTE);
            if (execute.Equals("chrome"))
                System.Diagnostics.Process.Start("chrome.exe", pathPdfCreated);
            else
            {
                //frmPdfReader frmPdfReader = new frmPdfReader(pathPdfCreated);
                //frmPdfReader.ShowDialog();
            }
            //frmPdfViewer pdfViewer = new frmPdfViewer(pathPdfCreated);
            //pdfViewer.Show();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            _isSearch = false;
            _eEstadoPantalla = EstadoPantalla.CREACION;
            SetScreen(_eEstadoPantalla);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (_product == null)
            {
                MessageBox.Show("Busque y seleccione un producto para proceder a modificarlo.", CString.DEFAULT_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            _eEstadoPantalla = EstadoPantalla.MODIFICACION;
            SetScreen(_eEstadoPantalla);
        }

        private void SetCompanyColors()
        {
            pnHeader.BackColor = DataOperator.Instance.ColorPrimary;
            dgvProductos.ColumnHeadersDefaultCellStyle.BackColor = DataOperator.Instance.ColorPrimary;
        }

        private void LoadSupplierDefault()
        {
            //consulta proveedor por defecto
            if (_supplier != null) return;
            _supplier = _rpsSupplier.GetDefault();
            SetSupplier();
        }

        private void txtCodProducto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsLetterOrDigit(e.KeyChar) || e.KeyChar == '\b' )
            {
                if (!e.KeyChar.ToString().Contains("Ñ")){
                    e.Handled = false;
                    e.KeyChar = Char.ToUpper(e.KeyChar);
                }
                else { e.Handled = true; }
            }
            else e.Handled = true;
        }

        private void txtCodBarras_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txtNombreProd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Search();
                e.Handled = e.SuppressKeyPress = true;
            }
        }

        private void Search()
        {
            try
            {
                var filters = new ProductFilterDto
                {
                    Codigo = txtCodProducto.Text,
                    NombreProducto = txtNombreProd.Text,
                    EsServicio = -1
                };

                var products = _rpsProduct.GetAll(filters);
                if (products == null)
                {
                    btnEliminar.Visible = false;
                    MessageBox.Show("No se encontraron productos.", CString.DEFAULT_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                
                FillGrid(products);
                if (products.Count > 0)
                {
                    _isSearch = true;
                    _product = products.First();
                    SetProduct();
                }
                SetScreen(EstadoPantalla.INICIAL);
                btnEliminar.Visible = true;
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
                dgvProductos.Rows.Add(item.codigo, item.nombre, item.stock);
                dgvProductos.Rows[i].Tag = item;
                i++;
            }
        }

        private void dgvProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvProductos_SelectionChanged(object sender, EventArgs e)
        {
            int indexRow = dgvProductos.CurrentRow.Index;
            if (indexRow < 0 || !_isSearch) return;

            _product = dgvProductos.Rows[indexRow].Tag as Product;
            SetProduct();
            SetScreen(EstadoPantalla.INICIAL);
            btnEliminar.Visible = true;
        }


        private void RemoveBarcodeImage(string code)
        {
            try
            {
                string folderPath = DataOperator.Instance.PathBarcodes;
                if (String.IsNullOrEmpty(folderPath))
                {
                    string path = new ParameterServices().Get(CString.PATH_BARCODES);
                    DataOperator.Instance.PathBarcodes = path;
                    folderPath = path;
                }
                string pathImg = Path.Combine(folderPath, $"PROD_{code}.jpg");
                pbBarcode.Image = null;
                pbBarcode.Refresh();
                pbBarcode.Dispose();
                File.Delete(pathImg);
            }
            catch (Exception ex)
            {
                Utils.GrabarLog("RemoveBarcodeImage", ex.ToString());
            }
        }

        private Image GetCopyImage(string path)
        {
            using (Image im = Image.FromFile(path))
            {
                Bitmap bm = new Bitmap(im);
                return bm;
            }
        }

        private void txtCodProducto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Search();
                e.Handled = e.SuppressKeyPress = true;
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            var barcodes = new List<BarcodeCard>();
            if (rbGenerarIndividual.Checked)
            {
                if (_product == null)
                {
                    MessageBox.Show("Busque y seleccione un producto para continuar.", CString.DEFAULT_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                barcodes.Add(new BarcodeCard
                {
                    Codigo = _product.codigo,
                    Precio = _product.precio_venta.ToString(),
                    NombreProducto = _product.nombre
                });

            }
            else
            {
                barcodes = _rpsProduct.GetBarcodes();
            }

            if(barcodes.Count <= 0)
            {
                MessageBox.Show("No se encontraron productos para generar su etiqueta.", CString.DEFAULT_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var printParams = new CompanyRepository().GetPrintParams();
            string printer = printParams.Where(x => x.Nombre.Equals("impresora_etiquetas"))
                .Select(x => x.Valor).FirstOrDefault();

            var printerSettings = new System.Drawing.Printing.PrinterSettings();
            printerSettings.PrinterName = printer;

            //Imprimir en etiquetadora
            var rptLabelSingle = new RptLabelSingle();
            rptLabelSingle.DataSource = barcodes.FirstOrDefault();
            
            var reportSource = new Telerik.Reporting.InstanceReportSource();
            reportSource.ReportDocument = rptLabelSingle;
            
            var frmTicketVenta = new frmTicketVenta(reportSource);
            frmTicketVenta.ShowDialog();

            //Imprimir en A4
            //string pathPdfCreated = _pdfService.Generate(barcodes);
            //string execute = new ParameterServices().Get(CString.PDF_EXECUTE);
            //if(execute.Equals("chrome"))
            //    System.Diagnostics.Process.Start("chrome.exe", pathPdfCreated);

        }

        private void txtCodBarras_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtNombre.Focus();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
            //if (Char.IsLetterOrDigit(e.KeyChar) || e.KeyChar == '\b')
            //{
            //    if (!e.KeyChar.ToString().Contains("Ñ"))
            //    {
            //        e.Handled = false;
            //        e.KeyChar = Char.ToUpper(e.KeyChar);
            //    }
            //    else { e.Handled = true; }
            //}
            //else e.Handled = true;
        }

        private void rbServicio_CheckedChanged(object sender, EventArgs e)
        {
            pnlCosto.Visible = false;
            lblCosto.Visible = false;

            lblPrecioVenta.Location = new Point(19, 214);
            pnlPrecioVenta.Location = new Point(22, 229);
            lblTarifaIva.Location = new Point(125, 214);
            cmbTarifaIva.Location = new Point(128, 237);
            //pnProveedor.Visible = false;
            txtNombre.Focus();
        }

        private void rbProducto_CheckedChanged(object sender, EventArgs e)
        {
            pnlCosto.Visible = true;
            lblCosto.Visible = true;

            lblPrecioVenta.Location = new Point(125, 214);
            pnlPrecioVenta.Location = new Point(128, 229);
            lblTarifaIva.Location = new Point(231, 214);
            cmbTarifaIva.Location = new Point(234, 237);

            //pnProveedor.Visible = true;
            txtNombre.Focus();
        }

        private void cboCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cboCategoria_DropDown(object sender, EventArgs e)
        {
            LoadComboBoxCategorias();
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
