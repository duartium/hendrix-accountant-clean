using HendrixAccountant.ApplicationCore.Constants;
using HendrixAccountant.ApplicationCore.Interfaces.Services;
using HendrixAccountant.ApplicationCore.Map;
using HendrixAccountant.ApplicationCore.Services;
using HendrixAccountant.Common;
using HendrixAccountant.Data.Services;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace HendrixAccountant.Forms.Sales
{
    public partial class frmAnulacionComprobante : Form
    {
        private DataSet _dsResp;
        private readonly IReports _rpsReports;
        private readonly ISales _rpsSale;

        public frmAnulacionComprobante()
        {
            InitializeComponent();
            _rpsReports = new SaleReportService();
            _rpsSale = new SaleService();
        }

        private void btnAnular_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMotivoAnulacion.Text.Length == 0)
                {
                    MessageBox.Show("Ingrese el motivo de anulación para continuar.", CString.DEFAULT_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                bool resp = _rpsSale.CancelInvoice(int.Parse(txtNumSecuencial.Text.Trim()), txtMotivoAnulacion.Text);
                if (resp) {
                    MessageBox.Show($"Se anuló el comprobante de venta número {txtNumSecuencial.Text}.", CString.DEFAULT_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNumSecuencial.Clear();
                    txtMotivoAnulacion.Clear();
                    txtNumSecuencial.Focus();
                    dgvComprobanteInd.DataSource = null;
                    dgvComprobanteInd.Rows.Clear();
                }
                else
                {
                    MessageBox.Show("No se pudo anular el comprobante de venta.", CString.DEFAULT_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, CString.DEFAULT_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Utils.GrabarLog("btnAnular", ex.ToString());
            }
        }

        private void frmAnulacionComprobante_Load(object sender, EventArgs e)
        {

        }

        private void txtNumSecuencial_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNumSecuencial_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void txtNumSecuencial_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Search();
                e.SuppressKeyPress = true;
            }
        }

        private void Search()
        {
            try
            {
                if (txtNumSecuencial.Text.Length <= 0)
                {
                    MessageBox.Show("Ingrese el número de factura para su anulación.", CString.DEFAULT_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtNumSecuencial.Focus();
                    return;
                }

                _dsResp = _rpsReports.GetByInvoice(txtNumSecuencial.Text.Trim());
                if (!Validator.DatasetIsValid(_dsResp))
                {
                    MessageBox.Show($"No se encontró la factura de número {txtNumSecuencial.Text}.", CString.DEFAULT_TITLE);
                    return;
                }
                FillGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Se produjo un error al realizar la búsqueda: {ex.Message}", CString.DEFAULT_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Utils.GrabarLog("frmAnulacionComprobante >>Search", ex.ToString());
            }
        }


        private void FillGrid()
        {
            if (_dsResp == null) return;

            dgvComprobanteInd.Rows.Clear();
            if(_dsResp.Tables["Table1"].Rows.Count > 0)
            {
                foreach (var row in _dsResp.Tables["Table1"].AsEnumerable())
                    dgvComprobanteInd.Rows.Add(row.ItemArray[0], row.ItemArray[1], row.ItemArray[2], row.ItemArray[3], row.ItemArray[4]);
            }
        }

        private void frmAnulacionComprobante_Activated(object sender, EventArgs e)
        {
            txtNumSecuencial.Focus();
        }
    }
}
