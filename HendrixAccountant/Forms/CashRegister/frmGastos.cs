using HendrixAccountant.ApplicationCore.Constants;
using HendrixAccountant.ApplicationCore.DTOs;
using HendrixAccountant.ApplicationCore.Interfaces.Repositories;
using HendrixAccountant.Common;
using HendrixAccountant.Data.Repositories;
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

namespace HendrixAccountant.Forms.CashRegister
{
    public partial class frmGastos : Form
    {
        private readonly ICatalogueRepository _rpsCatalogue;
        private readonly IExpenseRepository _rpsExpense;
        public frmGastos()
        {
            InitializeComponent();
            _rpsCatalogue = new CatalogueRepository();
            _rpsExpense = new ExpenseRepository();
            LoadComboBox();
        }

        private void btnRegistrarGasto_Click(object sender, EventArgs e)
        {
            if (txtValorGasto.Text.Length == 0)
            {
                MessageBox.Show("Por favor ingrese el valor del gasto.", CString.DEFAULT_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtValorGasto.Focus();
                return;
            }

            if (txtObservaciones.Text.Length == 0)
            {
                MessageBox.Show("Por favor ingrese el detalle del gasto.", CString.DEFAULT_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtObservaciones.Focus();
                return;
            }

            decimal valorGasto = Convert.ToDecimal(txtValorGasto.Text.Replace("$", "").Replace(",", "."), Utils.GetCulture());
            if(valorGasto == 0){
                MessageBox.Show("El valor del gasto debe ser mayor a 0.", CString.DEFAULT_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var expense = new ExpenseDto
            {
                Fecha = dtpFechaGasto.Value,
                IdTipoGasto = Convert.ToInt32(cboTipoGasto.SelectedValue),
                Valor = valorGasto,
                Detalle = txtObservaciones.Text,
                Usuario = DataOperator.Instance.Username
            };

            if (_rpsExpense.Create(expense))
            {
                MessageBox.Show("Se ha registrado el gasto", CString.DEFAULT_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtValorGasto.Clear();
                txtObservaciones.Clear();
                cboTipoGasto.SelectedIndex = 0;
                txtValorGasto.Focus();
            }
            else
            {
                MessageBox.Show("No se pudo registrar el gasto", CString.DEFAULT_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void frmGastos_Load(object sender, EventArgs e)
        {
            txtValorGasto.Focus();
        }

        private void LoadComboBox()
        {
            BindingSource source = new BindingSource();
            cboTipoGasto.DisplayMember = "Descripcion";
            cboTipoGasto.ValueMember = "Id";
            var data = _rpsCatalogue.GetByName("tipo_gastos");
            source.DataSource = data;
            cboTipoGasto.DataSource = source.DataSource;
        }

        private void txtValorGasto_TextChanged(object sender, EventArgs e)
        {
            ValidadorFormatoMoneda(txtValorGasto, txtValorGasto_TextChanged);
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

        private void frmGastos_Activated(object sender, EventArgs e)
        {
            txtValorGasto.Focus();
        }
    }
}
