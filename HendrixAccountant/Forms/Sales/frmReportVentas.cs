using HendrixAccountant.Common;
using HendrixAccountant.Reports;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Telerik.Reporting;

namespace HendrixAccountant.Forms
{
    public partial class frmReportVentas : Form
    {
        public frmReportVentas()
        {
            InitializeComponent();
        }

        public frmReportVentas(DataSet data)
        {
            InitializeComponent();
            LoadReport(data);
        }

        private void rptViewerFactura_Load(object sender, EventArgs e)
        {
            
        }

        private void LoadReport(DataSet data)
        {
            try
            {
                ReportDataSource dataSource = new ReportDataSource("dsFactura", data.Tables[0]);
                ReportDataSource dataSource2 = new ReportDataSource("dsFacturaDetalle", data.Tables[1]);
                this.rptViewerVentas.ProcessingMode = ProcessingMode.Local;
                
                this.rptViewerVentas.LocalReport.DataSources.Clear();
                //this.rptViewerVentas.LocalReport.ReportEmbeddedResource = "rptFacturaVenta.rdlc";
                this.rptViewerVentas.LocalReport.DataSources.Add(dataSource);
                this.rptViewerVentas.LocalReport.DataSources.Add(dataSource2);
                this.rptViewerVentas.RefreshReport();
            }
            catch (Exception ex)
            {
                Utils.GrabarLog("LoadReport", ex.ToString());
            }
        }

        private void frmReportVentas_Load(object sender, EventArgs e)
        {
            
        }
    }
}
