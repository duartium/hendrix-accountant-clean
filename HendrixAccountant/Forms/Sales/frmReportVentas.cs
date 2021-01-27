using HendrixAccountant.ApplicationCore.Models;
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

        public frmReportVentas(ReportData data)
        {
            InitializeComponent();
            LoadReport(data);
        }

        private void rptViewerFactura_Load(object sender, EventArgs e)
        {
            
        }

        private void LoadReport(ReportData data)
        {
            try
            {
                string pathRoot = Utils.GetValueSetting("reports");
                var dataSource = new List<ReportDataSource>();
                this.rptViewerVentas.ProcessingMode = ProcessingMode.Local;
                switch (data.TipoReporte)
                {
                    case ApplicationCore.Enums.TipoReporte.VENTAS_GENERALES:
                        rptViewerVentas.LocalReport.ReportPath = pathRoot + "rptVentasGenerales.rdlc";
                        dataSource.Add(new ReportDataSource("dsCompania", data.Data.Tables[0]));
                        dataSource.Add(new ReportDataSource("dsVentasGenerales", data.Data.Tables[1]));
                        break;
                    case ApplicationCore.Enums.TipoReporte.FACTURA_VENTA:
                        rptViewerVentas.LocalReport.ReportPath = pathRoot+"rptFacturaVenta.rdlc";
                        dataSource.Add(new ReportDataSource("dsCompania", data.Data.Tables[0]));
                        dataSource.Add(new ReportDataSource("dsFactura", data.Data.Tables[1]));
                        dataSource.Add(new ReportDataSource("dsFacturaDetalle", data.Data.Tables[2]));
                        break;
                    default:
                        break;
                }
                
                this.rptViewerVentas.LocalReport.DataSources.Clear();
                foreach (var source in dataSource)
                    this.rptViewerVentas.LocalReport.DataSources.Add(source);
                this.rptViewerVentas.SetDisplayMode(DisplayMode.PrintLayout);
                this.rptViewerVentas.ZoomMode = ZoomMode.Percent;
                this.rptViewerVentas.ZoomPercent = 100;
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
