using HendrixAccountant.ApplicationCore.Constants;
using HendrixAccountant.ApplicationCore.Interfaces.Forms;
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
    public partial class frmCantidad : Form
    {
        private readonly IQuantity _caller;
        public frmCantidad(IQuantity caller)
        {
            InitializeComponent();
            _caller = caller;
        }

        private void frmCantidad_Load(object sender, EventArgs e)
        {

        }

        private void txtCantidad_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SendQuantity();
        }

        private void SendQuantity()
        {
            if (txtCantidad.Text.Trim().Length <= 0 || txtCantidad.Text.Trim().Equals("0"))
            {
                MessageBox.Show("La cantidad debe ser mayor a cero", CString.DEFAULT_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            int quantity = Convert.ToInt32(txtCantidad.Text.Trim());
            _caller.GetQuantity(quantity);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
