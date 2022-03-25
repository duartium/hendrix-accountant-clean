using HendrixAccountant.ApplicationCore.Interfaces.Repositories;
using HendrixAccountant.Data.Repositories;
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
    public partial class frmGastos : Form
    {
        private ICatalogueRepository _rpsCatalogue;

        public frmGastos()
        {
            InitializeComponent();
            _rpsCatalogue = new CatalogueRepository();
            LoadComboBox();
        }

        private void btnRegistrarGasto_Click(object sender, EventArgs e)
        {

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
    }
}
