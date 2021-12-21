using HendrixAccountant.ApplicationCore.Constants;
using HendrixAccountant.ApplicationCore.Interfaces.Repositories;
using HendrixAccountant.Common;
using HendrixAccountant.Data;
using System;
using System.Data;
using System.Windows.Forms;

namespace HendrixAccountant.Forms.Clients
{
    public partial class frmCumpleaneros : Form
    {
        private String[] months = { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", 
            "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"};
        private readonly IClientRepository _rpsClient;

        public frmCumpleaneros()
        {
            InitializeComponent();
            _rpsClient = new ClienteRepository();
        }

        private void frmCumpleaneros_Load(object sender, EventArgs e)
        {
            cboMeses.DataSource = months;
            cboMeses.SelectedIndex = DateTime.Today.Month - 1;
            Search(cboMeses.SelectedIndex + 1);
        }

        private void cboMeses_SelectedIndexChanged(object sender, EventArgs e)
        {
            int monthSearch = cboMeses.SelectedIndex + 1;
            Search(monthSearch);
        }

        private void Search(int monthSearch)
        {
            try
            {
                var response = _rpsClient.GetBirthdayCustomers(monthSearch);
                dgvCumpleaneros.DataSource = null;
                dgvCumpleaneros.Rows.Clear();
                dgvCumpleaneros.Refresh();
                dgvCumpleaneros.AutoGenerateColumns = false;
                if (response == null || response.Rows.Count == 0) return;

                dgvCumpleaneros.Columns[1].DefaultCellStyle.Format = "dd/MM/yyyy";
                dgvCumpleaneros.DataSource = response;
            }
            catch (Exception ex)
            {
                Utils.GrabarLog("Search => frmCumpleañeros", ex.ToString());
                MessageBox.Show("No se pudo obtener los datos.", CString.DEFAULT_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
