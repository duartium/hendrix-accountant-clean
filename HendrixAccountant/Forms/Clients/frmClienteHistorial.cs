using HendrixAccountant.ApplicationCore.Constants;
using HendrixAccountant.ApplicationCore.DTOs;
using HendrixAccountant.ApplicationCore.Interfaces.Repositories;
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

namespace HendrixAccountant.Forms.Clients
{
    public partial class frmClienteHistorial : Form
    {
        private readonly IClientRepository _rpsClient;
        public frmClienteHistorial()
        {
            InitializeComponent();
            _rpsClient = new ClienteRepository();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                Search();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, CString.DEFAULT_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void frmClienteHistorial_Load(object sender, EventArgs e)
        {
            dgvHistorialCliente.AutoGenerateColumns = false;
            cboTipoFechas.SelectedIndex = 3;
            
        }

        private void Search()
        {
            string fechaDesde = String.Empty, fechaHasta = String.Empty;


            switch (cboTipoFechas.SelectedIndex)
            {
                case 0://Último mes
                    fechaDesde = DateTime.Now.AddMonths(-1).ToString("dd/MM/yyyy");
                    fechaHasta = DateTime.Now.ToString("dd/MM/yyyy");

                    break;
                case 1://Últimos 3 meses
                    fechaDesde = DateTime.Now.AddMonths(-3).ToString("dd/MM/yyyy");
                    fechaHasta = DateTime.Now.ToString("dd/MM/yyyy");
                    break;
                case 2://Últimos 6 meses
                    fechaDesde = DateTime.Now.AddMonths(-3).ToString("dd/MM/yyyy");
                    fechaHasta = DateTime.Now.ToString("dd/MM/yyyy");
                    break;
                case 3://Último año
                    fechaDesde = DateTime.Now.AddYears(-1).ToString("dd/MM/yyyy");
                    fechaHasta = DateTime.Now.ToString("dd/MM/yyyy");
                    break;
            }

            if (txtIdentCliente.Text.Trim().Length == 0 && txtNombresCliente.Text.Trim().Length == 0)
            {
                MessageBox.Show("Ingrese número de identificación o nombre del cliente para realizar la búsqueda.", CString.DEFAULT_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (txtIdentCliente.Text.Trim().Length > 0 && txtIdentCliente.Text.Trim().Length < 10)
            {
                MessageBox.Show("La identificación debe de tener mínimo 10 dígitos", CString.DEFAULT_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var filters = new CustomerHistoryFilters
            {
                Identificacion = txtIdentCliente.Text,
                Nombres = txtNombresCliente.Text,
                FechaDesde = fechaDesde,
                FechaHasta = fechaHasta
            };
            var data = _rpsClient.GetHistory(filters);
            if (data.Rows.Count == 0)
            {
                MessageBox.Show("No se encontraron resultados", CString.DEFAULT_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            dgvHistorialCliente.DataSource = data;
        }

        private void txtIdentCliente_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    Search();
                    e.Handled = e.SuppressKeyPress = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, CString.DEFAULT_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txtNombresCliente_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    Search();
                    e.Handled = e.SuppressKeyPress = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, CString.DEFAULT_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void cboTipoFechas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtNombresCliente_TextChanged(object sender, EventArgs e)
        {
            if (txtIdentCliente.Text.Trim().Length > 0)
                txtIdentCliente.Clear();
        }

        private void txtIdentCliente_TextChanged(object sender, EventArgs e)
        {
            if (txtNombresCliente.Text.Trim().Length > 0)
                txtNombresCliente.Clear();
        }
    }
}
