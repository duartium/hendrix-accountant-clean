
namespace HendrixAccountant.Forms.Inventory
{
    partial class frmKardex
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle36 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle40 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle37 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle38 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle39 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvPuntoVenta = new System.Windows.Forms.DataGridView();
            this.colCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDireccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblFechaEmision = new System.Windows.Forms.Label();
            this.dtpFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.pnAside = new System.Windows.Forms.Panel();
            this.btnCerrar = new HendrixAccountant.UIControls.Buttons.ItemAsideSmall();
            this.btnLimpiar = new HendrixAccountant.UIControls.Buttons.ItemAsideSmall();
            this.btnImprimir = new HendrixAccountant.UIControls.Buttons.ItemAsideSmall();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnCodProveedor = new System.Windows.Forms.Panel();
            this.txtCodProducto = new HendrixAccountant.UIControls.NumericInput();
            this.lblPnCodigoProv = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pnNombreProveedor = new System.Windows.Forms.Panel();
            this.txtNombreProducto = new HendrixAccountant.UIControls.TextInput();
            this.lblPnNombreProv = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cboCategoria = new System.Windows.Forms.ComboBox();
            this.gbProductoFiltros = new System.Windows.Forms.GroupBox();
            this.btnConsultar = new HendrixAccountant.UIControls.Buttons.ItemAsideSmall();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPuntoVenta)).BeginInit();
            this.pnAside.SuspendLayout();
            this.pnCodProveedor.SuspendLayout();
            this.pnNombreProveedor.SuspendLayout();
            this.gbProductoFiltros.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPuntoVenta
            // 
            this.dgvPuntoVenta.AllowUserToAddRows = false;
            this.dgvPuntoVenta.AllowUserToResizeRows = false;
            this.dgvPuntoVenta.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvPuntoVenta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPuntoVenta.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle36.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle36.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(46)))), ((int)(((byte)(140)))));
            dataGridViewCellStyle36.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle36.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle36.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle36.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle36.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPuntoVenta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle36;
            this.dgvPuntoVenta.ColumnHeadersHeight = 27;
            this.dgvPuntoVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvPuntoVenta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCodigo,
            this.colNombre,
            this.colCantidad,
            this.colDireccion,
            this.colTotal});
            this.dgvPuntoVenta.EnableHeadersVisualStyles = false;
            this.dgvPuntoVenta.Location = new System.Drawing.Point(12, 159);
            this.dgvPuntoVenta.Name = "dgvPuntoVenta";
            dataGridViewCellStyle40.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle40.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle40.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle40.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle40.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle40.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle40.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPuntoVenta.RowHeadersDefaultCellStyle = dataGridViewCellStyle40;
            this.dgvPuntoVenta.RowHeadersVisible = false;
            this.dgvPuntoVenta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPuntoVenta.Size = new System.Drawing.Size(680, 268);
            this.dgvPuntoVenta.TabIndex = 13;
            // 
            // colCodigo
            // 
            this.colCodigo.HeaderText = "Código";
            this.colCodigo.Name = "colCodigo";
            this.colCodigo.ReadOnly = true;
            this.colCodigo.Width = 60;
            // 
            // colNombre
            // 
            this.colNombre.HeaderText = "Nombre de producto";
            this.colNombre.Name = "colNombre";
            this.colNombre.ReadOnly = true;
            this.colNombre.Width = 280;
            // 
            // colCantidad
            // 
            dataGridViewCellStyle37.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colCantidad.DefaultCellStyle = dataGridViewCellStyle37;
            this.colCantidad.HeaderText = "Cantidad";
            this.colCantidad.Name = "colCantidad";
            this.colCantidad.ReadOnly = true;
            this.colCantidad.Width = 80;
            // 
            // colDireccion
            // 
            dataGridViewCellStyle38.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colDireccion.DefaultCellStyle = dataGridViewCellStyle38;
            this.colDireccion.HeaderText = "Precio";
            this.colDireccion.Name = "colDireccion";
            this.colDireccion.ReadOnly = true;
            this.colDireccion.Width = 140;
            // 
            // colTotal
            // 
            dataGridViewCellStyle39.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle39.NullValue = "0";
            this.colTotal.DefaultCellStyle = dataGridViewCellStyle39;
            this.colTotal.HeaderText = "Total";
            this.colTotal.Name = "colTotal";
            this.colTotal.ReadOnly = true;
            this.colTotal.Width = 120;
            // 
            // lblFechaEmision
            // 
            this.lblFechaEmision.AutoSize = true;
            this.lblFechaEmision.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaEmision.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblFechaEmision.Location = new System.Drawing.Point(10, 77);
            this.lblFechaEmision.Name = "lblFechaEmision";
            this.lblFechaEmision.Size = new System.Drawing.Size(82, 15);
            this.lblFechaEmision.TabIndex = 15;
            this.lblFechaEmision.Text = "Fecha desde:";
            // 
            // dtpFechaDesde
            // 
            this.dtpFechaDesde.CalendarFont = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaDesde.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaDesde.Location = new System.Drawing.Point(13, 95);
            this.dtpFechaDesde.MinDate = new System.DateTime(1800, 1, 1, 0, 0, 0, 0);
            this.dtpFechaDesde.Name = "dtpFechaDesde";
            this.dtpFechaDesde.Size = new System.Drawing.Size(113, 25);
            this.dtpFechaDesde.TabIndex = 14;
            // 
            // pnAside
            // 
            this.pnAside.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(46)))), ((int)(((byte)(140)))));
            this.pnAside.Controls.Add(this.btnConsultar);
            this.pnAside.Controls.Add(this.btnCerrar);
            this.pnAside.Controls.Add(this.btnLimpiar);
            this.pnAside.Controls.Add(this.btnImprimir);
            this.pnAside.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnAside.Location = new System.Drawing.Point(774, 0);
            this.pnAside.Name = "pnAside";
            this.pnAside.Size = new System.Drawing.Size(127, 512);
            this.pnAside.TabIndex = 79;
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(184)))), ((int)(((byte)(39)))));
            this.btnCerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(184)))), ((int)(((byte)(39)))));
            this.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(184)))), ((int)(((byte)(45)))));
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.Font = new System.Drawing.Font("Arial", 9F);
            this.btnCerrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(46)))), ((int)(((byte)(140)))));
            this.btnCerrar.Image = global::HendrixAccountant.Properties.Resources.CloseBlue20;
            this.btnCerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrar.Location = new System.Drawing.Point(0, 474);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnCerrar.Size = new System.Drawing.Size(127, 35);
            this.btnCerrar.TabIndex = 16;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(184)))), ((int)(((byte)(39)))));
            this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(184)))), ((int)(((byte)(39)))));
            this.btnLimpiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(184)))), ((int)(((byte)(45)))));
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Arial", 9F);
            this.btnLimpiar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(46)))), ((int)(((byte)(140)))));
            this.btnLimpiar.Image = global::HendrixAccountant.Properties.Resources.clearBlue20;
            this.btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpiar.Location = new System.Drawing.Point(0, 392);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnLimpiar.Size = new System.Drawing.Size(127, 35);
            this.btnLimpiar.TabIndex = 15;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            // 
            // btnImprimir
            // 
            this.btnImprimir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(184)))), ((int)(((byte)(39)))));
            this.btnImprimir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImprimir.FlatAppearance.BorderSize = 0;
            this.btnImprimir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(184)))), ((int)(((byte)(39)))));
            this.btnImprimir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(184)))), ((int)(((byte)(45)))));
            this.btnImprimir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImprimir.Font = new System.Drawing.Font("Arial", 9F);
            this.btnImprimir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(46)))), ((int)(((byte)(140)))));
            this.btnImprimir.Image = global::HendrixAccountant.Properties.Resources.printBlue20;
            this.btnImprimir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnImprimir.Location = new System.Drawing.Point(0, 58);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnImprimir.Size = new System.Drawing.Size(127, 40);
            this.btnImprimir.TabIndex = 5;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = false;
            this.btnImprimir.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label1.Location = new System.Drawing.Point(145, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 15);
            this.label1.TabIndex = 81;
            this.label1.Text = "Fecha hasta:";
            // 
            // dtpFechaHasta
            // 
            this.dtpFechaHasta.CalendarFont = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaHasta.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaHasta.Location = new System.Drawing.Point(148, 95);
            this.dtpFechaHasta.MinDate = new System.DateTime(1800, 1, 1, 0, 0, 0, 0);
            this.dtpFechaHasta.Name = "dtpFechaHasta";
            this.dtpFechaHasta.Size = new System.Drawing.Size(113, 25);
            this.dtpFechaHasta.TabIndex = 80;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label3.Location = new System.Drawing.Point(10, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 15);
            this.label3.TabIndex = 86;
            this.label3.Text = "Código";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label2.Location = new System.Drawing.Point(88, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 15);
            this.label2.TabIndex = 85;
            this.label2.Text = "Nombre del producto";
            // 
            // pnCodProveedor
            // 
            this.pnCodProveedor.BackColor = System.Drawing.SystemColors.Control;
            this.pnCodProveedor.Controls.Add(this.txtCodProducto);
            this.pnCodProveedor.Controls.Add(this.lblPnCodigoProv);
            this.pnCodProveedor.Location = new System.Drawing.Point(13, 32);
            this.pnCodProveedor.Name = "pnCodProveedor";
            this.pnCodProveedor.Size = new System.Drawing.Size(73, 32);
            this.pnCodProveedor.TabIndex = 82;
            // 
            // txtCodProducto
            // 
            this.txtCodProducto.BackColor = System.Drawing.SystemColors.Control;
            this.txtCodProducto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCodProducto.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodProducto.Location = new System.Drawing.Point(2, 6);
            this.txtCodProducto.MaxLength = 10;
            this.txtCodProducto.Name = "txtCodProducto";
            this.txtCodProducto.Size = new System.Drawing.Size(65, 19);
            this.txtCodProducto.TabIndex = 6;
            // 
            // lblPnCodigoProv
            // 
            this.lblPnCodigoProv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(107)))), ((int)(((byte)(247)))));
            this.lblPnCodigoProv.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblPnCodigoProv.Location = new System.Drawing.Point(0, 29);
            this.lblPnCodigoProv.Name = "lblPnCodigoProv";
            this.lblPnCodigoProv.Size = new System.Drawing.Size(73, 3);
            this.lblPnCodigoProv.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(449, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(42, 34);
            this.button1.TabIndex = 84;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // pnNombreProveedor
            // 
            this.pnNombreProveedor.BackColor = System.Drawing.SystemColors.Control;
            this.pnNombreProveedor.Controls.Add(this.txtNombreProducto);
            this.pnNombreProveedor.Controls.Add(this.lblPnNombreProv);
            this.pnNombreProveedor.Location = new System.Drawing.Point(91, 32);
            this.pnNombreProveedor.Name = "pnNombreProveedor";
            this.pnNombreProveedor.Size = new System.Drawing.Size(352, 32);
            this.pnNombreProveedor.TabIndex = 83;
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.BackColor = System.Drawing.SystemColors.Control;
            this.txtNombreProducto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombreProducto.Enabled = false;
            this.txtNombreProducto.Font = new System.Drawing.Font("Arial", 10F);
            this.txtNombreProducto.Location = new System.Drawing.Point(1, 7);
            this.txtNombreProducto.MaxLength = 100;
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(348, 16);
            this.txtNombreProducto.TabIndex = 7;
            // 
            // lblPnNombreProv
            // 
            this.lblPnNombreProv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(107)))), ((int)(((byte)(247)))));
            this.lblPnNombreProv.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblPnNombreProv.Location = new System.Drawing.Point(0, 29);
            this.lblPnNombreProv.Name = "lblPnNombreProv";
            this.lblPnNombreProv.Size = new System.Drawing.Size(352, 3);
            this.lblPnNombreProv.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label7.Location = new System.Drawing.Point(280, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 15);
            this.label7.TabIndex = 87;
            this.label7.Text = "Tipo de movimiento";
            // 
            // cboCategoria
            // 
            this.cboCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategoria.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCategoria.FormattingEnabled = true;
            this.cboCategoria.Items.AddRange(new object[] {
            "TODOS",
            "ENTRADAS",
            "SALIDAS"});
            this.cboCategoria.Location = new System.Drawing.Point(283, 95);
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.Size = new System.Drawing.Size(248, 24);
            this.cboCategoria.TabIndex = 88;
            // 
            // gbProductoFiltros
            // 
            this.gbProductoFiltros.Controls.Add(this.pnNombreProveedor);
            this.gbProductoFiltros.Controls.Add(this.label7);
            this.gbProductoFiltros.Controls.Add(this.dtpFechaDesde);
            this.gbProductoFiltros.Controls.Add(this.cboCategoria);
            this.gbProductoFiltros.Controls.Add(this.lblFechaEmision);
            this.gbProductoFiltros.Controls.Add(this.label3);
            this.gbProductoFiltros.Controls.Add(this.dtpFechaHasta);
            this.gbProductoFiltros.Controls.Add(this.label2);
            this.gbProductoFiltros.Controls.Add(this.label1);
            this.gbProductoFiltros.Controls.Add(this.pnCodProveedor);
            this.gbProductoFiltros.Controls.Add(this.button1);
            this.gbProductoFiltros.Location = new System.Drawing.Point(12, 9);
            this.gbProductoFiltros.Name = "gbProductoFiltros";
            this.gbProductoFiltros.Size = new System.Drawing.Size(600, 140);
            this.gbProductoFiltros.TabIndex = 89;
            this.gbProductoFiltros.TabStop = false;
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(184)))), ((int)(((byte)(39)))));
            this.btnConsultar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsultar.FlatAppearance.BorderSize = 0;
            this.btnConsultar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(184)))), ((int)(((byte)(39)))));
            this.btnConsultar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(184)))), ((int)(((byte)(45)))));
            this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultar.Font = new System.Drawing.Font("Arial", 9F);
            this.btnConsultar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(46)))), ((int)(((byte)(140)))));
            this.btnConsultar.Image = global::HendrixAccountant.Properties.Resources.searchBlue20;
            this.btnConsultar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsultar.Location = new System.Drawing.Point(0, 12);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnConsultar.Size = new System.Drawing.Size(127, 40);
            this.btnConsultar.TabIndex = 17;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // frmKardex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(901, 512);
            this.Controls.Add(this.gbProductoFiltros);
            this.Controls.Add(this.pnAside);
            this.Controls.Add(this.dgvPuntoVenta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Location = new System.Drawing.Point(5, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmKardex";
            this.Text = "KARDEX";
            this.Load += new System.EventHandler(this.frmKardex_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPuntoVenta)).EndInit();
            this.pnAside.ResumeLayout(false);
            this.pnCodProveedor.ResumeLayout(false);
            this.pnCodProveedor.PerformLayout();
            this.pnNombreProveedor.ResumeLayout(false);
            this.pnNombreProveedor.PerformLayout();
            this.gbProductoFiltros.ResumeLayout(false);
            this.gbProductoFiltros.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPuntoVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDireccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotal;
        private System.Windows.Forms.Label lblFechaEmision;
        private System.Windows.Forms.DateTimePicker dtpFechaDesde;
        private System.Windows.Forms.Panel pnAside;
        private UIControls.Buttons.ItemAsideSmall btnCerrar;
        private UIControls.Buttons.ItemAsideSmall btnLimpiar;
        private UIControls.Buttons.ItemAsideSmall btnImprimir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFechaHasta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnCodProveedor;
        private UIControls.NumericInput txtCodProducto;
        private System.Windows.Forms.Label lblPnCodigoProv;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel pnNombreProveedor;
        private UIControls.TextInput txtNombreProducto;
        private System.Windows.Forms.Label lblPnNombreProv;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboCategoria;
        private System.Windows.Forms.GroupBox gbProductoFiltros;
        private UIControls.Buttons.ItemAsideSmall btnConsultar;
    }
}