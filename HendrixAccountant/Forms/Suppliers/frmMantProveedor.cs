using HendrixAccountant.ApplicationCore.Constants;
using HendrixAccountant.ApplicationCore.DTOs;
using HendrixAccountant.ApplicationCore.Entities;
using HendrixAccountant.ApplicationCore.Enums;
using HendrixAccountant.ApplicationCore.Interfaces.Forms;
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
using Color = System.Drawing.Color;

namespace HendrixAccountant.Forms.Directorio
{
    public partial class frmMantProveedor : Form, IFindElement
    {
        private readonly SupplierRepository _rpsSupplier;
        private SupplierDto _supplier;
        public frmMantProveedor()
        {
            InitializeComponent();
            _rpsSupplier = new SupplierRepository();
            //ResetearComponentes();
            //HabilitarControlesEntrada(false);
            //HabilitarBotonera(true, false, false);
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
            this.btnGuardar.Enabled = botonGuardar;
            this.btnEliminar.Enabled = botonEliminar;

            if (botonGuardar) btnGuardar.BackColor = Color.FromArgb(27, 46, 140); else btnGuardar.BackColor = SystemColors.Control;
            if (botonEliminar) btnEliminar.BackColor = Color.FromArgb(220, 53, 69); else btnEliminar.BackColor = SystemColors.Control;
        }

        private void HabilitarControlesEntrada(bool valor)
        {
            txtNombre.Enabled = valor;
            txtDireccion.Enabled = valor;
            txtCorreoElectronico.Enabled = valor;
            txtRUC.Enabled = valor;
        }

        private void ResetearComponentes()
        {
            txtNombre.Text = "";
            txtRUC.Text = "";
            txtDireccion.Text = "";
            txtCorreoElectronico.Text = "";
        }

        #endregion

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                frmBuscarProveedor frmBuscarProveedor = new frmBuscarProveedor(this);
                frmBuscarProveedor.ShowDialog();
            }
            catch (Exception ex)
            {
                Utils.GrabarLog("Search", ex.ToString());
                MessageBox.Show("Error no controlado en el proceso.", "Proveedores", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
           
        }

        private void frmMantProveedor_Load(object sender, EventArgs e)
        {
            btnBuscar.Visible = false;
            DisabledRemove();
        }

        private void rbnNuevo_CheckedChanged(object sender, EventArgs e)
        {
            btnBuscar.Visible = false;
            _supplier = null;
            Clear();
            EnabledTextboxs(true);
            DisabledRemove();
            txtRUC.Focus();
        }

        private void rbnModificar_CheckedChanged(object sender, EventArgs e)
        {
            btnBuscar.Visible = true;
            Clear();
            EnableRemove();
            EnabledTextboxs(false);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void Clear()
        {
            txtRUC.Clear();
            txtNombre.Clear();
            txtDireccion.Clear();
            txtCorreoElectronico.Clear();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtRUC.Text.Length == 0 ||
                txtNombre.Text.Trim().Length == 0 ||
                txtDireccion.Text.Trim().Length == 0)
                {
                    MessageBox.Show("Ruc, nombre y dirección son campos obligatorios.", CString.DEFAULT_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtRUC.Focus();
                    return;
                }

                if (txtRUC.Text.Trim().Length < 13)
                {
                    MessageBox.Show("El RUC o cédula debe contener mínimo 10 dígitos.", CString.DEFAULT_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtRUC.Focus();
                    return;
                }

                string mensaje = "Proveedor registrado con éxito.";
                bool isUpdate = false;
                var dataOp = DataOperator.Instance;
                var supplier = new SupplierDto
                {
                    IdProveedor = _supplier == null ? -1 : _supplier.IdProveedor,
                    Ruc = txtRUC.Text,
                    Nombre = txtNombre.Text,
                    Direccion = txtDireccion.Text,
                    Email = txtCorreoElectronico.Text,
                    Usuario = dataOp.Username
                };

                if (rbnModificar.Checked) { isUpdate = true; mensaje = mensaje.Replace("registrado", "modificado"); }

                bool resp = _rpsSupplier.Save(supplier, isUpdate);
                if (resp)
                {
                    MessageBox.Show(mensaje, CString.DEFAULT_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Clear();
                } else MessageBox.Show("No se pudo registrar el proveedor.", CString.DEFAULT_TITLE, MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                Utils.GrabarLog("btnGuardar_Click", ex.ToString());
            }
        }

        private void EnabledTextboxs(bool valor)
        {
            pnRuc.Enabled = valor;
            pnNombre.Enabled = valor;
            pnDireccion.Enabled = valor;
            pnEmail.Enabled = valor;
        }

        public void Selected(ISaleElement entity)
        {
            if (entity == null) return;
            switch (entity.GetType().Name)
            {
                case "SupplierDto":
                    _supplier = entity as SupplierDto;
                    SetSupplier();
                    break;
                default:
                    break;
            }
        }

        private void SetSupplier()
        {
            if (_supplier == null) return;
            txtRUC.Text = _supplier.Ruc;
            txtNombre.Text = _supplier.Nombre;
            txtDireccion.Text = _supplier.Direccion;
            txtCorreoElectronico.Text = _supplier.Direccion;
            EnabledTextboxs(true);
            txtRUC.Focus();
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            if (_supplier == null)
            {
                MessageBox.Show("Busque y seleccione un proveedor para continuar.", CString.DEFAULT_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnBuscar.Focus();
                return;
            }

            bool resp = _rpsSupplier.Remove(_supplier.IdProveedor, DataOperator.Instance.Username);
            if (resp)
            {
                MessageBox.Show("Proveedor eliminado con éxito.", CString.DEFAULT_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear();
            }
            else MessageBox.Show("No se pudo eliminar el proveedor.", CString.DEFAULT_TITLE, MessageBoxButtons.OK);
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

    }
}
