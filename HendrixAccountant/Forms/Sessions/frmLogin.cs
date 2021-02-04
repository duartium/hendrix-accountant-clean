using HendrixAccountant.ApplicationCore.Constants;
using HendrixAccountant.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HendrixAccountant.Sessions
{
    public partial class frmLogin : Form
    {
        private readonly IUserRepository _repUser;
        
        public frmLogin()
        {
            InitializeComponent();
            _repUser = new UserRepository();
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            AuthenticateUser();
        }

        private void lblCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AuthenticateUser()
        {
            if (txtUsername.Text.Trim().Length == 0 || txtPassword.Text.Trim().Length == 0)
                MessageBox.Show("Ingrese usuario y contraseña", CString.DEFAULT_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            var user = _repUser.Authenticate(txtUsername.Text, txtPassword.Text);
            if (user == null)
                MessageBox.Show("Usuario o contraseña incorrectos", CString.DEFAULT_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Information);
            else{
                DataOperator _operator = DataOperator.Instance;
                _operator.IdUser = user.IdUsuario;
                _operator.Username = user.Usuario;
                _operator.UserRole = user.IdRol;
                _operator.Role = user.NombreRol;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void txtPassword_KeyUp(object sender, KeyEventArgs e)
        {
           
                
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                AuthenticateUser();
                e.Handled = e.SuppressKeyPress = true;
            }
                
        }
    }
}
