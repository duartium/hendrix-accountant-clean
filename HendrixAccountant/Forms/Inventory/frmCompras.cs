using HendrixAccountant.ApplicationCore.DTOs;
using HendrixAccountant.ApplicationCore.Entities;
using HendrixAccountant.Common;
using HendrixAccountant.Data;
using HendrixAccountant.Forms.Directorio;
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
    public partial class frmCompras : Form
    {

        public Supplier Proveedor { get; set; }
        public List<Product> Productos { get; set; }
        public List<ProductDetailBuyDto> ListaDetalleProductos { get; set; }

        public frmCompras()
        {
            InitializeComponent();
        }

        private void btnBuscarProveedor_Click(object sender, EventArgs e)
        {
            //frmModalProveedor modal = new frmModalProveedor(this);
            //modal.ShowDialog();
        }

        public void EstablecerProveedorEnControlesEntrada()
        {
            this.txtCodProveedor.Text = this.Proveedor.proveedor_id + "";
            this.txtNombreProveedor.Text = this.Proveedor.nombre;
        }

        public void EstablecerListaProductosEnDataGridView()
        {
            // if (this.Productos.Count == 0)
            if (this.ListaDetalleProductos.Count == 0)
            {
                MessageBox.Show("No se obtuvieron datos.", "Notificación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            dgvListado.AutoGenerateColumns = true;
            if (dgvListado.DataSource != null)
            {
                dgvListado.DataSource = null;
                dgvListado.DataSource = this.ListaDetalleProductos;
                // dgvListado.DataSource = this.Productos;
            }
            else
            {
                dgvListado.DataSource = this.ListaDetalleProductos;
                // dgvListado.DataSource = this.Productos;
            }
            ConfigurarColumnas();
            dgvListado.Update();
            dgvListado.Refresh();
        }

        private void ConfigurarColumnas()
        {
            // truco para hacer todas las columnas no visible
            int cantidadColumnas = dgvListado.Columns.Count;
            for (int i = 0; i < cantidadColumnas; i++)
            {
                dgvListado.Columns[i].Visible = false;
            }

            // solo mostrar las siguientes columnas
            dgvListado.Columns["Codigo"].Visible = true;
            dgvListado.Columns["Nombre"].Visible = true;
            dgvListado.Columns["cantidad"].Visible = true;
            dgvListado.Columns["PrecioCompra"].Visible = true;
            dgvListado.Columns["PrecioVenta"].Visible = true;


            // cambiar nombre de columna por
            dgvListado.Columns["Codigo"].HeaderText = "Cod.";
            dgvListado.Columns["Nombre"].HeaderText = "Nombre";
            dgvListado.Columns["cantidad"].HeaderText = "Cant.";
            dgvListado.Columns["PrecioCompra"].HeaderText = "Pr. Cpa.";
            dgvListado.Columns["PrecioVenta"].HeaderText = "Pr. Vta.";
        }

        #region metodos privados

        #endregion

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (this.Proveedor == null || this.Proveedor.proveedor_id <= 0)
            {
                MessageBox.Show("Seleccione un Proveedor.", "Notificación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            frmModalProductos modal = new frmModalProductos(this);
            modal.ShowDialog();
        }

        frmMantProveedor frmMantProveedor;
        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (frmMantProveedor == null)
            {
                frmMantProveedor = new frmMantProveedor();
                frmMantProveedor.ShowDialog();
            }
            else
            {
                return;
            }

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {

                // Verificar que la lista no este vacia, sino mandar un mensaje e indicar que esta vacio.
                if (this.ListaDetalleProductos.Count <= 0 || this.ListaDetalleProductos == null)
                {
                    return;
                }

                var confirmResult = MessageBox.Show("¿Estas seguro de registrar el ingreso?",
                                     "Confirmar",
                                     MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    // If 'Yes', do something here.
                    MessageBox.Show("si.", "Compras", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    // If 'No', do something here.
                    MessageBox.Show("no.", "Compras", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch (Exception ex)
            {
                Utils.GrabarLog("Search", ex.ToString());
                MessageBox.Show("Error no controlado en el proceso.", "Proveedores", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
