using HendrixAccountant.ApplicationCore.Map;
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
                if (data == null) return;                           
                string pathProd = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86)+ "/NeutrinoTech/HendrixAccountant/Report/";
                string pathRoot = Utils.GetValueSetting("environment").Equals("DEV") ? Utils.GetValueSetting("reports") : pathProd;
                var dataSource = new List<ReportDataSource>();
                this.rptViewerVentas.ProcessingMode = ProcessingMode.Local;
                switch (data.TipoReporte)
                {
                    case ApplicationCore.Enums.TipoReporte.VENTAS_GENERALES:
                        var dtCriterios = new ReportMapper().criteriosToDataTable(data.Criterios);
                        rptViewerVentas.LocalReport.ReportPath = pathRoot + "rptVentasGenerales.rdlc";
                        dataSource.Add(new ReportDataSource("dsCompania", data.Data.Tables["dtCompany"]));
                        dataSource.Add(new ReportDataSource("dsVentasGenerales", data.Data.Tables[0]));
                        dataSource.Add(new ReportDataSource("dsCriterios", dtCriterios));
                        break;
                    case ApplicationCore.Enums.TipoReporte.FACTURA_VENTA:
                        rptViewerVentas.LocalReport.ReportPath = pathRoot+"rptFacturaVenta.rdlc";
                        dataSource.Add(new ReportDataSource("dsCompania", data.Data.Tables["dtCompany"]));
                        dataSource.Add(new ReportDataSource("dsFactura", data.Data.Tables[0]));
                        dataSource.Add(new ReportDataSource("dsFacturaDetalle", data.Data.Tables[1]));
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
