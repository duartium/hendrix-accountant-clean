using HendrixAccountant.ApplicationCore.Constants;
using HendrixAccountant.ApplicationCore.DTOs;
using HendrixAccountant.ApplicationCore.Entities;
using HendrixAccountant.ApplicationCore.Interfaces.Forms;
using HendrixAccountant.ApplicationCore.Interfaces.Repositories;
using HendrixAccountant.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace HendrixAccountant.Forms.Inventory
{
    public partial class frmKardex : Form, IFindElement
    {
        private ProductIdentityDto _product;
        private IKardexRepository _rpsKardex;

        public frmKardex()
        {
            InitializeComponent();
            _rpsKardex = new KardexRepository();
            _product = null;
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

            if(_product == null && cmbTipoMov.SelectedIndex != 0)
            {
                MessageBox.Show("Seleccione un producto para continuar.", CString.DEFAULT_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var filters = new KardexFilterDto
            {
                IdProducto = _product == null ? 0 : _product.IdProducto,
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
            FillGrid(kardex);
        }

        private void frmKardex_Load(object sender, EventArgs e)
        {
            cmbTipoMov.SelectedIndex = 0;
            txtCodProducto.Focus();
            //var path = $"{Application.StartupPath}\\Resources\\Images\\HendrixIcon.ico";
            //this.Icon = new Icon(path);
        }

        private void btnBuscarProductos_Click(object sender, EventArgs e)
        {
            frmBuscarProductos frmBuscarProductos = new frmBuscarProductos(this);
            frmBuscarProductos.ShowDialog();
        }

        public void Selected(ISaleElement entity)
        {
            if (entity == null) return;

            switch (entity.GetType().Name)
            {
                case "ProductIdentityDto":
                    _product = entity as ProductIdentityDto;
                    SetProduct();
                    break;
                
            }
        }

        private void SetProduct()
        {
            if (_product == null) return;
            txtCodProducto.Text = _product.Codigo;
            txtNombreProducto.Text = _product.Nombre;
        }

        private void FillGrid(IEnumerable<Kardex> data)
        {
            dgvKardex.DataSource = null;

            dgvKardex.AutoGenerateColumns = false;
            dgvKardex.DataSource = data;
        }

        private void frmKardex_Activated(object sender, EventArgs e)
        {
            txtCodProducto.Focus();
        }
    }
}
