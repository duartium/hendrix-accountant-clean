using HendrixAccountant.ApplicationCore.Constants;
using HendrixAccountant.ApplicationCore.DTOs;
using HendrixAccountant.ApplicationCore.Interfaces.Forms;
using HendrixAccountant.ApplicationCore.Interfaces.Repositories;
using HendrixAccountant.Common;
using HendrixAccountant.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace HendrixAccountant
{
    public partial class frmBuscarCategorias : Form
    {
        private IFindElement _caller;
        private ICategoriesRepository _rpsCategory;
        public frmBuscarCategorias(IFindElement caller)
        {
            InitializeComponent();
            _caller = caller;
            _rpsCategory = new CategoriesRepository();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void frmBuscarCategorias_Load(object sender, EventArgs e)
        {

        }

        private void Search()
        {
            try
            {
                var categories = _rpsCategory.GetAll();
                if (categories == null)
                {
                    MessageBox.Show("No se encontraron categorías.", CString.DEFAULT_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                FillGrid(categories);
            }
            catch (Exception ex)
            {
                Utils.GrabarLog("btnConsultar_Click", ex.ToString());
            }
        }

        private void FillGrid(List<CategoryDto> categories)
        {
            dgvCategorias.DataSource = null;
            dgvCategorias.Rows.Clear();
            dgvCategorias.AutoGenerateColumns = false;
            int i = 0;
            foreach (var item in categories)
            {
                dgvCategorias.Rows.Add(item.Codigo, item.Descripcion);
                dgvCategorias.Rows[i].Tag = item;
                i++;
            }

        }

        private void dgvCategorias_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            _caller.Selected((dgvCategorias.Rows[e.RowIndex].Tag as CategoryDto));
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
