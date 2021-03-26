using HendrixAccountant.ApplicationCore.Constants;
using HendrixAccountant.ApplicationCore.DTOs;
using HendrixAccountant.ApplicationCore.Interfaces.Forms;
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

namespace HendrixAccountant
{
    public partial class frmCategorias : Form, IFindElement
    {
        private ICategoriesRepository _rpsCategory;
        private CategoryDto _category;
        public frmCategorias()
        {
            InitializeComponent();
            pnHeader.BackColor = DataOperator.Instance.ColorPrimary;
            _category = null;
            _rpsCategory = new CategoriesRepository();
        }

        private void frmCategorias_Load(object sender, EventArgs e)
        {
            DisabledSearch();
            EnabledRemove(false);
        }

        private void frmCategorias_Activated(object sender, EventArgs e)
        {
            txtCodigo.Focus();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Clear();
            _category = null;
            frmBuscarCategorias frmBuscarCategorias = new frmBuscarCategorias(this);
            frmBuscarCategorias.ShowDialog();
        }

        private void rbnNuevo_CheckedChanged(object sender, EventArgs e)
        {
            EnabledRemove(false);
            DisabledSearch();
            EnabledTextboxs(true);
            txtCodigo.Focus();
            _category = null;
        }

        private void EnabledTextboxs(bool valor)
        {
            txtCodigo.Enabled = valor;
            txtNombre.Enabled = valor;
        }

        private void Clear()
        {
            txtCodigo.Clear();
            txtNombre.Clear();
        }

        private void rbnModificar_CheckedChanged(object sender, EventArgs e)
        {
            Clear();
            EnabledRemove(true);
            EnabledSearch();
            EnabledTextboxs(false);
            btnBuscar.Focus();
        }

        public void Selected(ISaleElement entity)
        {
            if (entity == null) return;
            switch (entity.GetType().Name)
            {
                case "CategoryDto":
                    _category = entity as CategoryDto;
                    SetCategory();
                    break;
                default:
                    break;
            }
        }

        private void SetCategory()
        {
            if (_category == null) return;
            txtCodigo.Text = _category.Codigo;
            txtNombre.Text = _category.Descripcion;
            EnabledTextboxs(true);
            txtCodigo.Focus();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Clear();
            if (rbnModificar.Checked) EnabledTextboxs(false);
        }

        private void DisabledSearch()
        {
            btnBuscar.Enabled = false;
            btnBuscar.BackColor = SystemColors.Control;
        }

        private void EnabledSearch()
        {
            btnBuscar.Enabled = true;
            btnBuscar.BackColor = Color.FromArgb(253, 184, 39);
        }

        private void EnabledRemove(bool valor)
        {
            btnEliminar.Enabled = valor;
            btnEliminar.BackColor = valor ? Color.FromArgb(220, 53, 69) : SystemColors.Control;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text.Length == 0 || txtNombre.Text.Trim().Length == 0 )
            {
                MessageBox.Show("El código y nombre de la categoría son obligatorios.", CString.DEFAULT_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (txtCodigo.Text.Trim().Length < 4)
            {
                MessageBox.Show("El código debe contener al menos 3 letras.", CString.DEFAULT_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCodigo.Focus();
                return;
            }

            string mensaje = "Categoría registrada con éxito.";
            bool isUpdate = false;
            var dataOp = DataOperator.Instance;
            var category = new CategoryDto
            {
                IdCategoria = _category == null ? -1 : _category.IdCategoria,
                Codigo = txtCodigo.Text,
                Descripcion = txtNombre.Text,
                Usuario = dataOp.Username
            };

            if (rbnModificar.Checked) { isUpdate = true; mensaje = mensaje.Replace("registrada", "modificada"); }

            bool resp = _rpsCategory.Save(category, isUpdate);
            if (resp)
            {
                MessageBox.Show(mensaje, CString.DEFAULT_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear();
                txtCodigo.Focus();
            }
            else MessageBox.Show("No se pudo registrar la categoría.", CString.DEFAULT_TITLE, MessageBoxButtons.OK);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (_category == null)
            {
                MessageBox.Show("Busque y seleccione una categoría para continuar.", CString.DEFAULT_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            bool resp = _rpsCategory.Remove(_category.IdCategoria, DataOperator.Instance.Username);
            if (resp)
            {
                MessageBox.Show("Categoría eliminada con éxito.", CString.DEFAULT_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Information);
                Clear();
            }
            else MessageBox.Show("No se pudo eliminar la categoría.", CString.DEFAULT_TITLE, MessageBoxButtons.OK);
        }
    }
}
