using HendrixAccountant.ApplicationCore.Constants;
using HendrixAccountant.ApplicationCore.Interfaces.Forms;
using HendrixAccountant.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HendrixAccountant
{
    public partial class frmCantidadPrecio : Form
    {
        private readonly IQuantityPrice _caller;
        public frmCantidadPrecio(IQuantityPrice caller)
        {
            InitializeComponent();
            pnHeader.BackColor = DataOperator.Instance.ColorPrimary;
            btnOk.BackColor = DataOperator.Instance.ColorPrimary;
            btnOk.ForeColor = DataOperator.Instance.ColorSecondary;
            _caller = caller;
        }

        private void frmCantidad_Load(object sender, EventArgs e)
        {
            txtCantidad.Focus();
        }

        private void txtCantidad_KeyUp(object sender, KeyEventArgs e)
        {
           
        }

        private void SendQuantity()
        {
            if (txtCantidad.Text.Trim().Length <= 0 || txtCantidad.Text.Trim().Equals("0"))
            {
                MessageBox.Show("La cantidad debe ser mayor a cero", CString.DEFAULT_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            int quantity = Convert.ToInt32(txtCantidad.Text.Trim());
            decimal price = !String.IsNullOrEmpty(txtPrecio.Text.Trim()) ? Convert.ToDecimal(txtPrecio.Text.Trim().Substring(1).Replace(",", ""), Utils.GetCulture()) : 0;
            _caller.GetQuantity(quantity, price);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            SendQuantity();
        }

        private void txtCantidad_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendQuantity();
        }

        private void frmCantidad_Activated(object sender, EventArgs e)
        {
            txtCantidad.Focus();
        }



        private void txtPrecio_TextChanged(object sender, EventArgs e)
        {
            ValidadorFormatoMoneda(txtPrecio, txtPrecio_TextChanged);
        }

        private void ValidadorFormatoMoneda(TextBox caja, EventHandler nombreMetodo)
        {
            string value = caja.Text.Replace(",", "").Replace("$", "").Replace(".", "").TrimStart('0');
            decimal ul;
            //Check we are indeed handling a number
            if (decimal.TryParse(value, out ul))
            {
                ul /= 100;
                //Unsub the event so we don't enter a loop
                caja.TextChanged -= nombreMetodo;
                //Format the text as currency
                caja.Text = string.Format(Utils.GetCulture(), "{0:C2}", ul);
                caja.TextChanged += nombreMetodo;
                caja.Select(caja.Text.Length, 0);
            }
            bool goodToGo = TextisValid(caja.Text);

            if (!goodToGo)
            {
                caja.Text = "$0.00";
                caja.Select(caja.Text.Length, 0);
            }
        }

        private bool TextisValid(string text)
        {
            Regex money = new Regex(@"^\$(\d{1,3}(\,\d{3})*|(\d+))(\.\d{2})?$");
            return money.IsMatch(text);
        }


    }
}
