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

namespace HendrixAccountant.Forms.CashRegister
{
    public partial class frmCierreCaja : Form
    {
        private CajaRepository _rpsCash = null;

        public frmCierreCaja()
        {
            InitializeComponent();
            _rpsCash = new CajaRepository();
        }

        private void btnCerrarCaja_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Está seguro de cerrar caja con valor de $" + lblMontoTotal.Text + "?",
                                "Confirmación", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            var op = DataOperator.Instance;
            bool resp = _rpsCash.RegisterMovement(new Data.Dtos.CashFlowDto
            {
                tipoMovimiento = (int)TipoMovimiento.CIERRE,
                usuario = op.Username,
                saldo = Decimal.Parse(lblMontoTotal.Text, Utils.GetCulture())
            });

            if (resp)
            {
                MessageBox.Show("Cierre de caja exitoso.", "Notificación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
                MessageBox.Show("No se pudo realizar la apertura de caja.", "Notificación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void frmCierreCaja_Load(object sender, EventArgs e)
        {
            var cashRegister = _rpsCash.GetCashToday();
            lblFechaApertura.Text = cashRegister.FechaApertura;
            lblFechaCierre.Text = DateTime.Now.ToString("dd-MM-yyyy HH:mm");
            lblMontoApertura.Text = cashRegister.BaseApertura;
            lblTotalIngresos.Text = cashRegister.TotalIngresos;
            lblTotalGastos.Text = cashRegister.TotalGastos;
            lblSaldo.Text = cashRegister.Saldo;

            foreach (var denom in CString.DENOMINACIONES)
                dgvDineroCaja.Rows.Add(new object[] { denom, "0", "0" });

            dgvDineroCaja.CurrentCell = dgvDineroCaja.Rows[0].Cells[1];
        }


        private void tb_TextChangedInt(object sender, EventArgs e)
        {
            TextBox tb = sender as TextBox;
            tb.MaxLength = 9;
            tb.KeyPress -= new KeyPressEventHandler(column_int_keypressInt);
            tb.KeyPress += new KeyPressEventHandler(column_int_keypressInt);

            var row = dgvDineroCaja.CurrentRow;
            
            string cantidad = (sender as TextBox).Text;
            
            if (cantidad != "")
            {
                string denominacion = (dgvDineroCaja.Rows[row.Index].Cells[0].Value.ToString()).Split('$').GetValue(1).ToString();
                if (cantidad == null || denominacion == null) return;

                decimal subtotalRow = int.Parse(cantidad) * Decimal.Parse(denominacion, Utils.GetCulture());
                //decimal montoActual = Decimal.Parse(lblMontoTotal.Text, Utils.GetCulture());
                //decimal montoTotal = montoActual + subtotalRow;

                //lblMontoTotal.Text = montoTotal.ToString(Utils.GetCulture());
                dgvDineroCaja.Rows[row.Index].Cells[2].Value = subtotalRow.ToString();

                //calcular total
                decimal montoTotal = 0;

                for (int i = 0; i < dgvDineroCaja.Rows.Count; i++)
                {
                    var valorColumna = Convert.ToDecimal(dgvDineroCaja.Rows[i].Cells[colSubtotal.Index].Value.ToString(), Utils.GetCulture());
                    montoTotal += valorColumna;
                }
                lblMontoTotal.Text = Math.Round(montoTotal, 2).ToString(Utils.GetCulture());
            }
        }

        private void column_int_keypressInt(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                return;
            }
        }


        private void dgvDineroCaja_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            try
            {
                TextBox tb = e.Control as TextBox;
                tb.MaxLength = 9;
                if (dgvDineroCaja.CurrentCell.ColumnIndex == 1)//cantidad
                {
                    if (tb != null)
                    {
                        tb.TextChanged -= new EventHandler(tb_TextChangedInt);
                        tb.TextChanged += new EventHandler(tb_TextChangedInt);
                    }
                }
            }
            catch (ArgumentException)
            {
            }
            catch (Exception ex)
            {
                Utils.GrabarLog("dgvPuntoVenta_EditingControlShowing", ex.ToString());
            }
        }

    }
}
