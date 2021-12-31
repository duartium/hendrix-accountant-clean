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
    }
}
