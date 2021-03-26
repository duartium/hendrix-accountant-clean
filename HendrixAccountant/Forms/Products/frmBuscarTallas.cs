using HendrixAccountant.ApplicationCore.Constants;
using HendrixAccountant.ApplicationCore.DTOs;
using HendrixAccountant.ApplicationCore.Interfaces.Forms;
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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HendrixAccountant
{
    public partial class frmBuscarTallas : Form
    {
        private IFindElement _caller;
        private ISizeRepository _rpsSize;
        public frmBuscarTallas(IFindElement caller)
        {
            InitializeComponent();
            SetCompanyColors();
            _caller = caller;
            _rpsSize = new SizeRepository();
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
                var sizes = _rpsSize.GetAll();
                if (sizes == null)
                {
                    MessageBox.Show("No se encontraron tallas.", CString.DEFAULT_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                FillGrid(sizes);
            }
            catch (Exception ex)
            {
                Utils.GrabarLog("btnConsultar_Click", ex.ToString());
            }
        }

        private void FillGrid(List<SizeDto> categories)
        {
            dgvSizes.DataSource = null;
            dgvSizes.Rows.Clear();
            dgvSizes.AutoGenerateColumns = false;
            int i = 0;
            foreach (var item in categories)
            {
                dgvSizes.Rows.Add(item.Codigo, item.Descripcion);
                dgvSizes.Rows[i].Tag = item;
                i++;
            }

        }

        private void dgvCategorias_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            _caller.Selected((dgvSizes.Rows[e.RowIndex].Tag as SizeDto));
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void SetCompanyColors()
        {
            pnAside.BackColor = DataOperator.Instance.ColorPrimary;
            btnConsultar.BackColor = DataOperator.Instance.ColorSecondary;
            btnLimpiar.BackColor = DataOperator.Instance.ColorSecondary;
            dgvSizes.ColumnHeadersDefaultCellStyle.BackColor = DataOperator.Instance.ColorPrimary;
        }
    }
}
