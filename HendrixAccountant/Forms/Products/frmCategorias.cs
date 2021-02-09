using HendrixAccountant.ApplicationCore.DTOs;
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

namespace HendrixAccountant.Forms.Products
{
    public partial class frmCategorias : Form, IFindElement
    {
        private CategoryDto _categoria;
        public frmCategorias()
        {
            InitializeComponent();
            _categoria = null;
        }

        private void frmCategorias_Load(object sender, EventArgs e)
        {

        }

        private void frmCategorias_Activated(object sender, EventArgs e)
        {
            txtCodigo.Focus();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            _categoria = null;
            Clear();
            frmBuscarClientes frmBuscarClientes = new frmBuscarClientes(this);
            frmBuscarClientes.ShowDialog();
        }

        private void rbnNuevo_CheckedChanged(object sender, EventArgs e)
        {
            btnBuscar.Enabled = false;
            btnEliminar.Enabled = true;
            btnEliminar.BackColor = SystemColors.Control;
            btnBuscar.BackColor = SystemColors.Control;
            EnabledTextboxs(true);
            txtCodigo.Focus();
            _categoria = null;
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
            btnEliminar.Enabled = true;
            btnBuscar.Enabled = true;
            btnEliminar.BackColor = Color.FromArgb(220, 53, 69);
            btnBuscar.BackColor = Color.FromArgb(253, 184, 39);
            EnabledTextboxs(false);
            btnBuscar.Focus();
        }
    }
}
