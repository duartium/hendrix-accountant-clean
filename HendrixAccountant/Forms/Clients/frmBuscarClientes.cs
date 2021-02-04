using HendrixAccountant.ApplicationCore.Constants;
using HendrixAccountant.ApplicationCore.DTOs;
using HendrixAccountant.ApplicationCore.Enums;
using HendrixAccountant.ApplicationCore.Interfaces.Forms;
using HendrixAccountant.ApplicationCore.Interfaces.Repositories;
using HendrixAccountant.Common;
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


namespace HendrixAccountant
{
    public partial class frmBuscarClientes : Form
    {
        private readonly IClientRepository _rpsClient;
        private IFindElement _caller;
        private TipoBusqueda _tipoBusqueda;
        private ClientFilterDto _filters;
        public frmBuscarClientes()
        {
            InitializeComponent();
            this.txtNombres.Focus();
            _rpsClient = new ClienteRepository();
        }

        public frmBuscarClientes(IFindElement caller)
        {
            InitializeComponent();
            this.txtNombres.Focus();
            _caller = caller;
            _rpsClient = new ClienteRepository();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void ClearFields()
        {
            this.txtNombres.Text = "";
            this.txtApellidos.Text = "";
            dgvClientes.Rows.Clear();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            ClearFields();
        }
       

        private void frmClientes_Load(object sender, EventArgs e)
        {
            _tipoBusqueda = TipoBusqueda.NOMBRES;
        }

        #region Private methods

        private void Search()
        {
            if (txtNombres.Text.Length > 0 && txtNombres.Text.Length < 4)
            {
                MessageBox.Show("Ingrese al menos 3 letras para buscar al cliente por nombres.", CString.DEFAULT_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (txtApellidos.Text.Length > 0 && txtApellidos.Text.Length < 4)
            {
                MessageBox.Show("Ingrese al menos 3 letras para buscar al cliente por apellidos.", CString.DEFAULT_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (txtIdentificacion.Text.Length > 0 && txtIdentificacion.Text.Length < 10)
            {
                MessageBox.Show("La identificación debe contener al menos 10 dígitos.", CString.DEFAULT_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                _filters = new ClientFilterDto
                {
                    Identificacion = txtIdentificacion.Text.Trim(),
                    Nombres = txtNombres.Text,
                    Apellidos = txtApellidos.Text
                };
                
                var clients = new List<ClientDto>();
                dgvClientes.Rows.Clear();
                if (_tipoBusqueda == TipoBusqueda.IDENTIFICACION){
                    var client = _rpsClient.GetByIdentification(txtIdentificacion.Text);
                    if(client == null)
                    {
                        MessageBox.Show("No se encontró un cliente con identificación "+txtIdentificacion.Text+".", CString.DEFAULT_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    //debo mapear con un solo método en clientMapper
                    clients.Add(new ClientDto { 
                        IdCliente = client.id_cliente,
                        Nombres = client.nombres,
                        Apellidos = client.apellidos,
                        TipoCliente = client.tipo_cliente,
                        Identificacion = client.identificacion,
                        Celular = client.celular,
                        Direccion = client.direccion,
                        Email = client.email,
                        Telefono = client.telefono,
                        TipoIdentificacion = client.tipo_identificacion
                    });
                }
                else
                {
                    clients = _rpsClient.GetAll(_filters);
                    if (clients == null)
                    {
                        MessageBox.Show("No se encontraron clientes.", CString.DEFAULT_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                }
                FillGrid(clients);
            }
            catch (Exception ex)
            {
                Utils.GrabarLog("Search", ex.ToString());
                MessageBox.Show("No se pudo obtener los clientes.", CString.DEFAULT_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FillGrid(IEnumerable<ClientDto> data)
        {
            dgvClientes.DataSource = null;
            
            dgvClientes.AutoGenerateColumns = false;
            int i = 0;
            foreach (var item in data)
            {
                dgvClientes.Rows.Add(item.Identificacion, item.NombresCompletos, item.Direccion, item.Email, item.Celular, item.Telefono, item.IdCliente);
                dgvClientes.Rows[i].Tag = item;
                i++;
            }
                
        }

        private ClientIdentity MapRowToClientIdentity(DataGridViewRow row) {
            ClientIdentity client = null;
            try
            {
                client = new ClientIdentity
                {
                    Identificacion = row.Cells[colIdentificacion.Index].Value.ToString(),
                    NombresCompletos = row.Cells[colNombres.Index].Value.ToString(),
                    IdCliente = Convert.ToInt32(row.Cells[colCodigo.Index].Value.ToString()),
                    Direccion = row.Cells[colDireccion.Index].Value.ToString()
                };
            }
            catch (Exception ex)
            {
                Utils.GrabarLog("MapRowToClient", ex.ToString());
            }
            return client;
        }

        #endregion

        #region "Events"
        private void rbnIdentificacion_CheckedChanged(object sender, EventArgs e)
        {
            _tipoBusqueda = TipoBusqueda.IDENTIFICACION;
            pnIdentificacion.Visible = true;
            txtNombres.Clear();
            txtApellidos.Clear();
            txtIdentificacion.Focus();
        }

        private void rbnNombres_CheckedChanged(object sender, EventArgs e)
        {
            _tipoBusqueda = TipoBusqueda.NOMBRES;
            pnIdentificacion.Visible = false;
            txtIdentificacion.Clear();
            txtNombres.Focus();
        }
        
        private void dgvClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (_caller.GetType() == typeof(frmClientes))
                _caller.Selected((dgvClientes.Rows[e.RowIndex].Tag as ClientDto));
            else
                _caller.Selected(MapRowToClientIdentity(dgvClientes.Rows[e.RowIndex]));
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        #endregion

        private void frmBuscarClientes_Activated(object sender, EventArgs e)
        {
            this.txtNombres.Focus();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {

        }

        private void txtIdentificacion_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Search();
        }

        private void txtNombres_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Search();
        }

        private void txtApellidos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                Search();
        }
    }
}
