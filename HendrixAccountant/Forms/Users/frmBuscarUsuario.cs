using HendrixAccountant.ApplicationCore.Constants;
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
    public partial class frmBuscarUsuario : Form
    {
        private IFindElement _caller;
        private IUserRepository _rpsUser;
        private List<UserDto> _users;
        public frmBuscarUsuario()
        {
            InitializeComponent();
            _rpsUser = new UserRepository();
            _users = new List<UserDto>();
        }

        public frmBuscarUsuario(IFindElement caller)
        {
            InitializeComponent();
            _caller = caller;
            _rpsUser = new UserRepository();
            _users = new List<UserDto>();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            dgvUsuarios.Rows.Clear();
            txtCodUsuario.Clear();
            txtNombreUsuario.Clear();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            dgvUsuarios.Rows.Clear();
            Search();
        }

        private void frmBuscarUsuario_Load(object sender, EventArgs e)
        {

        }

        private void dgvUsuarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            UserDto user = MapRowToUser(dgvUsuarios.Rows[e.RowIndex]);
            _caller.Selected(user);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void Search()
        {
            try
            {
                _users = _rpsUser.GetAll();
                if (_users == null)
                {
                    MessageBox.Show("No se obtuvieron datos.", CString.DEFAULT_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                FillGrid();
            }
            catch (Exception ex)
            {
                Utils.GrabarLog("Search", ex.ToString());
                MessageBox.Show("No se pudo obtener los productos.", CString.DEFAULT_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FillGrid()
        {
            if (_users == null) return;
            foreach (var user in _users)
                dgvUsuarios.Rows.Add(user.IdUsuario, user.Usuario, user.FechaCreacion);
        }

        private UserDto MapRowToUser(DataGridViewRow row)
        {
            UserDto user = null;
            try
            {
                user = new UserDto
                {
                    IdUsuario = Convert.ToInt32(row.Cells[colCodigo.Index].Value.ToString()),
                    Usuario = row.Cells[colUsuario.Index].Value.ToString(),
                    FechaCreacion = row.Cells[ColFechaCreacion.Index].Value.ToString()
                };
            }
            catch (Exception ex)
            {
                Utils.GrabarLog("MapRowToProduct", ex.ToString());
            }
            return user;
        }
    }
}
