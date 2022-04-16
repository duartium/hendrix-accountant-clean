using System;
using System.Windows.Forms;

namespace HendrixAccountant.Forms.Sales
{
    public partial class frmTicketVenta : Form
    {
        public frmTicketVenta(Telerik.Reporting.ReportSource reportSource)
        {
            InitializeComponent();
            this.rptViewerTicket.ReportSource = reportSource;
            this.rptViewerTicket.RefreshReport();
        }

        private void frmTicketVenta_Load(object sender, EventArgs e)
        {
            
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            try
            {
                this.rptViewerTicket.PrintReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Notificación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
