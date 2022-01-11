using HendrixAccountant.ApplicationCore.Constants;
using HendrixAccountant.ApplicationCore.DTOs;
using HendrixAccountant.ApplicationCore.Interfaces.Forms;
using HendrixAccountant.Common;
using HendrixAccountant.Data;
using HendrixAccountant.Data.Dtos;
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
    public partial class frmUsuarios : Form, IFindElement
    {
        private IUserRepository _rpsUser;
        private UserDto _user;
        public frmUsuarios()
        {
            InitializeComponent();
            pnHeader.BackColor = DataOperator.Instance.ColorPrimary;
            _rpsUser = new UserRepository();
            _user = null;
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

        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            DisabledSearch();
            DisabledRemove();
            LoadComboBoxRoles();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!rbnModificar.Checked)
            {
                if (txtUsuario.Text.Trim().Length <= 0 ||
                                txtClave.Text.Trim().Length <= 0 ||
                                txtClave2.Text.Trim().Length <= 0)
                {
                    MessageBox.Show("Ingrese nombre de usuario y contraseña.", CString.DEFAULT_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtUsuario.Focus();
                    return;
                }
            }

            if(txtClave.Text.Trim() != txtClave2.Text.Trim() && !rbnModificar.Checked)
            {
                MessageBox.Show("Las contraseñas no coinciden.", CString.DEFAULT_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtClave.Focus();
                return;
            }

            //if(rbnModificar.Checked && _user != null)
            //{
            //    if(_user.Clave != txtClave.Text) {
            //        MessageBox.Show("La contraseña ingresada no coinciden.", CString.DEFAULT_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //        txtClave.Focus();
            //        return;
            //    }
            //}

            string mensaje = "Usuario registrado con éxito.";
            bool isUpdate = false;
            var dataOp = DataOperator.Instance;
            var user = new UserSaveDto
            {
                IdUsuario = _user == null? -1 :_user.IdUsuario, 
                NombreUsuario = txtUsuario.Text,
                Clave = Encrypt.GetSHA256(txtClave.Text),
                IdRol = Convert.ToInt32((cboTipoUsuario.SelectedItem as Rol).IdRol),
                Usuario = dataOp.Username
            };
            if (rbnModificar.Checked) { isUpdate = true; mensaje = mensaje.Replace("registrado", "modificado"); }

            if (_rpsUser.Save(user, isUpdate))
            {
                MessageBox.Show(mensaje, CString.DEFAULT_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear();
                txtUsuario.Focus();
            }
            else
            {
                MessageBox.Show("No se pudo registrar/modificar el usuario.", CString.DEFAULT_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void Clear()
        {
            txtUsuario.Clear();
            txtClave.Clear();
            txtClave2.Clear();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Clear();
            txtUsuario.Focus();
        }

        private void frmUsuarios_Activated(object sender, EventArgs e)
        {
            txtUsuario.Focus();
        }

        private void rbnNuevo_CheckedChanged(object sender, EventArgs e)
        {
            Clear();
            DisabledRemove();
            DisabledSearch();
            EnabledTextboxs(true);
            txtUsuario.Focus();
            cboTipoUsuario.Enabled = true;
            pnClaves.Visible = true;
            _user = null;
        }

        private void rbnModificar_CheckedChanged(object sender, EventArgs e)
        {
            Clear();
            EnableSearch();
            EnableRemove();
            EnabledTextboxs(false);
            cboTipoUsuario.Enabled = false;
            pnClaves.Visible = false;
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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            
        }

        public void Selected(ISaleElement entity)
        {
            if (entity == null) return;
            switch (entity.GetType().Name)
            {
                case "UserDto":
                    _user = entity as UserDto;
                    SetUser();
                    break;
                default:
                    break;
            }
        }

        private void SetUser()
        {
            if (_user == null) return;
            txtUsuario.Text = _user.Usuario;
            cboTipoUsuario.SelectedValue = _user.IdRol;
            EnabledTextboxs(true);
            txtUsuario.Focus();
        }

        private void EnabledTextboxs(bool valor)
        {
            txtUsuario.Enabled = valor;
            txtClave.Enabled = valor;
            txtClave2.Enabled = valor;
        }

        private void LoadComboBoxRoles()
        {
            BindingSource source = new BindingSource();
            cboTipoUsuario.DisplayMember = "Nombre";
            cboTipoUsuario.ValueMember = "IdRol";
            List<Rol> data = _rpsUser.GetRol();
            source.DataSource = data;
            cboTipoUsuario.DataSource = source.DataSource;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (_user == null)
            {
                MessageBox.Show("Busque y seleccione un usuario para continuar.", CString.DEFAULT_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            bool resp = _rpsUser.Remove(_user.IdUsuario, DataOperator.Instance.Username);
            if (resp)
            {
                MessageBox.Show("Usuario eliminado con éxito.", CString.DEFAULT_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear();
            }
            else MessageBox.Show("No se pudo eliminar el usuario.", CString.DEFAULT_TITLE, MessageBoxButtons.OK);
        }
    }
}
