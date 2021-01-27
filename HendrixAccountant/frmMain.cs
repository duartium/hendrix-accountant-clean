using HendrixAccountant.ApplicationCore.Enums;
using HendrixAccountant.Forms.Directorio;
using HendrixAccountant.Forms.Inventory;
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
        private frmMantProducto frmMantProducto = null;
        private frmClientes frmClientes = null;
        private frmMantProveedor frmMantProveedor = null;
        private frmCompras frmCompras = null;
        private frmAperturaCaja frmCaja = null;
        private frmPuntoVenta frmPuntoVenta = null;
        private frmVentas frmVentas = null;
        private DataOperator _dataOper;
        private frmParametros  frmParametros = null;

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
            if (frmMantProducto != null) return;

            frmMantProducto = new frmMantProducto();
            frmMantProducto.MdiParent = this;
            frmMantProducto.FormClosed += new FormClosedEventHandler(productos_FormClosed);
            frmMantProducto.Show();
        }

        private void aperturarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmCaja != null) return;
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
            frmMantProducto = null;
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

        private void mantProductos_FormClosed(object sender, EventArgs e)
        {
            frmMantProducto = null;
        }

        private void mantProveedor_FormClosed(object sender, EventArgs e)
        {
            frmMantProveedor = null;
        }
        private void compras_FormClosed(object sender, EventArgs e)
        {
            frmCompras = null;
        }

        private void configuration_FormClosed(object sender, EventArgs e)
        {
            frmParametros = null;
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
            DeselectButtons();
            itemReportes.BackColor = Color.FromArgb(253, 184, 39);
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
            ShowConfiguration();
            DeselectButtons();
            itemConfiguracion.BackColor = Color.FromArgb(253, 184, 39);
        }

        private void clientesToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            ShowClient();
            DeselectButtons();
            itemClientes.BackColor = Color.FromArgb(253, 184, 39);
        }

        private void productosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (frmMantProducto != null) return;
            frmMantProducto = new frmMantProducto();
            frmMantProducto.MdiParent = this;
            frmMantProducto.FormClosed += new FormClosedEventHandler(mantProductos_FormClosed);
            frmMantProducto.Show();
        }

        private void proveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (frmMantProveedor != null) return;
            frmMantProveedor = new frmMantProveedor();
            frmMantProveedor.MdiParent = this;
            frmMantProveedor.FormClosed += new FormClosedEventHandler(mantProveedor_FormClosed);
            frmMantProveedor.Show();
        }

        private void ingresosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void comprasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (frmCompras != null) return;
            frmCompras = new frmCompras();
            frmCompras.MdiParent = this;
            frmCompras.FormClosed += new FormClosedEventHandler(compras_FormClosed);
            frmCompras.Show();
        }

        private void ShowConfiguration()
        {
            if (frmParametros != null) return;
            frmParametros = new frmParametros();
            frmParametros.MdiParent = this;
            frmParametros.FormClosed += new FormClosedEventHandler(configuration_FormClosed);
            frmParametros.Show();
        }

        private void parámetrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowConfiguration();
            DeselectButtons();
            itemConfiguracion.BackColor = Color.FromArgb(253, 184, 39);
        }
    }
}
