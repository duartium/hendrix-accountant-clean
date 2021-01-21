using HendrixAccountant.Data.Dtos;
using HendrixAccountant.Forms;
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
    public partial class frmMain : Form
    {
        private frmBuscarClientes frmClientes = null;
        private frmBuscarProductos frmProductos = null;
        private frmAperturaCaja frmCaja = null;
        private frmPuntoVenta frmPuntoVenta = null;
        private frmVentas frmVentas = null;

        #region constructores
        public frmMain()
        {
            InitializeComponent();
        }
        #endregion


        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmClientes != null)
                return;

            frmClientes = new frmBuscarClientes();
            frmClientes.MdiParent = this;
            frmClientes.FormClosed += new FormClosedEventHandler(clientes_FormClosed);
            frmClientes.Show();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ( frmProductos != null)
                return;

            frmProductos = new frmBuscarProductos();
            frmProductos.MdiParent = this;
            frmProductos.FormClosed += new FormClosedEventHandler(productos_FormClosed);
            frmProductos.Show();
        }

        private void aperturarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmCaja != null)
                return;

            frmCaja = new frmAperturaCaja();
            frmCaja.MdiParent = this;
            frmCaja.FormClosed += new FormClosedEventHandler(caja_FormClosed);
            frmCaja.Show();
        }

        #region Events form closed
        private void clientes_FormClosed(object sender, EventArgs e)
        {
            frmClientes = null;
        }

        private void productos_FormClosed(object sender, EventArgs e)
        {
            frmProductos = null;
        }

        private void caja_FormClosed(object sender, EventArgs e)
        {
            frmCaja = null;
        }

        private void ventas_FormClosed(object sender, EventArgs e)
        {
            frmPuntoVenta = null;
        }

        private void frmVentas_FormClosed(object sender, EventArgs e)
        {
            frmVentas = null;
        }
        #endregion

        private void frmMain_Load(object sender, EventArgs e)
        {
        }

        private void btnVenta_Click(object sender, EventArgs e)
        {
            if (frmPuntoVenta != null)
                return;

            frmPuntoVenta = new frmPuntoVenta();
            frmPuntoVenta.MdiParent = this;
            frmPuntoVenta.FormClosed += new FormClosedEventHandler(ventas_FormClosed);
            frmPuntoVenta.Show();
        }

        private void ventaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmVentas != null)
                return;

            frmVentas = new frmVentas();
            frmVentas.MdiParent = this;
            frmVentas.FormClosed += new FormClosedEventHandler(frmVentas_FormClosed);
            frmVentas.Show();
        }
    }
}
