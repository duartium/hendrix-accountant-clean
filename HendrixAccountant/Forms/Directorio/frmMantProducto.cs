using HendrixAccountant.ApplicationCore.DTOs;
using HendrixAccountant.ApplicationCore.Entities;
using HendrixAccountant.ApplicationCore.Enums;
using HendrixAccountant.ApplicationCore.Interfaces.Repositories;
using HendrixAccountant.ApplicationCore.Interfaces.Services;
using HendrixAccountant.ApplicationCore.Services;
using HendrixAccountant.Common;
using HendrixAccountant.Common.Cast;
using HendrixAccountant.Common.WindowsFormControls;
using HendrixAccountant.Data;
using HendrixAccountant.Data.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HendrixAccountant.Forms.Directorio
{
    public partial class frmMantProducto : Form
    {
        private IUnitOfWork _unitOfWork;
        private IProductService _productService;
        private readonly ProductoRepository _productoRepository;
        private Product _product;
        private int _flagEstadoCrud = 0;
        public frmMantProducto()
        {
            InitializeComponent();
            this._unitOfWork = new UnitOfWork(new AppDbContext());
            ResetearComponentes();
            HabilitarControlesEntrada(false);
            HabilitarBotonera(true, false, false);
            ConfigurarComboBoxs();
            this.dgvListadoProductos.ReadOnly = true;
            this.dgvListadoProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvListadoProductos.MultiSelect = false;
        }
        #region Métodos privados

        private bool ValidarCamposEntradaObligatorios()
        {
            if (txtNombre.Text.Trim().Equals(""))
            {
                MessageBox.Show("La característica está vacía. Ingrese un Nombre", "Productos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNombre.Focus();
                return false;
            }

            if (txtCosto.Text.Trim().Equals(""))
            {
                MessageBox.Show("La característica está vacía. Ingrese un Costo", "Productos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCosto.Focus();
                return false;
            }

            if (txtPrecioVenta.Text.Trim().Equals(""))
            {
                MessageBox.Show("La característica está vacía. Ingrese un Precio de Venta", "Productos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtPrecioVenta.Focus();
                return false;
            }

            if (txtStock.Text.Trim().Equals(""))
            {
                MessageBox.Show("La característica está vacía. Ingrese un Stock", "Productos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtStock.Focus();
                return false;
            }

            if ((int)cboColor.SelectedValue <= 0)
            {
                MessageBox.Show("La característica está vacía. Ingrese un Color", "Productos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboColor.Focus();
                return false;
            }

            if ((int)cboColor.SelectedValue <= 0)
            {
                MessageBox.Show("La característica está vacía. Ingrese un Color", "Productos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboColor.Focus();
                return false;
            }

            if ((int)cboCategoria.SelectedValue <= 0)
            {
                MessageBox.Show("La característica está vacía. Ingrese una Categoria", "Productos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboCategoria.Focus();
                return false;
            }

            if (cboProveedor.Text.Trim().Equals(""))
            {
                MessageBox.Show("La característica está vacía. Ingrese un Proveedor", "Productos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboProveedor.Focus();
                return false;
            }

            if ((int)cboMarca.SelectedValue <= 0)
            {
                MessageBox.Show("La característica está vacía. Ingrese una Marca", "Productos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboMarca.Focus();
                return false;
            }
            return true;
        }

        private void ConfigurarComboBoxs()
        {
            EstablecerComboBoxCategoria();
            EstablecerComboBoxColor();
            EstablecerComboBoxProveedor();
            EstablecerComboBoxMarca();
        }

        private void EstablecerComboBoxMarca()
        {
            cboMarca.DisplayMember = "Descripcion";
            cboMarca.ValueMember = "Id";
            var data = this._unitOfWork.Brands.GetComboBoxMarcaDTOs();
            var dataset = ConvertToDataSet.FromList<ComboBoxMarcaDTO>(data, "marcas");
            cboMarca.DataSource = dataset.Tables["marcas"];
        }

        private void EstablecerComboBoxProveedor()
        {
            cboProveedor.DisplayMember = "Descripcion";
            cboProveedor.ValueMember = "Id";
            var data = this._unitOfWork.Suppliers.GetComboBoxProveedorDTOs();
            var dataset = ConvertToDataSet.FromList<ComboBoxProveedorDTO>(data, "proveedores");
            cboProveedor.DataSource = dataset.Tables["proveedores"];
        }

        private void EstablecerComboBoxColor()
        {
            cboColor.DisplayMember = "Descripcion";
            cboColor.ValueMember = "Id";
            var data = this._unitOfWork.Colors.GetComboBoxColorDTOs();
            var dataset = ConvertToDataSet.FromList<ComboBoxColorDTO>(data, "colores");
            cboColor.DataSource = dataset.Tables["colores"];
        }

        private void EstablecerComboBoxCategoria()
        {
            cboCategoria.DisplayMember = "Descripcion";
            cboCategoria.ValueMember = "Id";
            var data = this._unitOfWork.Categories.GetComboBoxCategoriaDTOs();
            var dataset = ConvertToDataSet.FromList<ComboBoxCategoriaDTO>(data, "categorias");
            cboCategoria.DataSource = dataset.Tables["categorias"];
        }

        private void HabilitarBotonera(bool botonNuevo, bool botonGuardar, bool botonEliminar)
        {
            this.btnNuevo.Enabled = botonNuevo;
            this.btnGuardar.Enabled = botonGuardar;
            this.btnEliminar.Enabled = botonEliminar;
        }

        private void HabilitarControlesEntrada(bool valor)
        {
            txtNombre.Enabled = valor;
            txtDescripcion.Enabled = valor;
            txtStock.Enabled = valor;
            txtCosto.Enabled = valor;
            txtPrecioVenta.Enabled = valor;
            cboCategoria.Enabled = valor;
            cboColor.Enabled = valor;
            cboProveedor.Enabled = valor;
            cboMarca.Enabled = valor;
            txtValorDescuento.Enabled = valor;
            txtTalla.Enabled = valor;
        }

        private void ResetearComponentes()
        {
            btnNuevo.Text = "Nuevo";
            txtNombre.Text = "";
            txtDescripcion.Text = "";
            txtStock.Text = "";
            txtCosto.Text = "";
            txtPrecioVenta.Text = "";
            txtValorDescuento.Text = "";
            txtTalla.Text = "";
            cboCategoria.SelectedIndex = 0;
            cboColor.SelectedIndex = 0;
            cboProveedor.SelectedIndex = 0;
            cboMarca.SelectedIndex = 0;
        }

        private void BotonNuevo()
        {
            if (this.btnNuevo.Text == "Nuevo")
            {
                this._product = new Product();
                this._flagEstadoCrud = (int)EstadoOperacionCrud.Nuevo;
                ResetearComponentes();
                HabilitarControlesEntrada(true);
                HabilitarBotonera(true, true, false);
                this.btnNuevo.Text = "Cancelar";
            }
            else
            {
                this._product = null;
                this._flagEstadoCrud = (int)EstadoOperacionCrud.Edicion;
                ResetearComponentes();
                HabilitarControlesEntrada(false);
                HabilitarBotonera(true, false, false);
                this.btnNuevo.Text = "Nuevo";
            }

        }



        private void ObtenerModeloDesdeControlesEntrada()
        {

            var x = txtCosto.Text.Trim().Substring(1).Replace(",","").Replace(".",",");

            DataRowView xdrvMarca = (DataRowView)cboMarca.SelectedItem;
            int idmarca = (int)xdrvMarca.Row.ItemArray[0];

            DataRowView xdrvCategoria = (DataRowView)cboCategoria.SelectedItem;
            int idcategoria = (int)xdrvCategoria.Row.ItemArray[0];

            DataRowView xdrvProveedor = (DataRowView)cboProveedor.SelectedItem;
            long idproveedor = (long)xdrvProveedor.Row.ItemArray[0];

            DataRowView xdrvColor = (DataRowView)cboColor.SelectedItem;
            int idcolor = (int)xdrvColor.Row.ItemArray[0];

            _product.categoria_id = idcategoria;
            _product.color = idcolor;
            _product.costo = Decimal.Parse(txtCosto.Text.Trim().Substring(1).Replace(",", "").Replace(".", ","));
            _product.descripcion = txtDescripcion.Text.Trim();
            _product.descuento = (txtValorDescuento.Text.Trim().Equals("")) ? 0 : Decimal.Parse(txtValorDescuento.Text.Trim().Substring(1).Replace(",", "").Replace(".", ","));
            _product.marca = idmarca;
            _product.nombre = txtNombre.Text.Trim();
            _product.descripcion = txtDescripcion.Text.Trim();
            _product.proveedor_id = (int)idproveedor;
            _product.stock = Int32.Parse(txtStock.Text.Trim());
            _product.talla = (txtTalla.Text.Trim().Equals("")) ? 0 : Int32.Parse(txtTalla.Text.Trim());
            _product.precio_venta = Convert.ToDecimal(txtPrecioVenta.Text.Trim().Substring(1).Replace(",", "").Replace(".", ","), Utils.GetCulture());
        }
        private void EstablecerModeloHaciaControlesEntrada()
        {
            cboCategoria.SelectedValue = (int)_product.categoria_id;
            cboColor.SelectedValue = (int)_product.color;
            txtCosto.Text = "$" + _product.costo.ToString();
            txtDescripcion.Text = _product.descripcion;
            txtValorDescuento.Text = "$" + _product.descuento.ToString();
            cboMarca.SelectedValue = (int)_product.marca;
            txtNombre.Text = _product.nombre;
            txtDescripcion.Text = _product.descripcion;
            cboProveedor.SelectedValue = _product.proveedor_id;
            txtStock.Text = _product.stock.ToString();
            txtTalla.Text = _product.talla.ToString();
            txtPrecioVenta.Text = "$" + _product.precio_venta;

            //// auditoria
            //_product.estado = true;
            //_product.creado_en = DateTime.Now;
            //_product.usuario_crea = "developer";
        }

        private void ConfigurarColumnas()
        {
            int cantidadColumnas = dgvListadoProductos.Columns.Count;
            for (int i = 0; i < cantidadColumnas; i++)
            {
                dgvListadoProductos.Columns[i].Visible = false;
            }

            // solo mostrar las siguientes columnas
            dgvListadoProductos.Columns["nombre"].Visible = true;
            dgvListadoProductos.Columns["descripcion"].Visible = true;
            dgvListadoProductos.Columns["costo"].Visible = true;
            dgvListadoProductos.Columns["precio_venta"].Visible = true;
            dgvListadoProductos.Columns["stock"].Visible = true;


            // cambiar nombre de columna por
            dgvListadoProductos.Columns["nombre"].HeaderText = "Nombre";
            dgvListadoProductos.Columns["descripcion"].HeaderText = "Descripción";
            dgvListadoProductos.Columns["costo"].HeaderText = "Costo";
            dgvListadoProductos.Columns["precio_venta"].HeaderText = "Precio Vta.";
            dgvListadoProductos.Columns["stock"].HeaderText = "Stock";
        }

        private void ValidadorFormatoMoneda(TextBox caja, EventHandler nombreMetodo) {
            string value = caja.Text.Replace(",", "").Replace("$", "").Replace(".", "").TrimStart('0');
            decimal ul;
            //Check we are indeed handling a number
            if (decimal.TryParse(value, out ul))
            {
                ul /= 100;
                //Unsub the event so we don't enter a loop
                caja.TextChanged -= nombreMetodo;
                //Format the text as currency
                caja.Text = string.Format(CultureInfo.CreateSpecificCulture("en-US"), "{0:C2}", ul);
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

        #endregion

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this._flagEstadoCrud == (int)EstadoOperacionCrud.Nuevo)
                {
                    if (!ValidarCamposEntradaObligatorios())
                        return;
                    ObtenerModeloDesdeControlesEntrada();
                    this._unitOfWork.Products.Add(this._product);
                    _product.estado = true;
                    _product.creado_en = DateTime.Now;
                    _product.usuario_crea = "developer";
                }
                else if (this._flagEstadoCrud == (int)EstadoOperacionCrud.Edicion)
                {
                    if (!ValidarCamposEntradaObligatorios())
                        return;
                    ObtenerModeloDesdeControlesEntrada();
                    this._product.modificado_en = DateTime.Now;
                    this._product.usuario_mod = "developer";
                    this._unitOfWork.Products.Update(this._product);
                }
                var cantidadRegistroAfectados = this._unitOfWork.SaveChanges();
                if (cantidadRegistroAfectados > 0)
                {
                    ResetearComponentes();
                    HabilitarControlesEntrada(false);
                    HabilitarBotonera(true, false, false);
                    MessageBox.Show("Los cambios fueron realizados con éxito.", "Productos", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("No se detecto ningún cambio.", "Productos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                Utils.GrabarLog("Search", ex.ToString());
                MessageBox.Show("Error no controlado en el proceso.", "Productos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            BotonNuevo();
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void txtTalla_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                this._productService = new ProductService(this._unitOfWork);
                List<Product> data = new List<Product>();
                int opcionComboBuscarPor = cboBuscarPor.SelectedIndex;
                switch (opcionComboBuscarPor)
                {
                    case (int)EnumCriterioBusquedaMantProducto.Nombre:
                        data = this._unitOfWork.Products.Find(x => x.nombre.Contains(txtValorBuscarPor.Text.Trim()) && x.estado == true).ToList();
                        break;
                    case (int)EnumCriterioBusquedaMantProducto.Descripción:
                        data = this._unitOfWork.Products.Find(x => x.descripcion.Contains(txtValorBuscarPor.Text.Trim()) && x.estado == true).ToList();
                        break;
                    case (int)EnumCriterioBusquedaMantProducto.PrecioDeVenta:
                        data = this._unitOfWork.Products.Find(x => x.precio_venta.Equals(txtValorBuscarPor.Text.Trim()) && x.estado == true).ToList();
                        break;
                    case (int)EnumCriterioBusquedaMantProducto.Costo:
                        data = this._unitOfWork.Products.Find(x => x.costo == Decimal.Parse(txtValorBuscarPor.Text.Trim()) && x.estado == true).ToList();
                        break;
                    default:
                        if (txtValorBuscarPor.Text.Trim().Equals("*"))
                        {
                            data = this._unitOfWork.Products.Find(x => x.estado == true).ToList();
                        }
                        else
                        {
                            return;
                        }
                        break;
                }

                if (data.Count == 0)
                {
                    MessageBox.Show("No se obtuvieron datos.", "Notificación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                dgvListadoProductos.AutoGenerateColumns = true;
                dgvListadoProductos.DataSource = data;
                ConfigurarColumnas();
                dgvListadoProductos.Refresh();
            }
            catch (Exception ex)
            {
                Utils.GrabarLog("Search", ex.ToString());
                MessageBox.Show("Error no controlado en el proceso.", "Productos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvListadoProductos_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {


                var objeto = (Product)dgvListadoProductos.CurrentRow.DataBoundItem;
                if (objeto != null)
                {
                    this._flagEstadoCrud = (int)EstadoOperacionCrud.Edicion;
                    this._product = new Product();
                    this._product = objeto;
                    EstablecerModeloHaciaControlesEntrada();
                    HabilitarControlesEntrada(true);
                    HabilitarBotonera(true, true, true);
                    this.btnNuevo.Text = "Cancelar";
                }
            }
            catch (Exception ex)
            {
                Utils.GrabarLog("Search", ex.ToString());
                MessageBox.Show("Error no controlado en el proceso.", "Productos", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                this._product.estado = false;
                this._product.eliminado_en = DateTime.Now;
                this._product.usuario_elim = "developer";
                this._unitOfWork.Products.Update(this._product);
                var cantidadRegistroAfectados = this._unitOfWork.SaveChanges();
                if (cantidadRegistroAfectados > 0)
                {
                    ResetearComponentes();
                    HabilitarControlesEntrada(false);
                    HabilitarBotonera(true, false, false);
                    MessageBox.Show("Los cambios fueron realizados con éxito.", "Productos", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("No se detecto ningún cambio.", "Productos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                Utils.GrabarLog("Search", ex.ToString());
                MessageBox.Show("Error no controlado en el proceso.", "Productos", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnLimiparBusqueda_Click(object sender, EventArgs e)
        {
            txtValorBuscarPor.Text = "";
            cboBuscarPor.SelectedIndex = -1;
        }

        

        private void txtValorDescuento_TextChanged(object sender, EventArgs e)
        {
            // new ValidatorTextBox(txtValorDescuento).ValidadorFormatoMoneda(sender, e);
            ValidadorFormatoMoneda(txtValorDescuento, txtValorDescuento_TextChanged);
        }

        private void txtCosto_TextChanged(object sender, EventArgs e)
        {
            ValidadorFormatoMoneda(txtCosto, txtCosto_TextChanged);
        }

        private void txtPrecioVenta_TextChanged(object sender, EventArgs e)
        {
            ValidadorFormatoMoneda(txtPrecioVenta, txtPrecioVenta_TextChanged);
        }

        private void txtStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtTalla_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
