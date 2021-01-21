using HendrixAccountant.ApplicationCore.Constants;
using HendrixAccountant.ApplicationCore.DTOs;
using HendrixAccountant.ApplicationCore.Enums;
using HendrixAccountant.ApplicationCore.Interfaces.Services;
using HendrixAccountant.ApplicationCore.Map;
using HendrixAccountant.ApplicationCore.Models;
using HendrixAccountant.Data.Services;
using HendrixAccountant.Reports;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HendrixAccountant.Forms
{
    public partial class frmVentas : Form
    {
        private readonly IReports _rpsReports;
        private DataSet _dsResp;
        private  ConsultaVenta consultaVenta;
        public frmVentas()
        {
            InitializeComponent();
            _rpsReports = new SaleReportService();
            _dsResp = null;
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (tabControlVentas.SelectedTab.Name.Equals("tpGeneral"))
            {
                consultaVenta = ConsultaVenta.GENERAL;
                if (txtIdentCliente.Text.Length <= 0 && txtNombreUsuario.Text.Length <= 0)
                {
                    MessageBox.Show("Ingrese el número de comprobante para realizar la búsqueda.", CString.DEFAULT_TITLE);
                    return;
                }

                if (dtpFechaDesde.Value.Date > dtpFechaHasta.Value.Date)
                {
                    MessageBox.Show("La 'fecha desde' no puede ser mayor a 'fecha hasta'.", CString.DEFAULT_TITLE);
                    return;
                }

                if (txtIdentCliente.Text.Length > 0 && txtIdentCliente.Text.Length < 10)
                {
                    MessageBox.Show("Identificación de cliente no válida.", CString.DEFAULT_TITLE);
                    return;
                }

                var salesFilters = new SalesFilterDto
                {
                    FechaDesde = dtpFechaDesde.Value.Date.ToShortDateString(),
                    FechaHasta = dtpFechaHasta.Value.Date.ToShortTimeString(),
                    IdentificacionClte = txtIdentCliente.Text.Trim(),
                    IdUsuario = Convert.ToInt32((txtCodUsuario.Text.Trim().Length > 0) ? txtCodUsuario.Text.Trim() : "-1")
                };

                if (_dsResp != null) _dsResp.Clear();

                _dsResp = _rpsReports.Get(salesFilters);

                if (!Validator.DatasetIsValid(_dsResp))
                {
                    MessageBox.Show("No se obtuvieron resultados de la búsqueda.", CString.DEFAULT_TITLE);
                    return;
                }
                btnImprimir.Enabled = true;
                FillGrid();

            }else if(tabControlVentas.SelectedTab.Name.Equals("tpCIndividual")) {
                consultaVenta = ConsultaVenta.COMP_INDIVIDUAL;
                if (txtNumSecuencial.Text.Length <= 0)
                {
                    MessageBox.Show("Complete al menos un campo para realizar la búsqueda.", CString.DEFAULT_TITLE);
                    return;
                }
                
                _dsResp = _rpsReports.GetByInvoice(txtNumSecuencial.Text.Trim());
                if (!Validator.DatasetIsValid(_dsResp))
                {
                    MessageBox.Show("No se obtuvieron resultados de la búsqueda.", CString.DEFAULT_TITLE);
                    return;
                }
                btnImprimir.Enabled = true;
                FillGrid();
            }
        }

        private void rptVentas_Load(object sender, EventArgs e)
        {

        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            frmReportVentas frmReportVentas = new frmReportVentas(_dsResp);
            frmReportVentas.ShowDialog();
        }

        private void FillGrid()
        {
            if (_dsResp == null) return;

            if(consultaVenta == ConsultaVenta.COMP_INDIVIDUAL)
                foreach (var row in _dsResp.Tables[1].AsEnumerable())
                    dgvComprobanteInd.Rows.Add(row.ItemArray[0], row.ItemArray[1], row.ItemArray[2], row.ItemArray[3], row.ItemArray[4]);
            //dgvPuntoVenta.FirstDisplayedScrollingRowIndex = dgvPuntoVenta.RowCount - 1;
        }

        private void frmVentas_Activated(object sender, EventArgs e)
        {
            txtIdentCliente.Focus();
        }
    }
}
