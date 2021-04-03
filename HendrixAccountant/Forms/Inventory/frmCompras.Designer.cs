namespace HendrixAccountant.Forms.Inventory
{
    partial class frmCompras
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCompras));
            this.gbProveedor = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.pnIdentificacion = new System.Windows.Forms.Panel();
            this.txtNumComprobante = new HendrixAccountant.UIControls.NumericInput();
            this.label7 = new System.Windows.Forms.Label();
            this.pnDireccion = new System.Windows.Forms.Panel();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.lblPnDescripcion = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpFechaEmision = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.pnCodProveedor = new System.Windows.Forms.Panel();
            this.txtCodProveedor = new HendrixAccountant.UIControls.NumericInput();
            this.lblPnCodigoProv = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pnNombreProveedor = new System.Windows.Forms.Panel();
            this.txtNombreProveedor = new HendrixAccountant.UIControls.TextInput();
            this.lblPnNombreProv = new System.Windows.Forms.Label();
            this.txtTotalCompra = new System.Windows.Forms.TextBox();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.pnAside = new System.Windows.Forms.Panel();
            this.btnCerrar = new HendrixAccountant.UIControls.Buttons.ItemAsideSmall();
            this.btnLimpiar = new HendrixAccountant.UIControls.Buttons.ItemAsideSmall();
            this.btnImprimir = new HendrixAccountant.UIControls.Buttons.ItemAsideSmall();
            this.btnGuardar = new HendrixAccountant.UIControls.Buttons.ItemAsideSmall();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.colCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombreProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrecio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbProveedor.SuspendLayout();
            this.pnIdentificacion.SuspendLayout();
            this.pnDireccion.SuspendLayout();
            this.pnCodProveedor.SuspendLayout();
            this.pnNombreProveedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.pnAside.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbProveedor
            // 
            this.gbProveedor.Controls.Add(this.label15);
            this.gbProveedor.Controls.Add(this.pnIdentificacion);
            this.gbProveedor.Controls.Add(this.pnDireccion);
            this.gbProveedor.Controls.Add(this.label5);
            this.gbProveedor.Controls.Add(this.label6);
            this.gbProveedor.Controls.Add(this.label3);
            this.gbProveedor.Controls.Add(this.dtpFechaEmision);
            this.gbProveedor.Controls.Add(this.label2);
            this.gbProveedor.Controls.Add(this.pnCodProveedor);
            this.gbProveedor.Controls.Add(this.button1);
            this.gbProveedor.Controls.Add(this.pnNombreProveedor);
            this.gbProveedor.Location = new System.Drawing.Point(9, 3);
            this.gbProveedor.Name = "gbProveedor";
            this.gbProveedor.Size = new System.Drawing.Size(488, 176);
            this.gbProveedor.TabIndex = 0;
            this.gbProveedor.TabStop = false;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label15.Location = new System.Drawing.Point(15, 118);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(148, 15);
            this.label15.TabIndex = 78;
            this.label15.Text = "Observaciones (opcional)";
            // 
            // pnIdentificacion
            // 
            this.pnIdentificacion.BackColor = System.Drawing.SystemColors.Control;
            this.pnIdentificacion.Controls.Add(this.txtNumComprobante);
            this.pnIdentificacion.Controls.Add(this.label7);
            this.pnIdentificacion.Location = new System.Drawing.Point(18, 32);
            this.pnIdentificacion.Name = "pnIdentificacion";
            this.pnIdentificacion.Size = new System.Drawing.Size(151, 32);
            this.pnIdentificacion.TabIndex = 80;
            // 
            // txtNumComprobante
            // 
            this.txtNumComprobante.BackColor = System.Drawing.SystemColors.Control;
            this.txtNumComprobante.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNumComprobante.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumComprobante.Location = new System.Drawing.Point(3, 6);
            this.txtNumComprobante.MaxLength = 13;
            this.txtNumComprobante.Name = "txtNumComprobante";
            this.txtNumComprobante.Size = new System.Drawing.Size(145, 19);
            this.txtNumComprobante.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(107)))), ((int)(((byte)(247)))));
            this.label7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label7.Location = new System.Drawing.Point(0, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(151, 3);
            this.label7.TabIndex = 9;
            // 
            // pnDireccion
            // 
            this.pnDireccion.BackColor = System.Drawing.SystemColors.Control;
            this.pnDireccion.Controls.Add(this.txtObservaciones);
            this.pnDireccion.Controls.Add(this.lblPnDescripcion);
            this.pnDireccion.Location = new System.Drawing.Point(18, 133);
            this.pnDireccion.Name = "pnDireccion";
            this.pnDireccion.Size = new System.Drawing.Size(450, 32);
            this.pnDireccion.TabIndex = 77;
            // 
            // txtObservaciones
            // 
            this.txtObservaciones.BackColor = System.Drawing.SystemColors.Control;
            this.txtObservaciones.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtObservaciones.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObservaciones.Location = new System.Drawing.Point(2, 8);
            this.txtObservaciones.MaxLength = 150;
            this.txtObservaciones.Name = "txtObservaciones";
            this.txtObservaciones.Size = new System.Drawing.Size(445, 15);
            this.txtObservaciones.TabIndex = 2;
            // 
            // lblPnDescripcion
            // 
            this.lblPnDescripcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(107)))), ((int)(((byte)(247)))));
            this.lblPnDescripcion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblPnDescripcion.Location = new System.Drawing.Point(0, 29);
            this.lblPnDescripcion.Name = "lblPnDescripcion";
            this.lblPnDescripcion.Size = new System.Drawing.Size(450, 3);
            this.lblPnDescripcion.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label5.Location = new System.Drawing.Point(15, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 15);
            this.label5.TabIndex = 79;
            this.label5.Text = "Nº comprobante (opcional)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label6.Location = new System.Drawing.Point(230, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 15);
            this.label6.TabIndex = 78;
            this.label6.Text = "Fecha de compra";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label3.Location = new System.Drawing.Point(16, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 15);
            this.label3.TabIndex = 76;
            this.label3.Text = "Código";
            // 
            // dtpFechaEmision
            // 
            this.dtpFechaEmision.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaEmision.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaEmision.Location = new System.Drawing.Point(233, 35);
            this.dtpFechaEmision.Name = "dtpFechaEmision";
            this.dtpFechaEmision.Size = new System.Drawing.Size(108, 22);
            this.dtpFechaEmision.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label2.Location = new System.Drawing.Point(94, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 15);
            this.label2.TabIndex = 75;
            this.label2.Text = "Nombre de proveedor";
            // 
            // pnCodProveedor
            // 
            this.pnCodProveedor.BackColor = System.Drawing.SystemColors.Control;
            this.pnCodProveedor.Controls.Add(this.txtCodProveedor);
            this.pnCodProveedor.Controls.Add(this.lblPnCodigoProv);
            this.pnCodProveedor.Location = new System.Drawing.Point(19, 83);
            this.pnCodProveedor.Name = "pnCodProveedor";
            this.pnCodProveedor.Size = new System.Drawing.Size(73, 32);
            this.pnCodProveedor.TabIndex = 72;
            // 
            // txtCodProveedor
            // 
            this.txtCodProveedor.BackColor = System.Drawing.SystemColors.Control;
            this.txtCodProveedor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCodProveedor.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodProveedor.Location = new System.Drawing.Point(2, 6);
            this.txtCodProveedor.MaxLength = 10;
            this.txtCodProveedor.Name = "txtCodProveedor";
            this.txtCodProveedor.Size = new System.Drawing.Size(65, 19);
            this.txtCodProveedor.TabIndex = 6;
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
            this.button1.Location = new System.Drawing.Point(373, 83);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(42, 32);
            this.button1.TabIndex = 74;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // pnNombreProveedor
            // 
            this.pnNombreProveedor.BackColor = System.Drawing.SystemColors.Control;
            this.pnNombreProveedor.Controls.Add(this.txtNombreProveedor);
            this.pnNombreProveedor.Controls.Add(this.lblPnNombreProv);
            this.pnNombreProveedor.Location = new System.Drawing.Point(97, 83);
            this.pnNombreProveedor.Name = "pnNombreProveedor";
            this.pnNombreProveedor.Size = new System.Drawing.Size(269, 32);
            this.pnNombreProveedor.TabIndex = 73;
            // 
            // txtNombreProveedor
            // 
            this.txtNombreProveedor.BackColor = System.Drawing.SystemColors.Control;
            this.txtNombreProveedor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombreProveedor.Font = new System.Drawing.Font("Arial", 10F);
            this.txtNombreProveedor.Location = new System.Drawing.Point(1, 7);
            this.txtNombreProveedor.MaxLength = 100;
            this.txtNombreProveedor.Name = "txtNombreProveedor";
            this.txtNombreProveedor.Size = new System.Drawing.Size(265, 16);
            this.txtNombreProveedor.TabIndex = 7;
            // 
            // lblPnNombreProv
            // 
            this.lblPnNombreProv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(107)))), ((int)(((byte)(247)))));
            this.lblPnNombreProv.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblPnNombreProv.Location = new System.Drawing.Point(0, 29);
            this.lblPnNombreProv.Name = "lblPnNombreProv";
            this.lblPnNombreProv.Size = new System.Drawing.Size(269, 3);
            this.lblPnNombreProv.TabIndex = 9;
            // 
            // txtTotalCompra
            // 
            this.txtTotalCompra.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTotalCompra.Enabled = false;
            this.txtTotalCompra.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalCompra.ForeColor = System.Drawing.Color.Black;
            this.txtTotalCompra.Location = new System.Drawing.Point(362, 180);
            this.txtTotalCompra.MaxLength = 13;
            this.txtTotalCompra.Name = "txtTotalCompra";
            this.txtTotalCompra.Size = new System.Drawing.Size(133, 34);
            this.txtTotalCompra.TabIndex = 14;
            this.txtTotalCompra.Text = "0.00";
            this.txtTotalCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // dgvProductos
            // 
            this.dgvProductos.AllowUserToAddRows = false;
            this.dgvProductos.AllowUserToResizeRows = false;
            this.dgvProductos.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvProductos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProductos.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(46)))), ((int)(((byte)(140)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProductos.ColumnHeadersHeight = 27;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCodigo,
            this.colNombreProd,
            this.colStock,
            this.colPrecio,
            this.ColTotal});
            this.dgvProductos.EnableHeadersVisualStyles = false;
            this.dgvProductos.Location = new System.Drawing.Point(9, 220);
            this.dgvProductos.MultiSelect = false;
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.RowHeadersVisible = false;
            this.dgvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductos.Size = new System.Drawing.Size(488, 238);
            this.dgvProductos.TabIndex = 15;
            // 
            // pnAside
            // 
            this.pnAside.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(46)))), ((int)(((byte)(140)))));
            this.pnAside.Controls.Add(this.btnCerrar);
            this.pnAside.Controls.Add(this.btnLimpiar);
            this.pnAside.Controls.Add(this.btnImprimir);
            this.pnAside.Controls.Add(this.btnGuardar);
            this.pnAside.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnAside.Location = new System.Drawing.Point(514, 0);
            this.pnAside.Name = "pnAside";
            this.pnAside.Size = new System.Drawing.Size(127, 471);
            this.pnAside.TabIndex = 78;
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
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
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
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(184)))), ((int)(((byte)(39)))));
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(184)))), ((int)(((byte)(39)))));
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(184)))), ((int)(((byte)(45)))));
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Arial", 9F);
            this.btnGuardar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(46)))), ((int)(((byte)(140)))));
            this.btnGuardar.Image = global::HendrixAccountant.Properties.Resources.saveBlue20;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(0, 13);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnGuardar.Size = new System.Drawing.Size(127, 40);
            this.btnGuardar.TabIndex = 4;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click_2);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(89)))));
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.ForeColor = System.Drawing.SystemColors.Window;
            this.btnAgregar.Image = global::HendrixAccountant.Properties.Resources.addWhite20;
            this.btnAgregar.Location = new System.Drawing.Point(182, 184);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(151, 30);
            this.btnAgregar.TabIndex = 77;
            this.btnAgregar.Text = " Agregar producto";
            this.btnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // colCodigo
            // 
            this.colCodigo.HeaderText = "Código";
            this.colCodigo.Name = "colCodigo";
            this.colCodigo.ReadOnly = true;
            this.colCodigo.Width = 80;
            // 
            // colNombreProd
            // 
            this.colNombreProd.HeaderText = "Nombre de artículo";
            this.colNombreProd.Name = "colNombreProd";
            this.colNombreProd.ReadOnly = true;
            this.colNombreProd.Width = 210;
            // 
            // colStock
            // 
            this.colStock.HeaderText = "Cantidad";
            this.colStock.Name = "colStock";
            this.colStock.ReadOnly = true;
            // 
            // colPrecio
            // 
            this.colPrecio.HeaderText = "Precio";
            this.colPrecio.Name = "colPrecio";
            this.colPrecio.ReadOnly = true;
            // 
            // ColTotal
            // 
            this.ColTotal.HeaderText = "Total";
            this.ColTotal.Name = "ColTotal";
            // 
            // frmCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(641, 471);
            this.Controls.Add(this.pnAside);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dgvProductos);
            this.Controls.Add(this.txtTotalCompra);
            this.Controls.Add(this.gbProveedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(5, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCompras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "REGISTRO DE COMPRA";
            this.Activated += new System.EventHandler(this.frmCompras_Activated);
            this.Load += new System.EventHandler(this.frmCompras_Load);
            this.gbProveedor.ResumeLayout(false);
            this.gbProveedor.PerformLayout();
            this.pnIdentificacion.ResumeLayout(false);
            this.pnIdentificacion.PerformLayout();
            this.pnDireccion.ResumeLayout(false);
            this.pnDireccion.PerformLayout();
            this.pnCodProveedor.ResumeLayout(false);
            this.pnCodProveedor.PerformLayout();
            this.pnNombreProveedor.ResumeLayout(false);
            this.pnNombreProveedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.pnAside.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbProveedor;
        private System.Windows.Forms.DateTimePicker dtpFechaEmision;
        private System.Windows.Forms.TextBox txtTotalCompra;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnCodProveedor;
        private UIControls.NumericInput txtCodProveedor;
        private System.Windows.Forms.Label lblPnCodigoProv;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnNombreProveedor;
        private UIControls.TextInput txtNombreProveedor;
        private System.Windows.Forms.Label lblPnNombreProv;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel pnDireccion;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.Label lblPnDescripcion;
        private System.Windows.Forms.Panel pnIdentificacion;
        private UIControls.NumericInput txtNumComprobante;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel pnAside;
        private UIControls.Buttons.ItemAsideSmall btnCerrar;
        private UIControls.Buttons.ItemAsideSmall btnLimpiar;
        private UIControls.Buttons.ItemAsideSmall btnImprimir;
        private UIControls.Buttons.ItemAsideSmall btnGuardar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombreProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn colStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrecio;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTotal;
    }
}