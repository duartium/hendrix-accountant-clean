namespace HendrixAccountant.Forms
{
    partial class frmVentas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVentas));
            this.pnAside = new System.Windows.Forms.Panel();
            this.btnCerrar = new HendrixAccountant.UIControls.Buttons.ItemAsideSmall();
            this.btnLimpiar = new HendrixAccountant.UIControls.Buttons.ItemAsideSmall();
            this.btnImprimir = new HendrixAccountant.UIControls.Buttons.ItemAsideSmall();
            this.btnConsultar = new HendrixAccountant.UIControls.Buttons.ItemAsideSmall();
            this.tabControlVentas = new System.Windows.Forms.TabControl();
            this.tpGeneral = new System.Windows.Forms.TabPage();
            this.dgvVentaGeneral = new System.Windows.Forms.DataGridView();
            this.gpDatosVenta = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cboEstadoComprobante = new System.Windows.Forms.ComboBox();
            this.dtpFechaDesde = new System.Windows.Forms.DateTimePicker();
            this.lblFechaDesde = new System.Windows.Forms.Label();
            this.lblHasta = new System.Windows.Forms.Label();
            this.dtpFechaHasta = new System.Windows.Forms.DateTimePicker();
            this.gbUsuario = new System.Windows.Forms.GroupBox();
            this.lblCodUsuario = new System.Windows.Forms.Label();
            this.txtNombreUsuario = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtCodUsuario = new System.Windows.Forms.TextBox();
            this.btnBuscarUsuario = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtIdentCliente = new HendrixAccountant.UIControls.NumericInput();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombresCliente = new System.Windows.Forms.TextBox();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tpCIndividual = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtNumSecuencial = new HendrixAccountant.UIControls.NumericInput();
            this.label3 = new System.Windows.Forms.Label();
            this.gbDetalleVentaFactInd = new System.Windows.Forms.GroupBox();
            this.dgvComprobanteInd = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbFromaPago = new System.Windows.Forms.GroupBox();
            this.rbImpSistema = new System.Windows.Forms.RadioButton();
            this.rbImpSRI = new System.Windows.Forms.RadioButton();
            this.lblTitleCliente = new System.Windows.Forms.Label();
            this.lblNombresCliente = new System.Windows.Forms.Label();
            this.colSecuencial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFechaEmision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFormaPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSubtotal0 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSubtotal12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSubtotalGral = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnAside.SuspendLayout();
            this.tabControlVentas.SuspendLayout();
            this.tpGeneral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentaGeneral)).BeginInit();
            this.gpDatosVenta.SuspendLayout();
            this.gbUsuario.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tpCIndividual.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.gbDetalleVentaFactInd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComprobanteInd)).BeginInit();
            this.gbFromaPago.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnAside
            // 
            this.pnAside.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(46)))), ((int)(((byte)(140)))));
            this.pnAside.Controls.Add(this.btnCerrar);
            this.pnAside.Controls.Add(this.btnLimpiar);
            this.pnAside.Controls.Add(this.btnImprimir);
            this.pnAside.Controls.Add(this.btnConsultar);
            this.pnAside.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnAside.Location = new System.Drawing.Point(857, 0);
            this.pnAside.Name = "pnAside";
            this.pnAside.Size = new System.Drawing.Size(127, 606);
            this.pnAside.TabIndex = 9;
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
            this.btnCerrar.Location = new System.Drawing.Point(0, 547);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnCerrar.Size = new System.Drawing.Size(127, 35);
            this.btnCerrar.TabIndex = 16;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
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
            this.btnLimpiar.Location = new System.Drawing.Point(0, 506);
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
            this.btnImprimir.Location = new System.Drawing.Point(0, 75);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnImprimir.Size = new System.Drawing.Size(127, 40);
            this.btnImprimir.TabIndex = 5;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = false;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
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
            this.btnConsultar.Location = new System.Drawing.Point(0, 30);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Padding = new System.Windows.Forms.Padding(12, 0, 0, 0);
            this.btnConsultar.Size = new System.Drawing.Size(127, 40);
            this.btnConsultar.TabIndex = 4;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // tabControlVentas
            // 
            this.tabControlVentas.Controls.Add(this.tpGeneral);
            this.tabControlVentas.Controls.Add(this.tpCIndividual);
            this.tabControlVentas.ItemSize = new System.Drawing.Size(49, 30);
            this.tabControlVentas.Location = new System.Drawing.Point(13, 12);
            this.tabControlVentas.Name = "tabControlVentas";
            this.tabControlVentas.SelectedIndex = 0;
            this.tabControlVentas.Size = new System.Drawing.Size(838, 573);
            this.tabControlVentas.TabIndex = 11;
            this.tabControlVentas.SelectedIndexChanged += new System.EventHandler(this.tabControlVentas_SelectedIndexChanged);
            this.tabControlVentas.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControlVentas_Selected);
            // 
            // tpGeneral
            // 
            this.tpGeneral.Controls.Add(this.dgvVentaGeneral);
            this.tpGeneral.Controls.Add(this.gpDatosVenta);
            this.tpGeneral.Location = new System.Drawing.Point(4, 34);
            this.tpGeneral.Name = "tpGeneral";
            this.tpGeneral.Padding = new System.Windows.Forms.Padding(3);
            this.tpGeneral.Size = new System.Drawing.Size(830, 535);
            this.tpGeneral.TabIndex = 0;
            this.tpGeneral.Text = "GENERAL";
            this.tpGeneral.UseVisualStyleBackColor = true;
            // 
            // dgvVentaGeneral
            // 
            this.dgvVentaGeneral.AllowUserToAddRows = false;
            this.dgvVentaGeneral.AllowUserToResizeRows = false;
            this.dgvVentaGeneral.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvVentaGeneral.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvVentaGeneral.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(46)))), ((int)(((byte)(140)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvVentaGeneral.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvVentaGeneral.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvVentaGeneral.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSecuencial,
            this.colFechaEmision,
            this.colCliente,
            this.colFormaPago,
            this.colTotal,
            this.colSubtotal0,
            this.colSubtotal12,
            this.colSubtotalGral,
            this.colUsuario});
            this.dgvVentaGeneral.EnableHeadersVisualStyles = false;
            this.dgvVentaGeneral.Location = new System.Drawing.Point(9, 189);
            this.dgvVentaGeneral.Name = "dgvVentaGeneral";
            this.dgvVentaGeneral.RowHeadersVisible = false;
            this.dgvVentaGeneral.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvVentaGeneral.Size = new System.Drawing.Size(805, 340);
            this.dgvVentaGeneral.TabIndex = 12;
            // 
            // gpDatosVenta
            // 
            this.gpDatosVenta.Controls.Add(this.label7);
            this.gpDatosVenta.Controls.Add(this.cboEstadoComprobante);
            this.gpDatosVenta.Controls.Add(this.dtpFechaDesde);
            this.gpDatosVenta.Controls.Add(this.lblFechaDesde);
            this.gpDatosVenta.Controls.Add(this.lblHasta);
            this.gpDatosVenta.Controls.Add(this.dtpFechaHasta);
            this.gpDatosVenta.Controls.Add(this.gbUsuario);
            this.gpDatosVenta.Controls.Add(this.groupBox1);
            this.gpDatosVenta.Location = new System.Drawing.Point(8, 6);
            this.gpDatosVenta.Name = "gpDatosVenta";
            this.gpDatosVenta.Size = new System.Drawing.Size(806, 170);
            this.gpDatosVenta.TabIndex = 11;
            this.gpDatosVenta.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label7.Location = new System.Drawing.Point(248, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 15);
            this.label7.TabIndex = 80;
            this.label7.Text = "Estado";
            // 
            // cboEstadoComprobante
            // 
            this.cboEstadoComprobante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstadoComprobante.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboEstadoComprobante.FormattingEnabled = true;
            this.cboEstadoComprobante.Items.AddRange(new object[] {
            "A",
            "B",
            "C"});
            this.cboEstadoComprobante.Location = new System.Drawing.Point(251, 36);
            this.cboEstadoComprobante.Name = "cboEstadoComprobante";
            this.cboEstadoComprobante.Size = new System.Drawing.Size(205, 24);
            this.cboEstadoComprobante.TabIndex = 79;
            // 
            // dtpFechaDesde
            // 
            this.dtpFechaDesde.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaDesde.Location = new System.Drawing.Point(10, 38);
            this.dtpFechaDesde.Name = "dtpFechaDesde";
            this.dtpFechaDesde.Size = new System.Drawing.Size(104, 22);
            this.dtpFechaDesde.TabIndex = 29;
            // 
            // lblFechaDesde
            // 
            this.lblFechaDesde.AutoSize = true;
            this.lblFechaDesde.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaDesde.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblFechaDesde.Location = new System.Drawing.Point(8, 22);
            this.lblFechaDesde.Name = "lblFechaDesde";
            this.lblFechaDesde.Size = new System.Drawing.Size(79, 15);
            this.lblFechaDesde.TabIndex = 30;
            this.lblFechaDesde.Text = "Fecha desde";
            // 
            // lblHasta
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHasta.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblHasta.Location = new System.Drawing.Point(126, 21);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(75, 15);
            this.lblHasta.TabIndex = 32;
            this.lblHasta.Text = "Fecha hasta";
            // 
            // dtpFechaHasta
            // 
            this.dtpFechaHasta.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaHasta.Location = new System.Drawing.Point(129, 38);
            this.dtpFechaHasta.Name = "dtpFechaHasta";
            this.dtpFechaHasta.Size = new System.Drawing.Size(104, 22);
            this.dtpFechaHasta.TabIndex = 31;
            // 
            // gbUsuario
            // 
            this.gbUsuario.Controls.Add(this.lblCodUsuario);
            this.gbUsuario.Controls.Add(this.txtNombreUsuario);
            this.gbUsuario.Controls.Add(this.lblUsuario);
            this.gbUsuario.Controls.Add(this.txtCodUsuario);
            this.gbUsuario.Controls.Add(this.btnBuscarUsuario);
            this.gbUsuario.ForeColor = System.Drawing.SystemColors.GrayText;
            this.gbUsuario.Location = new System.Drawing.Point(464, 75);
            this.gbUsuario.Name = "gbUsuario";
            this.gbUsuario.Size = new System.Drawing.Size(231, 81);
            this.gbUsuario.TabIndex = 28;
            this.gbUsuario.TabStop = false;
            this.gbUsuario.Text = "Usuario";
            this.gbUsuario.Visible = false;
            // 
            // lblCodUsuario
            // 
            this.lblCodUsuario.AutoSize = true;
            this.lblCodUsuario.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodUsuario.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblCodUsuario.Location = new System.Drawing.Point(6, 26);
            this.lblCodUsuario.Name = "lblCodUsuario";
            this.lblCodUsuario.Size = new System.Drawing.Size(47, 15);
            this.lblCodUsuario.TabIndex = 6;
            this.lblCodUsuario.Text = "Código";
            // 
            // txtNombreUsuario
            // 
            this.txtNombreUsuario.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreUsuario.Location = new System.Drawing.Point(71, 44);
            this.txtNombreUsuario.MaxLength = 20;
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.Size = new System.Drawing.Size(103, 22);
            this.txtNombreUsuario.TabIndex = 26;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblUsuario.Location = new System.Drawing.Point(68, 26);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(114, 15);
            this.lblUsuario.TabIndex = 7;
            this.lblUsuario.Text = "Nombre de usuario";
            // 
            // txtCodUsuario
            // 
            this.txtCodUsuario.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodUsuario.Location = new System.Drawing.Point(8, 44);
            this.txtCodUsuario.MaxLength = 10;
            this.txtCodUsuario.Name = "txtCodUsuario";
            this.txtCodUsuario.Size = new System.Drawing.Size(57, 22);
            this.txtCodUsuario.TabIndex = 19;
            // 
            // btnBuscarUsuario
            // 
            this.btnBuscarUsuario.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarUsuario.Location = new System.Drawing.Point(178, 43);
            this.btnBuscarUsuario.Name = "btnBuscarUsuario";
            this.btnBuscarUsuario.Size = new System.Drawing.Size(42, 23);
            this.btnBuscarUsuario.TabIndex = 20;
            this.btnBuscarUsuario.Text = "...";
            this.btnBuscarUsuario.UseVisualStyleBackColor = true;
            this.btnBuscarUsuario.Click += new System.EventHandler(this.btnBuscarUsuario_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtIdentCliente);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtNombresCliente);
            this.groupBox1.Controls.Add(this.btnBuscarCliente);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.groupBox1.Location = new System.Drawing.Point(4, 75);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(452, 81);
            this.groupBox1.TabIndex = 27;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cliente";
            // 
            // txtIdentCliente
            // 
            this.txtIdentCliente.Font = new System.Drawing.Font("Arial", 10F);
            this.txtIdentCliente.Location = new System.Drawing.Point(7, 44);
            this.txtIdentCliente.MaxLength = 13;
            this.txtIdentCliente.Name = "txtIdentCliente";
            this.txtIdentCliente.Size = new System.Drawing.Size(103, 23);
            this.txtIdentCliente.TabIndex = 33;
            this.txtIdentCliente.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtIdentCliente_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Identificación";
            // 
            // txtNombresCliente
            // 
            this.txtNombresCliente.Enabled = false;
            this.txtNombresCliente.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombresCliente.Location = new System.Drawing.Point(116, 45);
            this.txtNombresCliente.MaxLength = 100;
            this.txtNombresCliente.Name = "txtNombresCliente";
            this.txtNombresCliente.Size = new System.Drawing.Size(282, 22);
            this.txtNombresCliente.TabIndex = 2;
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarCliente.Location = new System.Drawing.Point(401, 44);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(42, 24);
            this.btnBuscarCliente.TabIndex = 3;
            this.btnBuscarCliente.Text = "...";
            this.btnBuscarCliente.UseVisualStyleBackColor = true;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label2.Location = new System.Drawing.Point(114, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nombres y apellidos";
            // 
            // tpCIndividual
            // 
            this.tpCIndividual.Controls.Add(this.gbDetalleVentaFactInd);
            this.tpCIndividual.Controls.Add(this.groupBox4);
            this.tpCIndividual.Location = new System.Drawing.Point(4, 34);
            this.tpCIndividual.Name = "tpCIndividual";
            this.tpCIndividual.Padding = new System.Windows.Forms.Padding(3);
            this.tpCIndividual.Size = new System.Drawing.Size(654, 535);
            this.tpCIndividual.TabIndex = 1;
            this.tpCIndividual.Text = "FACTURA INDIVIDUAL";
            this.tpCIndividual.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblNombresCliente);
            this.groupBox4.Controls.Add(this.lblTitleCliente);
            this.groupBox4.Controls.Add(this.gbFromaPago);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.txtNumSecuencial);
            this.groupBox4.Location = new System.Drawing.Point(8, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(730, 78);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            // 
            // txtNumSecuencial
            // 
            this.txtNumSecuencial.Font = new System.Drawing.Font("Arial", 10F);
            this.txtNumSecuencial.Location = new System.Drawing.Point(9, 37);
            this.txtNumSecuencial.MaxLength = 13;
            this.txtNumSecuencial.Name = "txtNumSecuencial";
            this.txtNumSecuencial.Size = new System.Drawing.Size(159, 23);
            this.txtNumSecuencial.TabIndex = 20;
            this.txtNumSecuencial.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNumSecuencial_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label3.Location = new System.Drawing.Point(6, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 15);
            this.label3.TabIndex = 31;
            this.label3.Text = "Factura Nº";
            // 
            // gbDetalleVentaFactInd
            // 
            this.gbDetalleVentaFactInd.Controls.Add(this.dgvComprobanteInd);
            this.gbDetalleVentaFactInd.ForeColor = System.Drawing.SystemColors.GrayText;
            this.gbDetalleVentaFactInd.Location = new System.Drawing.Point(8, 94);
            this.gbDetalleVentaFactInd.Name = "gbDetalleVentaFactInd";
            this.gbDetalleVentaFactInd.Size = new System.Drawing.Size(730, 435);
            this.gbDetalleVentaFactInd.TabIndex = 14;
            this.gbDetalleVentaFactInd.TabStop = false;
            this.gbDetalleVentaFactInd.Text = "Detalle de Venta";
            // 
            // dgvComprobanteInd
            // 
            this.dgvComprobanteInd.AllowUserToAddRows = false;
            this.dgvComprobanteInd.AllowUserToResizeRows = false;
            this.dgvComprobanteInd.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvComprobanteInd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvComprobanteInd.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(46)))), ((int)(((byte)(140)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvComprobanteInd.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvComprobanteInd.ColumnHeadersHeight = 27;
            this.dgvComprobanteInd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvComprobanteInd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dgvComprobanteInd.EnableHeadersVisualStyles = false;
            this.dgvComprobanteInd.Location = new System.Drawing.Point(11, 23);
            this.dgvComprobanteInd.Name = "dgvComprobanteInd";
            this.dgvComprobanteInd.RowHeadersVisible = false;
            this.dgvComprobanteInd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvComprobanteInd.Size = new System.Drawing.Size(708, 393);
            this.dgvComprobanteInd.TabIndex = 33;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Cód. Prod.";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 80;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Nombre de producto";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 285;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewTextBoxColumn3.HeaderText = "Cantidad";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 80;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewTextBoxColumn4.HeaderText = "Precio";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 120;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle8.NullValue = "0";
            this.dataGridViewTextBoxColumn5.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewTextBoxColumn5.HeaderText = "Total";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 140;
            // 
            // gbFromaPago
            // 
            this.gbFromaPago.Controls.Add(this.rbImpSistema);
            this.gbFromaPago.Controls.Add(this.rbImpSRI);
            this.gbFromaPago.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFromaPago.ForeColor = System.Drawing.SystemColors.GrayText;
            this.gbFromaPago.Location = new System.Drawing.Point(183, 16);
            this.gbFromaPago.Name = "gbFromaPago";
            this.gbFromaPago.Size = new System.Drawing.Size(225, 50);
            this.gbFromaPago.TabIndex = 32;
            this.gbFromaPago.TabStop = false;
            this.gbFromaPago.Text = "Formato de impresión";
            // 
            // rbImpSistema
            // 
            this.rbImpSistema.AutoSize = true;
            this.rbImpSistema.ForeColor = System.Drawing.Color.Black;
            this.rbImpSistema.Location = new System.Drawing.Point(85, 22);
            this.rbImpSistema.Name = "rbImpSistema";
            this.rbImpSistema.Size = new System.Drawing.Size(73, 20);
            this.rbImpSistema.TabIndex = 23;
            this.rbImpSistema.Text = "SISTEMA";
            this.rbImpSistema.UseVisualStyleBackColor = true;
            // 
            // rbImpSRI
            // 
            this.rbImpSRI.AutoSize = true;
            this.rbImpSRI.Checked = true;
            this.rbImpSRI.ForeColor = System.Drawing.Color.Black;
            this.rbImpSRI.Location = new System.Drawing.Point(11, 21);
            this.rbImpSRI.Name = "rbImpSRI";
            this.rbImpSRI.Size = new System.Drawing.Size(44, 20);
            this.rbImpSRI.TabIndex = 22;
            this.rbImpSRI.TabStop = true;
            this.rbImpSRI.Text = "SRI";
            this.rbImpSRI.UseVisualStyleBackColor = true;
            // 
            // lblTitleCliente
            // 
            this.lblTitleCliente.AutoSize = true;
            this.lblTitleCliente.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleCliente.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblTitleCliente.Location = new System.Drawing.Point(423, 21);
            this.lblTitleCliente.Name = "lblTitleCliente";
            this.lblTitleCliente.Size = new System.Drawing.Size(46, 15);
            this.lblTitleCliente.TabIndex = 33;
            this.lblTitleCliente.Text = "Cliente";
            this.lblTitleCliente.Visible = false;
            // 
            // lblNombresCliente
            // 
            this.lblNombresCliente.AutoSize = true;
            this.lblNombresCliente.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombresCliente.ForeColor = System.Drawing.Color.Black;
            this.lblNombresCliente.Location = new System.Drawing.Point(423, 39);
            this.lblNombresCliente.Name = "lblNombresCliente";
            this.lblNombresCliente.Size = new System.Drawing.Size(48, 16);
            this.lblNombresCliente.TabIndex = 34;
            this.lblNombresCliente.Text = "Cliente";
            this.lblNombresCliente.Visible = false;
            // 
            // colSecuencial
            // 
            this.colSecuencial.DataPropertyName = "secuencial";
            this.colSecuencial.HeaderText = "Secuencial";
            this.colSecuencial.Name = "colSecuencial";
            this.colSecuencial.ReadOnly = true;
            this.colSecuencial.Width = 80;
            // 
            // colFechaEmision
            // 
            this.colFechaEmision.DataPropertyName = "fechaEmision";
            this.colFechaEmision.HeaderText = "Fecha de emisión";
            this.colFechaEmision.Name = "colFechaEmision";
            this.colFechaEmision.ReadOnly = true;
            this.colFechaEmision.Width = 130;
            // 
            // colCliente
            // 
            this.colCliente.DataPropertyName = "nombresCliente";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.colCliente.DefaultCellStyle = dataGridViewCellStyle2;
            this.colCliente.HeaderText = "Nombres de cliente";
            this.colCliente.Name = "colCliente";
            this.colCliente.ReadOnly = true;
            this.colCliente.Width = 250;
            // 
            // colFormaPago
            // 
            this.colFormaPago.DataPropertyName = "formaPago";
            this.colFormaPago.HeaderText = "Forma Pago";
            this.colFormaPago.Name = "colFormaPago";
            this.colFormaPago.ReadOnly = true;
            // 
            // colTotal
            // 
            this.colTotal.DataPropertyName = "total";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.NullValue = "0";
            this.colTotal.DefaultCellStyle = dataGridViewCellStyle3;
            this.colTotal.HeaderText = "Total";
            this.colTotal.Name = "colTotal";
            this.colTotal.ReadOnly = true;
            // 
            // colSubtotal0
            // 
            this.colSubtotal0.DataPropertyName = "subtotal0";
            this.colSubtotal0.HeaderText = "Subtotal 0";
            this.colSubtotal0.Name = "colSubtotal0";
            this.colSubtotal0.ReadOnly = true;
            // 
            // colSubtotal12
            // 
            this.colSubtotal12.DataPropertyName = "subtotal12";
            this.colSubtotal12.HeaderText = "Subtotal 12";
            this.colSubtotal12.Name = "colSubtotal12";
            this.colSubtotal12.ReadOnly = true;
            // 
            // colSubtotalGral
            // 
            this.colSubtotalGral.DataPropertyName = "subtotal";
            this.colSubtotalGral.HeaderText = "Subtotal General";
            this.colSubtotalGral.Name = "colSubtotalGral";
            this.colSubtotalGral.ReadOnly = true;
            // 
            // colUsuario
            // 
            this.colUsuario.DataPropertyName = "usuarioCrea";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.colUsuario.DefaultCellStyle = dataGridViewCellStyle4;
            this.colUsuario.HeaderText = "Usuario";
            this.colUsuario.Name = "colUsuario";
            this.colUsuario.ReadOnly = true;
            this.colUsuario.Width = 85;
            // 
            // frmVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(984, 606);
            this.Controls.Add(this.tabControlVentas);
            this.Controls.Add(this.pnAside);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(5, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "CONSULTA DE VENTAS";
            this.Activated += new System.EventHandler(this.frmVentas_Activated);
            this.Load += new System.EventHandler(this.rptVentas_Load);
            this.pnAside.ResumeLayout(false);
            this.tabControlVentas.ResumeLayout(false);
            this.tpGeneral.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVentaGeneral)).EndInit();
            this.gpDatosVenta.ResumeLayout(false);
            this.gpDatosVenta.PerformLayout();
            this.gbUsuario.ResumeLayout(false);
            this.gbUsuario.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tpCIndividual.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.gbDetalleVentaFactInd.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvComprobanteInd)).EndInit();
            this.gbFromaPago.ResumeLayout(false);
            this.gbFromaPago.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnAside;
        private System.Windows.Forms.TabControl tabControlVentas;
        private System.Windows.Forms.TabPage tpGeneral;
        private System.Windows.Forms.GroupBox gpDatosVenta;
        private System.Windows.Forms.GroupBox gbUsuario;
        private System.Windows.Forms.Label lblCodUsuario;
        private System.Windows.Forms.TextBox txtNombreUsuario;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox txtCodUsuario;
        private System.Windows.Forms.Button btnBuscarUsuario;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombresCliente;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tpCIndividual;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DateTimePicker dtpFechaDesde;
        private System.Windows.Forms.Label lblFechaDesde;
        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.DateTimePicker dtpFechaHasta;
        private UIControls.Buttons.ItemAsideSmall btnConsultar;
        private UIControls.Buttons.ItemAsideSmall btnImprimir;
        private System.Windows.Forms.DataGridView dgvVentaGeneral;
        private UIControls.NumericInput txtIdentCliente;
        private UIControls.NumericInput txtNumSecuencial;
        private UIControls.Buttons.ItemAsideSmall btnCerrar;
        private UIControls.Buttons.ItemAsideSmall btnLimpiar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboEstadoComprobante;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gbDetalleVentaFactInd;
        private System.Windows.Forms.DataGridView dgvComprobanteInd;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.GroupBox gbFromaPago;
        private System.Windows.Forms.RadioButton rbImpSistema;
        private System.Windows.Forms.RadioButton rbImpSRI;
        private System.Windows.Forms.Label lblNombresCliente;
        private System.Windows.Forms.Label lblTitleCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSecuencial;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFechaEmision;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFormaPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSubtotal0;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSubtotal12;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSubtotalGral;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUsuario;
    }
}