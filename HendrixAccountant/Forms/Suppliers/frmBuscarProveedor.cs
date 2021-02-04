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
    public partial class frmBuscarProveedor : Form
    {
        private readonly ISupplierRepository _rpsSupplier;
        private IFindElement _caller;
        public frmBuscarProveedor()
        {
            InitializeComponent();
            _rpsSupplier = new SupplierRepository();
        }

        public frmBuscarProveedor(IFindElement caller)
        {
            InitializeComponent();
            _caller = caller;
            _rpsSupplier = new SupplierRepository();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtCodProveedor.Clear();
            txtNombreProv.Clear();
            dgvProveedores.Rows.Clear();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void Search()
        {
            try
            {
                var filters = new SupplierFilterDto
                {
                    IdProveedor = String.IsNullOrEmpty(txtCodProveedor.Text) ? -1 : Convert.ToInt32(txtCodProveedor.Text),
                    NombreProveedor = txtNombreProv.Text
                };
                var suppliers = _rpsSupplier.GetAll(filters);
                if (suppliers == null)
                {
                    MessageBox.Show("No se encontraron proveedores.", CString.DEFAULT_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                FillGrid(suppliers);
            }
            catch (Exception ex)
            {
                Utils.GrabarLog("Search", ex.ToString());
                MessageBox.Show("No se pudo obtener los proveedor.", CString.DEFAULT_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FillGrid(List<SupplierDto> supplier)
        {
            dgvProveedores.DataSource = null;
            dgvProveedores.Rows.Clear();
            dgvProveedores.AutoGenerateColumns = false;
            int i = 0;
            foreach (var item in supplier)
            {
                dgvProveedores.Rows.Add(item.IdProveedor, item.Ruc, item.Nombre, item.Direccion, item.Email);
                dgvProveedores.Rows[i].Tag = item;  
                i++;
            }

        }

        private void frmBuscarProveedor_Load(object sender, EventArgs e)
        {

        }

        private void dgvProveedores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            _caller.Selected((dgvProveedores.Rows[e.RowIndex].Tag as SupplierDto));
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void frmBuscarProveedor_Activated(object sender, EventArgs e)
        {
            txtNombreProv.Focus();
        }

        private void txtCodProveedor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Search();
                e.SuppressKeyPress = true;
            }
                
        }

        private void txtNombreProv_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Search();
                e.SuppressKeyPress = true;
            }
        }
    }
}
