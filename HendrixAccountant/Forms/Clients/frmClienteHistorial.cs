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

                var filters = new CustomerHistoryFilters
                {
                    Identificacion = txtIdentCliente.Text,
                    Nombres = txtNombresCliente.Text,
                    FechaDesde = fechaDesde,
                    FechaHasta = fechaHasta
                };
                var data = _rpsClient.GetHistory(filters);
                if(data.Rows.Count > 0)
                {
                    dgvHistorialCliente.DataSource = data;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, CString.DEFAULT_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void frmClienteHistorial_Load(object sender, EventArgs e)
        {
            cboTipoFechas.SelectedIndex = 3;
            
        }
    }
}
