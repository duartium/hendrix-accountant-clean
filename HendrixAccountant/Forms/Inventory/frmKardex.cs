using HendrixAccountant.ApplicationCore.Constants;
using HendrixAccountant.ApplicationCore.DTOs;
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

namespace HendrixAccountant.Forms.Inventory
{
    public partial class frmKardex : Form
    {
        //private ProductDto _product;
        private IKardexRepository _rpsKardex;

        public frmKardex()
        {
            InitializeComponent();
            _rpsKardex = new KardexRepository();
            //_product = null;
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void Search()
        {
            if (dtpFechaDesde.Value.Date > dtpFechaHasta.Value.Date)
            {
                MessageBox.Show("La 'fecha desde' no puede ser mayor a 'fecha hasta'.", CString.DEFAULT_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var filters = new KardexFilterDto
            {
                IdProducto = 0,
                FechaDesde = dtpFechaDesde.Value.ToString("yyyy-MM-dd"),
                FechaHasta = dtpFechaHasta.Value.ToString("yyyy-MM-dd"),
                TipoMovimiento = cmbTipoMov.SelectedIndex
            };
            var kardex = _rpsKardex.GetAll(filters);
            if(kardex == null)
            {
                MessageBox.Show("No se obtuvieron resultados de la búsqueda.", CString.DEFAULT_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            dgvKardex.AutoGenerateColumns = false;
            dgvKardex.DataSource = kardex;
        }

        private void frmKardex_Load(object sender, EventArgs e)
        {
            cmbTipoMov.SelectedIndex = 1;
            //var path = $"{Application.StartupPath}\\Resources\\Images\\HendrixIcon.ico";
            //this.Icon = new Icon(path);
        }
    }
}
