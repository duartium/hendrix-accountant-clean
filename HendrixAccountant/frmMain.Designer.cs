namespace HendrixAccountant
{
    partial class frmMain
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.sesiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cajaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aperturarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cierreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.directoriosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cardexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comprasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comprasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ventaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuraciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parámetrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusBarMain = new System.Windows.Forms.StatusStrip();
            this.lblEstado = new System.Windows.Forms.ToolStripStatusLabel();
            this.pnAside = new System.Windows.Forms.Panel();
            this.itemReportes = new HendrixAccountant.UIControls.ItemMenu();
            this.pnHeader = new System.Windows.Forms.Panel();
            this.itemClientes = new HendrixAccountant.UIControls.ItemMenu();
            this.itemConfiguracion = new HendrixAccountant.UIControls.ItemMenu();
            this.productosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemVenta = new HendrixAccountant.UIControls.ItemMenu();
            this.menuStripMain.SuspendLayout();
            this.statusBarMain.SuspendLayout();
            this.pnAside.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripMain
            // 
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sesiónToolStripMenuItem,
            this.cajaToolStripMenuItem,
            this.directoriosToolStripMenuItem1,
            this.inventarioToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.configuraciónToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Size = new System.Drawing.Size(1370, 24);
            this.menuStripMain.TabIndex = 0;
            this.menuStripMain.Text = "menuStrip1";
            // 
            // sesiónToolStripMenuItem
            // 
            this.sesiónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cerrarSesiónToolStripMenuItem});
            this.sesiónToolStripMenuItem.Name = "sesiónToolStripMenuItem";
            this.sesiónToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.sesiónToolStripMenuItem.Text = "Sesión";
            // 
            // cerrarSesiónToolStripMenuItem
            // 
            this.cerrarSesiónToolStripMenuItem.Name = "cerrarSesiónToolStripMenuItem";
            this.cerrarSesiónToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cerrarSesiónToolStripMenuItem.Text = "Cerrar sesión";
            // 
            // cajaToolStripMenuItem
            // 
            this.cajaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aperturarToolStripMenuItem,
            this.cierreToolStripMenuItem});
            this.cajaToolStripMenuItem.Name = "cajaToolStripMenuItem";
            this.cajaToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.cajaToolStripMenuItem.Text = "Caja";
            // 
            // aperturarToolStripMenuItem
            // 
            this.aperturarToolStripMenuItem.Name = "aperturarToolStripMenuItem";
            this.aperturarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aperturarToolStripMenuItem.Text = "Apertura";
            this.aperturarToolStripMenuItem.Click += new System.EventHandler(this.aperturarToolStripMenuItem_Click);
            // 
            // cierreToolStripMenuItem
            // 
            this.cierreToolStripMenuItem.Name = "cierreToolStripMenuItem";
            this.cierreToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cierreToolStripMenuItem.Text = "Cierre";
            // 
            // directoriosToolStripMenuItem1
            // 
            this.directoriosToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem,
            this.proveedoresToolStripMenuItem,
            this.productosToolStripMenuItem1,
            this.usuariosToolStripMenuItem});
            this.directoriosToolStripMenuItem1.Name = "directoriosToolStripMenuItem1";
            this.directoriosToolStripMenuItem1.Size = new System.Drawing.Size(71, 20);
            this.directoriosToolStripMenuItem1.Text = "Directorio";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.clientesToolStripMenuItem.Text = "Clientes";
            // 
            // proveedoresToolStripMenuItem
            // 
            this.proveedoresToolStripMenuItem.Name = "proveedoresToolStripMenuItem";
            this.proveedoresToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.proveedoresToolStripMenuItem.Text = "Proveedores";
            // 
            // inventarioToolStripMenuItem
            // 
            this.inventarioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productosToolStripMenuItem,
            this.cardexToolStripMenuItem,
            this.ingresosToolStripMenuItem,
            this.comprasToolStripMenuItem});
            this.inventarioToolStripMenuItem.Name = "inventarioToolStripMenuItem";
            this.inventarioToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.inventarioToolStripMenuItem.Text = "Inventario";
            // 
            // productosToolStripMenuItem
            // 
            this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
            this.productosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.productosToolStripMenuItem.Text = "Lista de productos";
            this.productosToolStripMenuItem.Click += new System.EventHandler(this.productosToolStripMenuItem_Click);
            // 
            // cardexToolStripMenuItem
            // 
            this.cardexToolStripMenuItem.Name = "cardexToolStripMenuItem";
            this.cardexToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cardexToolStripMenuItem.Text = "Cardex";
            // 
            // ingresosToolStripMenuItem
            // 
            this.ingresosToolStripMenuItem.Name = "ingresosToolStripMenuItem";
            this.ingresosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ingresosToolStripMenuItem.Text = "Entradas";
            // 
            // comprasToolStripMenuItem
            // 
            this.comprasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.comprasToolStripMenuItem1});
            this.comprasToolStripMenuItem.Name = "comprasToolStripMenuItem";
            this.comprasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.comprasToolStripMenuItem.Text = "Salidas";
            // 
            // comprasToolStripMenuItem1
            // 
            this.comprasToolStripMenuItem1.Name = "comprasToolStripMenuItem1";
            this.comprasToolStripMenuItem1.Size = new System.Drawing.Size(122, 22);
            this.comprasToolStripMenuItem1.Text = "Compras";
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ventaToolStripMenuItem});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // ventaToolStripMenuItem
            // 
            this.ventaToolStripMenuItem.Name = "ventaToolStripMenuItem";
            this.ventaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ventaToolStripMenuItem.Text = "Ventas";
            this.ventaToolStripMenuItem.Click += new System.EventHandler(this.ventaToolStripMenuItem_Click);
            // 
            // configuraciónToolStripMenuItem
            // 
            this.configuraciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.parámetrosToolStripMenuItem});
            this.configuraciónToolStripMenuItem.Name = "configuraciónToolStripMenuItem";
            this.configuraciónToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.configuraciónToolStripMenuItem.Text = "Configuración";
            // 
            // parámetrosToolStripMenuItem
            // 
            this.parámetrosToolStripMenuItem.Name = "parámetrosToolStripMenuItem";
            this.parámetrosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.parámetrosToolStripMenuItem.Text = "Parámetros";
            // 
            // statusBarMain
            // 
            this.statusBarMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblEstado});
            this.statusBarMain.Location = new System.Drawing.Point(200, 488);
            this.statusBarMain.Name = "statusBarMain";
            this.statusBarMain.Size = new System.Drawing.Size(1170, 22);
            this.statusBarMain.TabIndex = 3;
            this.statusBarMain.Text = "Estado:";
            // 
            // lblEstado
            // 
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(45, 17);
            this.lblEstado.Text = "Estado:";
            // 
            // pnAside
            // 
            this.pnAside.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(46)))), ((int)(((byte)(140)))));
            this.pnAside.Controls.Add(this.itemVenta);
            this.pnAside.Controls.Add(this.itemConfiguracion);
            this.pnAside.Controls.Add(this.itemClientes);
            this.pnAside.Controls.Add(this.pnHeader);
            this.pnAside.Controls.Add(this.itemReportes);
            this.pnAside.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnAside.Location = new System.Drawing.Point(0, 24);
            this.pnAside.Name = "pnAside";
            this.pnAside.Size = new System.Drawing.Size(200, 486);
            this.pnAside.TabIndex = 1;
            // 
            // itemReportes
            // 
            this.itemReportes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(46)))), ((int)(((byte)(140)))));
            this.itemReportes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.itemReportes.FlatAppearance.BorderSize = 0;
            this.itemReportes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(46)))), ((int)(((byte)(140)))));
            this.itemReportes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(184)))), ((int)(((byte)(39)))));
            this.itemReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.itemReportes.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.itemReportes.ForeColor = System.Drawing.Color.White;
            this.itemReportes.Location = new System.Drawing.Point(0, 211);
            this.itemReportes.Name = "itemReportes";
            this.itemReportes.Size = new System.Drawing.Size(200, 44);
            this.itemReportes.TabIndex = 5;
            this.itemReportes.Text = "REPORTES";
            this.itemReportes.UseVisualStyleBackColor = false;
            this.itemReportes.Click += new System.EventHandler(this.itemReportes_Click);
            // 
            // pnHeader
            // 
            this.pnHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(184)))), ((int)(((byte)(39)))));
            this.pnHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnHeader.Location = new System.Drawing.Point(0, 0);
            this.pnHeader.Name = "pnHeader";
            this.pnHeader.Size = new System.Drawing.Size(200, 86);
            this.pnHeader.TabIndex = 5;
            // 
            // itemClientes
            // 
            this.itemClientes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(46)))), ((int)(((byte)(140)))));
            this.itemClientes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.itemClientes.FlatAppearance.BorderSize = 0;
            this.itemClientes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(46)))), ((int)(((byte)(140)))));
            this.itemClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(184)))), ((int)(((byte)(39)))));
            this.itemClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.itemClientes.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.itemClientes.ForeColor = System.Drawing.Color.White;
            this.itemClientes.Location = new System.Drawing.Point(0, 159);
            this.itemClientes.Name = "itemClientes";
            this.itemClientes.Size = new System.Drawing.Size(200, 44);
            this.itemClientes.TabIndex = 6;
            this.itemClientes.Text = "CLIENTES";
            this.itemClientes.UseVisualStyleBackColor = false;
            this.itemClientes.Click += new System.EventHandler(this.itemClientes_Click);
            // 
            // itemConfiguracion
            // 
            this.itemConfiguracion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(46)))), ((int)(((byte)(140)))));
            this.itemConfiguracion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.itemConfiguracion.FlatAppearance.BorderSize = 0;
            this.itemConfiguracion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(46)))), ((int)(((byte)(140)))));
            this.itemConfiguracion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(184)))), ((int)(((byte)(39)))));
            this.itemConfiguracion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.itemConfiguracion.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.itemConfiguracion.ForeColor = System.Drawing.Color.White;
            this.itemConfiguracion.Location = new System.Drawing.Point(0, 265);
            this.itemConfiguracion.Name = "itemConfiguracion";
            this.itemConfiguracion.Size = new System.Drawing.Size(200, 44);
            this.itemConfiguracion.TabIndex = 7;
            this.itemConfiguracion.Text = "CONFIGURACIÓN";
            this.itemConfiguracion.UseVisualStyleBackColor = false;
            this.itemConfiguracion.Click += new System.EventHandler(this.itemConfiguracion_Click);
            // 
            // productosToolStripMenuItem1
            // 
            this.productosToolStripMenuItem1.Name = "productosToolStripMenuItem1";
            this.productosToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.productosToolStripMenuItem1.Text = "Productos";
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            // 
            // itemVenta
            // 
            this.itemVenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(46)))), ((int)(((byte)(140)))));
            this.itemVenta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.itemVenta.FlatAppearance.BorderSize = 0;
            this.itemVenta.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(46)))), ((int)(((byte)(140)))));
            this.itemVenta.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(184)))), ((int)(((byte)(39)))));
            this.itemVenta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.itemVenta.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.itemVenta.ForeColor = System.Drawing.Color.White;
            this.itemVenta.Location = new System.Drawing.Point(0, 106);
            this.itemVenta.Name = "itemVenta";
            this.itemVenta.Size = new System.Drawing.Size(200, 44);
            this.itemVenta.TabIndex = 5;
            this.itemVenta.Text = "VENTA";
            this.itemVenta.UseVisualStyleBackColor = false;
            this.itemVenta.Click += new System.EventHandler(this.itemVenta_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 510);
            this.Controls.Add(this.statusBarMain);
            this.Controls.Add(this.pnAside);
            this.Controls.Add(this.menuStripMain);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStripMain;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HENDRIX";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.statusBarMain.ResumeLayout(false);
            this.statusBarMain.PerformLayout();
            this.pnAside.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem sesiónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesiónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configuraciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parámetrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cardexToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusBarMain;
        private System.Windows.Forms.ToolStripStatusLabel lblEstado;
        private System.Windows.Forms.ToolStripMenuItem cajaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aperturarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cierreToolStripMenuItem;
        private System.Windows.Forms.Panel pnAside;
        private System.Windows.Forms.ToolStripMenuItem directoriosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proveedoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comprasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comprasToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ventaToolStripMenuItem;
        private UIControls.ItemMenu itemReportes;
        private System.Windows.Forms.Panel pnHeader;
        private UIControls.ItemMenu itemClientes;
        private UIControls.ItemMenu itemConfiguracion;
        private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private UIControls.ItemMenu itemVenta;
    }
}

