using HendrixAccountant.ApplicationCore.Constants;
using HendrixAccountant.ApplicationCore.Enums;
using HendrixAccountant.Common;
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

namespace HendrixAccountant
{
    public partial class frmAperturaCaja : Form
    {
        private readonly CajaRepository _rpsCaja = null;
        private readonly string _username;
        public frmAperturaCaja()
        {
            InitializeComponent();
            _rpsCaja = new CajaRepository();
            var op = DataOperator.Instance;
            _username = op.Username;
        }

        private void btnAperturar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de aperturar caja con valor de $" + lblMontoTotal.Text+"?",
                                "Confirmación", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            bool resp = _rpsCaja.RegisterMovement(new Data.Dtos.CashFlowDto
            {
                tipoMovimiento = (int)TipoMovimiento.APERTURA,
                usuario = _username,
                saldo = Decimal.Parse(lblMontoTotal.Text)
            });

            if (resp)
            {
                MessageBox.Show("Caja habilitada.", "Notificación", MessageBoxButtons.OK);
                this.Close();
            }
            else
                MessageBox.Show("No se pudo realizar la apertura de caja.", "Notificación", MessageBoxButtons.OK);
        }

        private void frmAperturaCaja_Load(object sender, EventArgs e)
        {
            lblFechaApertura.Text += " " + DateTime.Now.ToString("dd/MM/yyyy");
            foreach (var denom in CString.DENOMINACIONES)
                dgvDineroCaja.Rows.Add(new object[] { denom, "0", "0" });

            dgvDineroCaja.CurrentCell = dgvDineroCaja.Rows[0].Cells[1];
        }

        private void dgvDineroCaja_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
                CalcularSubtotalCaja(e);
        }

        #region métodos privados
        private void CalcularSubtotalCaja(DataGridViewCellEventArgs e)
        {
            try
            {
                string cantidad = dgvDineroCaja.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                string denominacion =  (dgvDineroCaja.Rows[e.RowIndex].Cells[0].Value.ToString()).Split('$').GetValue(1).ToString();
                if (cantidad == null || denominacion == null) return;

                decimal subtotalRow = int.Parse(cantidad) * Decimal.Parse(denominacion, Utils.GetCulture());
                decimal montoActual = Decimal.Parse(lblMontoTotal.Text, Utils.GetCulture());
                decimal montoTotal = montoActual + subtotalRow;
                dgvDineroCaja.Rows[e.RowIndex].Cells[e.ColumnIndex + 1].Value = subtotalRow.ToString();
                lblMontoTotal.Text = montoTotal.ToString(Utils.GetCulture());
            }
            catch (Exception ex)
            {
                Utils.GrabarLog("CalcularSubtotalCaja", ex.ToString());
            }
        }
        #endregion
    }
}
