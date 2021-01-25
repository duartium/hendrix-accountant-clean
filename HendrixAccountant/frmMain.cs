using HendrixAccountant.ApplicationCore.Enums;
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
        private frmClientes frmClientes = null;
        private frmBuscarProductos frmProductos = null;
        private frmAperturaCaja frmCaja = null;
        private frmPuntoVenta frmPuntoVenta = null;
        private frmVentas frmVentas = null;
        private DataOperator _dataOper;

        #region constructores
        public frmMain()
        {
            InitializeComponent();
            DataOperator _operator = DataOperator.Instance;
            _operator.IdUser = 1;
            _operator.Username = "admin";
            _operator.UserRole = 1;
            _operator.Role = "Administrador";
        }
        #endregion


        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowClient();
        }

        private void ShowClient()
        {
            if (frmClientes != null) return;
            frmClientes = new frmClientes();
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
            _dataOper = DataOperator.Instance;
            if (_dataOper.UserRole == (int)UserRole.CAJERO)
                RestrictAccess();

            lblNombreUsuario.Text = _dataOper.Username;
            lblTipoUsuario.Text = _dataOper.Role;
            foreach (Control ctrl in this.Controls)
                if (ctrl is MdiClient)
                    ctrl.BackColor = SystemColors.ControlLight;
        }

        private void RestrictAccess()
        {
            configuracionToolStripMenuItem.Visible = false;
            inventarioToolStripMenuItem.Visible = false;
            itemConfiguracion.Visible = false;
        }

        private void btnVenta_Click(object sender, EventArgs e)
        {
            if (frmPuntoVenta != null)return;
            frmPuntoVenta = new frmPuntoVenta();
            frmPuntoVenta.MdiParent = this;
            frmPuntoVenta.FormClosed += new FormClosedEventHandler(ventas_FormClosed);
            frmPuntoVenta.Show();
        }

        private void ventaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowReports();
        }

        private void ShowReports()
        {
            if (frmVentas != null) return;
            frmVentas = new frmVentas();
            frmVentas.MdiParent = this;
            frmVentas.FormClosed += new FormClosedEventHandler(frmVentas_FormClosed);
            frmVentas.Show();
        }

        private void itemVenta_Click(object sender, EventArgs e)
        {
            if (frmPuntoVenta != null) return;
            
            DeselectButtons();
            itemVenta.BackColor = Color.FromArgb(253, 184, 39);
            frmPuntoVenta = new frmPuntoVenta();
            frmPuntoVenta.MdiParent = this;
            frmPuntoVenta.FormClosed += new FormClosedEventHandler(ventas_FormClosed);
            frmPuntoVenta.Show();
            //frmPuntoVenta.Location = new Point(10, 10);
            //frmPuntoVenta.Location = new Point(210, 30);

        }

        private void DeselectButtons()
        {
            itemClientes.BackColor = Color.FromArgb(27, 46, 140);
            itemConfiguracion.BackColor = Color.FromArgb(27, 46, 140);
            itemReportes.BackColor = Color.FromArgb(27, 46, 140);
            itemVenta.BackColor = Color.FromArgb(27, 46, 140);
        }

        private void itemClientes_Click(object sender, EventArgs e)
        {
            ShowClient();
            DeselectButtons();
            itemClientes.BackColor = Color.FromArgb(253, 184, 39);
        }

        private void itemReportes_Click(object sender, EventArgs e)
        {
            ShowReports();
            DeselectButtons();
            itemReportes.BackColor = Color.FromArgb(253, 184, 39);
        }

        private void itemConfiguracion_Click(object sender, EventArgs e)
        {
            DeselectButtons();
            itemConfiguracion.BackColor = Color.FromArgb(253, 184, 39);
        }

        private void clientesToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ShowClient();
        }
    }
}
