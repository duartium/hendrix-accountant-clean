using HendrixAccountant.ApplicationCore.Entities;
using HendrixAccountant.ApplicationCore.Enums;
using HendrixAccountant.ApplicationCore.Interfaces.Repositories;
using HendrixAccountant.ApplicationCore.Interfaces.Services;
using HendrixAccountant.Common;
using HendrixAccountant.Common.Cast;
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
    public partial class frmMantProveedor : Form
    {

        private IUnitOfWork _unitOfWork;
        private ISupplierService _supplierService;
        private readonly SupplierRepository _supplierRepository;
        private Supplier _supplier;
        private int _flagEstadoCrud = 0;
        public frmMantProveedor()
        {
            InitializeComponent();
            this._unitOfWork = new UnitOfWork(new AppDbContext());
            ResetearComponentes();
            HabilitarControlesEntrada(false);
            HabilitarBotonera(true, false, false);
            this.dgvListado.ReadOnly = true;
            this.dgvListado.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvListado.MultiSelect = false;
        }

        #region Métodos privados

        private bool ValidarCamposEntradaObligatorios()
        {
            if (txtNombre.Text.Trim().Equals(""))
            {
                MessageBox.Show("La característica está vacía. Ingrese un Nombre", "Proveedores", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtNombre.Focus();
                return false;
            }

            if (txtRUC.Text.Trim().Equals(""))
            {
                MessageBox.Show("La característica está vacía. Ingrese un RUC", "Proveedores", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtRUC.Focus();
                return false;
            }

            if (txtCorreoElectronico.Text.Trim().Equals(""))
            {
                MessageBox.Show("La característica está vacía. Ingrese un Correo Electrónico", "Proveedores", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtRUC.Focus();
                return false;
            }
            return true;
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
            txtAlias.Enabled = valor;
            txtDireccion.Enabled = valor;
            txtProvincia.Enabled = valor;
            txtCiudad.Enabled = valor;
            txtCorreoElectronico.Enabled = valor;
            txtRUC.Enabled = valor;

        }

        private void ResetearComponentes()
        {
            btnNuevo.Text = "Nuevo";
            txtNombre.Text = "";
            txtProvincia.Text = "";
            txtAlias.Text = "";
            txtRUC.Text = "";
            txtDireccion.Text = "";
            txtCiudad.Text = "";
            txtCorreoElectronico.Text = "";
        }

        private void BotonNuevo()
        {
            if (this.btnNuevo.Text == "Nuevo")
            {
                this._supplier = new Supplier();
                this._flagEstadoCrud = (int)EstadoOperacionCrud.Nuevo;
                ResetearComponentes();
                HabilitarControlesEntrada(true);
                HabilitarBotonera(true, true, false);
                this.btnNuevo.Text = "Cancelar";
            }
            else
            {
                this._supplier = null;
                this._flagEstadoCrud = (int)EstadoOperacionCrud.Edicion;
                ResetearComponentes();
                HabilitarControlesEntrada(false);
                HabilitarBotonera(true, false, false);
                this.btnNuevo.Text = "Nuevo";
            }

        }



        private void ObtenerModeloDesdeControlesEntrada()
        {
            _supplier.nombre = txtNombre.Text.Trim();
            _supplier.alias = txtAlias.Text.Trim();
            _supplier.ruc = txtRUC.Text.Trim();
            _supplier.direccion = txtDireccion.Text.Trim();
            _supplier.provincia = txtProvincia.Text.Trim();
            _supplier.ciudad = txtCiudad.Text.Trim();
            _supplier.email = txtCorreoElectronico.Text.Trim();

            // auditoria
            _supplier.estado = true;
            _supplier.creado_en = DateTime.Now;
            _supplier.usuario_crea = "developer";
        }
        private void EstablecerModeloHaciaControlesEntrada()
        {
            txtNombre.Text = _supplier.nombre;
            txtAlias.Text = _supplier.alias;
            txtRUC.Text = _supplier.ruc;
            txtDireccion.Text = _supplier.direccion;
            txtProvincia.Text = _supplier.provincia;
            txtCiudad.Text = _supplier.ciudad;
            txtCorreoElectronico.Text = _supplier.email;
        }

        private void ConfigurarColumnas()
        {
            int cantidadColumnas = dgvListado.Columns.Count;
            for (int i = 0; i < cantidadColumnas; i++)
            {
                dgvListado.Columns[i].Visible = false;
            }

            // solo mostrar las siguientes columnas
            dgvListado.Columns["nombre"].Visible = true;
            dgvListado.Columns["ruc"].Visible = true;
            dgvListado.Columns["direccion"].Visible = true;
            dgvListado.Columns["ciudad"].Visible = true;
            dgvListado.Columns["provincia"].Visible = true;
        }

        #endregion

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                List<Supplier> data = new List<Supplier>();
                int opcionComboBuscarPor = cboBuscarPor.SelectedIndex;
                switch (opcionComboBuscarPor)
                {
                    case (int)EnumCriterioBusquedaMantProveedor.Nombre:
                        data = this._unitOfWork.Suppliers.Find(x => x.nombre.Contains(txtValorBuscarPor.Text.Trim()) && x.estado == true).ToList();
                        break;
                    case (int)EnumCriterioBusquedaMantProveedor.RUC:
                        data = this._unitOfWork.Suppliers.Find(x => x.ruc.Contains(txtValorBuscarPor.Text.Trim()) && x.estado == true).ToList();
                        break;
                    case (int)EnumCriterioBusquedaMantProveedor.Ciudad:
                        data = this._unitOfWork.Suppliers.Find(x => x.ciudad.Contains(txtValorBuscarPor.Text.Trim()) && x.estado == true).ToList();
                        break;
                    case (int)EnumCriterioBusquedaMantProveedor.Provincia:
                        data = this._unitOfWork.Suppliers.Find(x => x.provincia.Contains(txtValorBuscarPor.Text.Trim()) && x.estado == true).ToList();
                        break;
                    default:
                        if (txtValorBuscarPor.Text.Trim().Equals("*"))
                        {
                            data = this._unitOfWork.Suppliers.Find(x => x.estado == true).ToList();
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
                dgvListado.AutoGenerateColumns = true;
                dgvListado.DataSource = data;
                ConfigurarColumnas();
                dgvListado.Refresh();
            }
            catch (Exception ex)
            {
                Utils.GrabarLog("Search", ex.ToString());
                MessageBox.Show("Error no controlado en el proceso.", "Proveedores", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            BotonNuevo();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {

                if (this._flagEstadoCrud == (int)EstadoOperacionCrud.Nuevo)
                {
                    if (!ValidarCamposEntradaObligatorios())
                        return;
                    ObtenerModeloDesdeControlesEntrada();
                    this._supplier.estado = true;
                    this._supplier.creado_en = DateTime.Now;
                    this._supplier.usuario_crea = "developer";
                    this._unitOfWork.Suppliers.Add(this._supplier);
                }
                else if (this._flagEstadoCrud == (int)EstadoOperacionCrud.Edicion)
                {
                    ObtenerModeloDesdeControlesEntrada();
                    this._supplier.modificado_en = DateTime.Now;
                    this._supplier.usuario_mod = "developer";
                    this._unitOfWork.Suppliers.Update(this._supplier);
                }
                var cantidadRegistroAfectados = this._unitOfWork.SaveChanges();
                if (cantidadRegistroAfectados > 0)
                {
                    ResetearComponentes();
                    HabilitarControlesEntrada(false);
                    HabilitarBotonera(true, false, false);
                    MessageBox.Show("Los cambios fueron realizados con éxito.", "Proveedores", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("No se detecto ningún cambio.", "Proveedores", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                Utils.GrabarLog("btnGuardar_Click", ex.ToString());
                MessageBox.Show("Error no controlado en el proceso.", "Proveedores", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                this._supplier.estado = false;
                this._supplier.eliminado_en = DateTime.Now;
                this._supplier.usuario_elim = "developer";
                this._unitOfWork.Suppliers.Update(this._supplier);
                var cantidadRegistroAfectados = this._unitOfWork.SaveChanges();
                if (cantidadRegistroAfectados > 0)
                {
                    ResetearComponentes();
                    HabilitarControlesEntrada(false);
                    HabilitarBotonera(true, false, false);
                    MessageBox.Show("Los cambios fueron realizados con éxito.", "Proveedores", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("No se detecto ningún cambio.", "Proveedores", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                Utils.GrabarLog("btnEliminar_Click", ex.ToString());
                MessageBox.Show("Error no controlado en el proceso.", "Proveedores", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnLimiparBusqueda_Click(object sender, EventArgs e)
        {
            txtValorBuscarPor.Text = "";
            cboBuscarPor.SelectedIndex = -1;
        }



        private void dgvListado_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {


                var objeto = (Supplier)dgvListado.CurrentRow.DataBoundItem;
                if (objeto != null)
                {
                    this._flagEstadoCrud = (int)EstadoOperacionCrud.Edicion;
                    this._supplier = new Supplier();
                    this._supplier = objeto;
                    EstablecerModeloHaciaControlesEntrada();
                    HabilitarControlesEntrada(true);
                    HabilitarBotonera(true, true, true);
                    this.btnNuevo.Text = "Cancelar";
                }
            }
            catch (Exception ex)
            {
                Utils.GrabarLog("Search", ex.ToString());
                MessageBox.Show("Error no controlado en el proceso.", "Proveedores", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
