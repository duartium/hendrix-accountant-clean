using HendrixAccountant.ApplicationCore.Constants;
using HendrixAccountant.ApplicationCore.DTOs;
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
        private IFindElement _callerPOS;
        public frmBuscarClientes()
        {
            InitializeComponent();
            this.txtNombres.Focus();
            _rpsClient = new ClienteRepository();
        }

        public frmBuscarClientes(IFindElement caller)
        {
            InitializeComponent();
            _callerPOS = caller;
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
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            ClearFields();
        }
       

        private void frmClientes_Load(object sender, EventArgs e)
        {
            
        }

        #region Private methods

        private void Search()
        {
            try
            {
                var clients = _rpsClient.GetAll();
                if (clients == null)
                {
                    MessageBox.Show("No se obtuvieron datos.", CString.DEFAULT_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
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
            dgvClientes.Rows.Clear();
            dgvClientes.AutoGenerateColumns = false;
            foreach (var item in data)
                dgvClientes.Rows.Add(item.Identificacion, item.NombresCompletos, item.Direccion, item.Email, item.Celular, item.Telefono, item.IdCliente);
            //var bindingList = new BindingList<ClientDto>(data.Cast<ClientDto>().ToList());
            //var source = new BindingSource(bindingList, null);
            //dgvClientes.DataSource = source;
        }

        private ClientIdentity MapRowToClient(DataGridViewRow row) {
            ClientIdentity client = null;
            try
            {
                client = new ClientIdentity
                {
                    Identificacion = row.Cells[colIdentificacion.Index].Value.ToString(),
                    NombresCompletos = row.Cells[colNombres.Index].Value.ToString(),
                    IdCliente = Convert.ToInt32(row.Cells[colCodigo.Index].Value.ToString()),
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
            pnIdentificacion.Visible = true;
            txtIdentificacion.Focus();
        }

        private void rbnNombres_CheckedChanged(object sender, EventArgs e)
        {
            pnIdentificacion.Visible = false;
            txtNombres.Focus();
        }
        
        private void dgvClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            ClientIdentity client = MapRowToClient(dgvClientes.Rows[e.RowIndex]);
            _callerPOS.Selected(client);
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
    }
}
