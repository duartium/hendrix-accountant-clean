using HendrixAccountant.ApplicationCore.Constants;
using HendrixAccountant.ApplicationCore.DTOs;
using HendrixAccountant.ApplicationCore.Interfaces.Forms;
using HendrixAccountant.ApplicationCore.Interfaces.Repositories;
using HendrixAccountant.Data;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace HendrixAccountant
{
    public partial class frmClientes : Form, IFindElement
    {
        private readonly IClientRepository _rpsClient;
        private ClientDto _client;
        public frmClientes()
        {
            InitializeComponent();
            pnHeader.BackColor = DataOperator.Instance.ColorPrimary;
            _rpsClient = new ClienteRepository();
            _client = null;
            dtpFechaNacimiento.Value = new DateTime(1999, 1, 1);
            cboTipoIdentif.SelectedIndex = 1;
            txtIdentificacion.MaxLength = 10;
        }

        private void frmClientes_Load(object sender, EventArgs e)
        {
            btnBuscar.Enabled = false;
            btnEliminar.Enabled = false;
            btnBuscar.BackColor = SystemColors.Control;
            btnEliminar.BackColor = SystemColors.Control;
            txtIdentificacion.Focus();
        }

        private void rbnNuevo_CheckedChanged(object sender, EventArgs e)
        {
            btnBuscar.Enabled = false;
            btnEliminar.Enabled = true;
            btnEliminar.BackColor = SystemColors.Control;
            btnBuscar.BackColor = SystemColors.Control;
            EnabledControls(true);
            txtIdentificacion.Focus();
            _client = null;
        }

        private void rbnModificar_CheckedChanged(object sender, EventArgs e)
        {
            Clear();
            btnEliminar.Enabled = true;
            btnBuscar.Enabled = true;
            btnEliminar.BackColor = Color.FromArgb(220, 53, 69);
            btnBuscar.BackColor = Color.FromArgb(253, 184, 39);
            EnabledControls(false);
            btnBuscar.Focus();
        }

        private void frmClientes_Activated(object sender, EventArgs e)
        {
            txtIdentificacion.Focus();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(txtIdentificacion.Text.Length == 0 ||
                txtNombres.Text.Trim().Length == 0 ||
                txtApellidos.Text.Trim().Length == 0) { 
                MessageBox.Show("La identificación y nombres del cliente son obligatorios.", CString.DEFAULT_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (txtIdentificacion.Text.Trim().Length < 10)
            {
                MessageBox.Show("La identificación debe contener al menos 10 dígitos.", CString.DEFAULT_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (rbnNuevo.Checked)
            {
                if (_rpsClient.IsDuplicateClient(txtIdentificacion.Text.Trim()))
                {
                    MessageBox.Show($"ya existe un cliente registrado con identificación {txtIdentificacion.Text}.", CString.DEFAULT_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
            }
            
            string mensaje = "Cliente registrado con éxito.";
            bool isUpdate = false;
            var dataOp = DataOperator.Instance;
            var client = new ClientDto
            {
                Identificacion = txtIdentificacion.Text,
                Nombres = txtNombres.Text,
                Apellidos = txtApellidos.Text,
                Direccion = txtDireccion.Text,
                Email = txtEmail.Text,
                Celular = txtCelular.Text,
                FechaNacimiento = dtpFechaNacimiento.Value.ToString("yyyy-MM-dd"),
                TipoCliente = 1,
                TipoIdentificacion = cboTipoIdentif.SelectedIndex == 1 ? 1 : 2,
                Usuario = dataOp.Username,
                IdCliente = _client == null ? -1 : _client.IdCliente
            };

            if (rbnModificar.Checked) { isUpdate = true; mensaje = mensaje.Replace("registrado", "modificado"); }
            
            bool resp = _rpsClient.Save(client, isUpdate);
            if (resp){
                MessageBox.Show(mensaje, CString.DEFAULT_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear();
                txtIdentificacion.Focus();
            }else
                MessageBox.Show("No se pudo registrar el cliente.", CString.DEFAULT_TITLE, MessageBoxButtons.OK);
        }

        private void Clear()
        {
            txtIdentificacion.Clear();
            txtNombres.Clear();
            txtApellidos.Clear();
            txtDireccion.Clear();
            txtEmail.Clear();
            dtpFechaNacimiento.Value = new DateTime(1999, 1, 1);
            cboTipoIdentif.SelectedIndex = 1;
            txtCelular.Clear();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            _client = null;
            Clear();
            frmBuscarClientes frmBuscarClientes = new frmBuscarClientes(this);
            frmBuscarClientes.ShowDialog();
        }

        public void Selected(ISaleElement entity)
        {
            if (entity == null) return;
            switch (entity.GetType().Name)
            {
                case "ClientDto":
                    _client = entity as ClientDto;
                    SetClient();
                    break;
                default:
                    break;
            }
        }
        
        private void SetClient()
        {
            if (_client == null) return;
            txtIdentificacion.Text = _client.Identificacion;
            txtNombres.Text = _client.Nombres;
            txtApellidos.Text = _client.Apellidos;
            txtDireccion.Text = _client.Direccion;
            txtEmail.Text = _client.Email;
            dtpFechaNacimiento.Value = Convert.ToDateTime(_client.FechaNacimiento);
            txtCelular.Text = _client.Celular;
            EnabledControls(true);
            txtIdentificacion.Focus();
        }

        private void EnabledControls(bool valor)
        {
            pnIdentificacion.Enabled = valor;
            pnNombres.Enabled = valor;
            pnApellidos.Enabled = valor;
            pnDireccion.Enabled = valor;
            pnEmail.Enabled = valor;
            pnCelular.Enabled = valor;
            dtpFechaNacimiento.Enabled = valor;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (_client == null) {
                MessageBox.Show("Seleccione un cliente para continuar.", CString.DEFAULT_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            } 
            
            bool resp = _rpsClient.Remove(_client.IdCliente, DataOperator.Instance.Username);
            if (resp){
                MessageBox.Show("Cliente eliminado con éxito.", CString.DEFAULT_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear();
            }
            else MessageBox.Show("No se pudo eliminar el cliente.", CString.DEFAULT_TITLE, MessageBoxButtons.OK);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void cboTipoIdentif_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTipoIdentif.SelectedIndex == 0)//RUC
            {
                txtIdentificacion.MaxLength = 13;
            }
            else//CÉDULA
            {
                txtIdentificacion.MaxLength = 10;
            }
            txtIdentificacion.Clear();
            txtIdentificacion.Focus();
        }
    }
}
