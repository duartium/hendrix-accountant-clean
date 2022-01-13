using HendrixAccountant.ApplicationCore.Constants;
using HendrixAccountant.ApplicationCore.DTOs;
using HendrixAccountant.ApplicationCore.Enums;
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
        private List<UserDto> _users;
        private EstadoPantalla _eEstadoPantalla;

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
            LoadComboBoxRoles();
            LoadUsers();
            _eEstadoPantalla = EstadoPantalla.INICIAL;

        }

        private void LoadUsers()
        {
            try
            {
                _users = _rpsUser.GetAll();
                dgvUsuarios.AutoGenerateColumns = false;
                dgvUsuarios.DataSource = _users;
                
            }
            catch (Exception ex)
            {
                Utils.GrabarLog("LoadUsers", ex.ToString());
                MessageBox.Show("Ingrese nombre de usuario y contraseña.", CString.DEFAULT_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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

            lblPnUsuario.BackColor = backColor;
            lblPnContrasena.BackColor = backColor;
            lblConfirmContrasena.BackColor = backColor;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (_eEstadoPantalla == EstadoPantalla.MODIFICACION)
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

            if(txtClave.Text.Trim() != txtClave2.Text.Trim() && _eEstadoPantalla != EstadoPantalla.MODIFICACION)
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
                IdUsuario = _user == null ? -1 : _user.IdUsuario,
                NombreUsuario = txtUsuario.Text.Trim().Replace(" ", ""),
                Clave = Encrypt.GetSHA256(txtClave.Text),
                IdRol = Convert.ToInt32((cboTipoUsuario.SelectedItem as Rol).IdRol),
                Usuario = dataOp.Username
            };

            if (_eEstadoPantalla == EstadoPantalla.MODIFICACION) { isUpdate = true; mensaje = mensaje.Replace("registrado", "modificado"); }

            if (_rpsUser.Save(user, isUpdate))
            {
                MessageBox.Show(mensaje, CString.DEFAULT_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear();


                pnClaves.Visible = false;
                _eEstadoPantalla = EstadoPantalla.INICIAL;
                SetLabelsBottomColor(_eEstadoPantalla);
                EnabledFields(false);

                LoadUsers();
                EnableRemove();
                txtUsuario.Focus();
            }
            else
            {
                MessageBox.Show("No se pudo registrar/modificar el usuario.", CString.DEFAULT_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void Clear()
        {
            dgvUsuarios.DataSource = null;
            dgvUsuarios.Rows.Clear();
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
            txtUsuario.Focus();
            cboTipoUsuario.Enabled = true;
            pnClaves.Visible = true;
            _user = null;
        }

        private void rbnModificar_CheckedChanged(object sender, EventArgs e)
        {
            Clear();
            EnableRemove();
            cboTipoUsuario.Enabled = false;
            pnClaves.Visible = false;
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
            
            txtUsuario.Focus();
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

            if (MessageBox.Show("¿Está seguro que desea eliminar el usuario seleccionado?", CString.DEFAULT_TITLE, MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.Cancel) return;


            bool resp = _rpsUser.Remove(_user.IdUsuario, DataOperator.Instance.Username);
            if (resp)
            {
                MessageBox.Show("Usuario eliminado con éxito.", CString.DEFAULT_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear();
            }
            else MessageBox.Show("No se pudo eliminar el usuario.", CString.DEFAULT_TITLE, MessageBoxButtons.OK);
        }

        private void dgvUsuarios_SelectionChanged(object sender, EventArgs e)
        {

            int indexRow = dgvUsuarios.CurrentRow.Index;
            if (indexRow < 0) return;

            _user = _users[indexRow];
            SetUser();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            _eEstadoPantalla = EstadoPantalla.CREACION;
            dgvUsuarios.DataSource = null;
            dgvUsuarios.Rows.Clear();
            _user = null;
            Clear();

            SetLabelsBottomColor(_eEstadoPantalla);

            EnabledFields(true);
            DisabledRemove();
            pnClaves.Visible = true;
            txtUsuario.Focus();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (_user == null)
            {
                MessageBox.Show("Busque y seleccione un usuario para proceder a modificarlo.", CString.DEFAULT_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            _eEstadoPantalla = EstadoPantalla.MODIFICACION;
            EnabledFields(true);

            pnClaves.Visible = true;

            DisabledRemove();
            txtUsuario.Focus();
            
        }

        private void EnabledFields(bool valor)
        {
            txtUsuario.Enabled = valor;
            txtClave.Enabled = valor;
            txtClave2.Enabled = valor;
            cboTipoUsuario.Enabled = valor;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            pnClaves.Visible = false;
            _eEstadoPantalla = EstadoPantalla.INICIAL;
            SetLabelsBottomColor(_eEstadoPantalla);
            EnabledFields(false);

            LoadUsers();
            EnableRemove();
        }
    }
}
