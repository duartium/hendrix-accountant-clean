namespace HendrixAccountant
{
    partial class frmPuntoVenta
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPuntoVenta));
            this.gpDatosVenta = new System.Windows.Forms.GroupBox();
            this.lblFechaEmision = new System.Windows.Forms.Label();
            this.dtpFechaEmision = new System.Windows.Forms.DateTimePicker();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.pnMontosVenta = new System.Windows.Forms.Panel();
            this.pnAside2 = new System.Windows.Forms.Panel();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.lblDivisor = new System.Windows.Forms.Label();
            this.pnAside = new System.Windows.Forms.Panel();
            this.txtValorIva = new System.Windows.Forms.TextBox();
            this.txtValorDscto = new System.Windows.Forms.TextBox();
            this.txtValorSubtotal = new System.Windows.Forms.TextBox();
            this.txtTotalPagar = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblDescuento = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.statusPOS = new System.Windows.Forms.StatusStrip();
            this.lblInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblEstadoProceso = new System.Windows.Forms.ToolStripStatusLabel();
            this.dgvPuntoVenta = new System.Windows.Forms.DataGridView();
            this.colCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDireccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.pnIdentificacion = new System.Windows.Forms.Panel();
            this.txtIdentCliente = new HendrixAccountant.UIControls.NumericInput();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pnNombres = new System.Windows.Forms.Panel();
            this.txtNombresCliente = new HendrixAccountant.UIControls.TextInput();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pnDireccion = new System.Windows.Forms.Panel();
            this.txtDireccionCliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.gpDatosVenta.SuspendLayout();
            this.pnMontosVenta.SuspendLayout();
            this.pnAside2.SuspendLayout();
            this.pnAside.SuspendLayout();
            this.statusPOS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPuntoVenta)).BeginInit();
            this.pnIdentificacion.SuspendLayout();
            this.pnNombres.SuspendLayout();
            this.pnDireccion.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpDatosVenta
            // 
            this.gpDatosVenta.Controls.Add(this.pnDireccion);
            this.gpDatosVenta.Controls.Add(this.label8);
            this.gpDatosVenta.Controls.Add(this.pnNombres);
            this.gpDatosVenta.Controls.Add(this.label5);
            this.gpDatosVenta.Controls.Add(this.pnIdentificacion);
            this.gpDatosVenta.Controls.Add(this.label3);
            this.gpDatosVenta.Controls.Add(this.lblFechaEmision);
            this.gpDatosVenta.Controls.Add(this.dtpFechaEmision);
            this.gpDatosVenta.Controls.Add(this.btnBuscarCliente);
            this.gpDatosVenta.Location = new System.Drawing.Point(8, 11);
            this.gpDatosVenta.Name = "gpDatosVenta";
            this.gpDatosVenta.Size = new System.Drawing.Size(684, 182);
            this.gpDatosVenta.TabIndex = 0;
            this.gpDatosVenta.TabStop = false;
            // 
            // lblFechaEmision
            // 
            this.lblFechaEmision.AutoSize = true;
            this.lblFechaEmision.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaEmision.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblFechaEmision.Location = new System.Drawing.Point(14, 23);
            this.lblFechaEmision.Name = "lblFechaEmision";
            this.lblFechaEmision.Size = new System.Drawing.Size(92, 15);
            this.lblFechaEmision.TabIndex = 12;
            this.lblFechaEmision.Text = "Fecha emisión:";
            // 
            // dtpFechaEmision
            // 
            this.dtpFechaEmision.CalendarFont = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaEmision.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaEmision.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaEmision.Location = new System.Drawing.Point(114, 20);
            this.dtpFechaEmision.MinDate = new System.DateTime(1800, 1, 1, 0, 0, 0, 0);
            this.dtpFechaEmision.Name = "dtpFechaEmision";
            this.dtpFechaEmision.Size = new System.Drawing.Size(113, 25);
            this.dtpFechaEmision.TabIndex = 11;
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarCliente.Location = new System.Drawing.Point(601, 68);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(48, 32);
            this.btnBuscarCliente.TabIndex = 3;
            this.btnBuscarCliente.Text = "...";
            this.btnBuscarCliente.UseVisualStyleBackColor = true;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // pnMontosVenta
            // 
            this.pnMontosVenta.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnMontosVenta.Controls.Add(this.pnAside2);
            this.pnMontosVenta.Controls.Add(this.pnAside);
            this.pnMontosVenta.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnMontosVenta.Location = new System.Drawing.Point(704, 0);
            this.pnMontosVenta.Name = "pnMontosVenta";
            this.pnMontosVenta.Size = new System.Drawing.Size(205, 559);
            this.pnMontosVenta.TabIndex = 1;
            // 
            // pnAside2
            // 
            this.pnAside2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(46)))), ((int)(((byte)(140)))));
            this.pnAside2.Controls.Add(this.btnGuardar);
            this.pnAside2.Controls.Add(this.lblDivisor);
            this.pnAside2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnAside2.Location = new System.Drawing.Point(0, 186);
            this.pnAside2.Name = "pnAside2";
            this.pnAside2.Size = new System.Drawing.Size(205, 373);
            this.pnAside2.TabIndex = 5;
            this.pnAside2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(184)))), ((int)(((byte)(39)))));
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(46)))), ((int)(((byte)(140)))));
            this.btnGuardar.Image = global::HendrixAccountant.Properties.Resources.saveBlue20;
            this.btnGuardar.Location = new System.Drawing.Point(0, 29);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnGuardar.Size = new System.Drawing.Size(204, 40);
            this.btnGuardar.TabIndex = 4;
            this.btnGuardar.Text = " Guardar";
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // lblDivisor
            // 
            this.lblDivisor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(184)))), ((int)(((byte)(39)))));
            this.lblDivisor.Location = new System.Drawing.Point(0, 4);
            this.lblDivisor.Name = "lblDivisor";
            this.lblDivisor.Size = new System.Drawing.Size(235, 3);
            this.lblDivisor.TabIndex = 7;
            // 
            // pnAside
            // 
            this.pnAside.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(46)))), ((int)(((byte)(140)))));
            this.pnAside.Controls.Add(this.txtValorIva);
            this.pnAside.Controls.Add(this.txtValorDscto);
            this.pnAside.Controls.Add(this.txtValorSubtotal);
            this.pnAside.Controls.Add(this.txtTotalPagar);
            this.pnAside.Controls.Add(this.label10);
            this.pnAside.Controls.Add(this.label6);
            this.pnAside.Controls.Add(this.lblDescuento);
            this.pnAside.Controls.Add(this.lblSubtotal);
            this.pnAside.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnAside.Location = new System.Drawing.Point(0, 0);
            this.pnAside.Name = "pnAside";
            this.pnAside.Size = new System.Drawing.Size(205, 186);
            this.pnAside.TabIndex = 4;
            // 
            // txtValorIva
            // 
            this.txtValorIva.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(46)))), ((int)(((byte)(140)))));
            this.txtValorIva.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtValorIva.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorIva.ForeColor = System.Drawing.SystemColors.Window;
            this.txtValorIva.Location = new System.Drawing.Point(101, 73);
            this.txtValorIva.MaxLength = 13;
            this.txtValorIva.Name = "txtValorIva";
            this.txtValorIva.ReadOnly = true;
            this.txtValorIva.Size = new System.Drawing.Size(86, 19);
            this.txtValorIva.TabIndex = 15;
            this.txtValorIva.Text = "0.00";
            this.txtValorIva.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtValorDscto
            // 
            this.txtValorDscto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(46)))), ((int)(((byte)(140)))));
            this.txtValorDscto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtValorDscto.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorDscto.ForeColor = System.Drawing.SystemColors.Window;
            this.txtValorDscto.Location = new System.Drawing.Point(101, 46);
            this.txtValorDscto.MaxLength = 13;
            this.txtValorDscto.Name = "txtValorDscto";
            this.txtValorDscto.ReadOnly = true;
            this.txtValorDscto.Size = new System.Drawing.Size(86, 19);
            this.txtValorDscto.TabIndex = 14;
            this.txtValorDscto.Text = "0.00";
            this.txtValorDscto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtValorSubtotal
            // 
            this.txtValorSubtotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(46)))), ((int)(((byte)(140)))));
            this.txtValorSubtotal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtValorSubtotal.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorSubtotal.ForeColor = System.Drawing.SystemColors.Window;
            this.txtValorSubtotal.Location = new System.Drawing.Point(101, 21);
            this.txtValorSubtotal.MaxLength = 13;
            this.txtValorSubtotal.Name = "txtValorSubtotal";
            this.txtValorSubtotal.ReadOnly = true;
            this.txtValorSubtotal.Size = new System.Drawing.Size(86, 19);
            this.txtValorSubtotal.TabIndex = 13;
            this.txtValorSubtotal.Text = "0.00";
            this.txtValorSubtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTotalPagar
            // 
            this.txtTotalPagar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTotalPagar.Enabled = false;
            this.txtTotalPagar.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalPagar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(46)))), ((int)(((byte)(140)))));
            this.txtTotalPagar.Location = new System.Drawing.Point(16, 143);
            this.txtTotalPagar.MaxLength = 13;
            this.txtTotalPagar.Name = "txtTotalPagar";
            this.txtTotalPagar.Size = new System.Drawing.Size(176, 37);
            this.txtTotalPagar.TabIndex = 13;
            this.txtTotalPagar.Text = "0.00";
            this.txtTotalPagar.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.Control;
            this.label10.Location = new System.Drawing.Point(13, 75);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(40, 18);
            this.label10.TabIndex = 8;
            this.label10.Text = "IVA: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(13, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 16);
            this.label6.TabIndex = 2;
            this.label6.Text = "TOTAL:";
            // 
            // lblDescuento
            // 
            this.lblDescuento.AutoSize = true;
            this.lblDescuento.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescuento.ForeColor = System.Drawing.SystemColors.Control;
            this.lblDescuento.Location = new System.Drawing.Point(13, 48);
            this.lblDescuento.Name = "lblDescuento";
            this.lblDescuento.Size = new System.Drawing.Size(91, 18);
            this.lblDescuento.TabIndex = 0;
            this.lblDescuento.Text = "Descuento: ";
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotal.ForeColor = System.Drawing.SystemColors.Control;
            this.lblSubtotal.Location = new System.Drawing.Point(13, 22);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(69, 18);
            this.lblSubtotal.TabIndex = 0;
            this.lblSubtotal.Text = "Subtotal:";
            // 
            // statusPOS
            // 
            this.statusPOS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblInfo,
            this.lblEstadoProceso});
            this.statusPOS.Location = new System.Drawing.Point(0, 537);
            this.statusPOS.Name = "statusPOS";
            this.statusPOS.Size = new System.Drawing.Size(704, 22);
            this.statusPOS.TabIndex = 4;
            this.statusPOS.Text = "statusStrip1";
            // 
            // lblInfo
            // 
            this.lblInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(46)))), ((int)(((byte)(140)))));
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(40, 17);
            this.lblInfo.Text = "INFO: ";
            this.lblInfo.Visible = false;
            // 
            // lblEstadoProceso
            // 
            this.lblEstadoProceso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(46)))), ((int)(((byte)(140)))));
            this.lblEstadoProceso.Name = "lblEstadoProceso";
            this.lblEstadoProceso.Size = new System.Drawing.Size(0, 17);
            // 
            // dgvPuntoVenta
            // 
            this.dgvPuntoVenta.AllowUserToAddRows = false;
            this.dgvPuntoVenta.AllowUserToResizeRows = false;
            this.dgvPuntoVenta.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvPuntoVenta.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPuntoVenta.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(46)))), ((int)(((byte)(140)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPuntoVenta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPuntoVenta.ColumnHeadersHeight = 27;
            this.dgvPuntoVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvPuntoVenta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCodigo,
            this.colNombre,
            this.colCantidad,
            this.colDireccion,
            this.colTotal});
            this.dgvPuntoVenta.EnableHeadersVisualStyles = false;
            this.dgvPuntoVenta.Location = new System.Drawing.Point(12, 250);
            this.dgvPuntoVenta.Name = "dgvPuntoVenta";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPuntoVenta.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvPuntoVenta.RowHeadersVisible = false;
            this.dgvPuntoVenta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPuntoVenta.Size = new System.Drawing.Size(680, 268);
            this.dgvPuntoVenta.TabIndex = 6;
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
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.colCantidad.DefaultCellStyle = dataGridViewCellStyle2;
            this.colCantidad.HeaderText = "Cantidad";
            this.colCantidad.Name = "colCantidad";
            this.colCantidad.ReadOnly = true;
            this.colCantidad.Width = 80;
            // 
            // colDireccion
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.colDireccion.DefaultCellStyle = dataGridViewCellStyle3;
            this.colDireccion.HeaderText = "Precio";
            this.colDireccion.Name = "colDireccion";
            this.colDireccion.ReadOnly = true;
            this.colDireccion.Width = 140;
            // 
            // colTotal
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.NullValue = "0";
            this.colTotal.DefaultCellStyle = dataGridViewCellStyle4;
            this.colTotal.HeaderText = "Total";
            this.colTotal.Name = "colTotal";
            this.colTotal.ReadOnly = true;
            this.colTotal.Width = 120;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.SystemColors.Window;
            this.btnEliminar.Image = global::HendrixAccountant.Properties.Resources.trashWhite20;
            this.btnEliminar.Location = new System.Drawing.Point(349, 213);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(90, 32);
            this.btnEliminar.TabIndex = 5;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            this.btnEliminar.MouseEnter += new System.EventHandler(this.btnEliminar_MouseEnter);
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
            this.btnAgregar.Location = new System.Drawing.Point(253, 213);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(90, 32);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = " Agregar";
            this.btnAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // pnIdentificacion
            // 
            this.pnIdentificacion.BackColor = System.Drawing.SystemColors.Control;
            this.pnIdentificacion.Controls.Add(this.txtIdentCliente);
            this.pnIdentificacion.Controls.Add(this.label7);
            this.pnIdentificacion.Location = new System.Drawing.Point(17, 68);
            this.pnIdentificacion.Name = "pnIdentificacion";
            this.pnIdentificacion.Size = new System.Drawing.Size(188, 32);
            this.pnIdentificacion.TabIndex = 15;
            // 
            // txtIdentCliente
            // 
            this.txtIdentCliente.BackColor = System.Drawing.SystemColors.Control;
            this.txtIdentCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIdentCliente.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdentCliente.Location = new System.Drawing.Point(1, 6);
            this.txtIdentCliente.MaxLength = 13;
            this.txtIdentCliente.Name = "txtIdentCliente";
            this.txtIdentCliente.Size = new System.Drawing.Size(185, 19);
            this.txtIdentCliente.TabIndex = 0;
            this.txtIdentCliente.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtIdentCliente_KeyDown);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(107)))), ((int)(((byte)(247)))));
            this.label7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label7.Location = new System.Drawing.Point(0, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(188, 3);
            this.label7.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label3.Location = new System.Drawing.Point(14, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 15);
            this.label3.TabIndex = 16;
            this.label3.Text = "Identificación";
            // 
            // pnNombres
            // 
            this.pnNombres.BackColor = System.Drawing.SystemColors.Control;
            this.pnNombres.Controls.Add(this.txtNombresCliente);
            this.pnNombres.Controls.Add(this.label4);
            this.pnNombres.Location = new System.Drawing.Point(214, 68);
            this.pnNombres.Name = "pnNombres";
            this.pnNombres.Size = new System.Drawing.Size(381, 32);
            this.pnNombres.TabIndex = 17;
            // 
            // txtNombresCliente
            // 
            this.txtNombresCliente.BackColor = System.Drawing.SystemColors.Control;
            this.txtNombresCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombresCliente.Font = new System.Drawing.Font("Arial", 10F);
            this.txtNombresCliente.Location = new System.Drawing.Point(1, 7);
            this.txtNombresCliente.MaxLength = 100;
            this.txtNombresCliente.Name = "txtNombresCliente";
            this.txtNombresCliente.ReadOnly = true;
            this.txtNombresCliente.Size = new System.Drawing.Size(378, 16);
            this.txtNombresCliente.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(107)))), ((int)(((byte)(247)))));
            this.label4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label4.Location = new System.Drawing.Point(0, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(381, 3);
            this.label4.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label5.Location = new System.Drawing.Point(211, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(180, 15);
            this.label5.TabIndex = 18;
            this.label5.Text = "Nombres y apellidos del cliente";
            // 
            // pnDireccion
            // 
            this.pnDireccion.BackColor = System.Drawing.SystemColors.Control;
            this.pnDireccion.Controls.Add(this.txtDireccionCliente);
            this.pnDireccion.Controls.Add(this.label1);
            this.pnDireccion.Location = new System.Drawing.Point(18, 124);
            this.pnDireccion.Name = "pnDireccion";
            this.pnDireccion.Size = new System.Drawing.Size(381, 32);
            this.pnDireccion.TabIndex = 19;
            // 
            // txtDireccionCliente
            // 
            this.txtDireccionCliente.BackColor = System.Drawing.SystemColors.Control;
            this.txtDireccionCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDireccionCliente.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccionCliente.Location = new System.Drawing.Point(2, 8);
            this.txtDireccionCliente.Name = "txtDireccionCliente";
            this.txtDireccionCliente.ReadOnly = true;
            this.txtDireccionCliente.Size = new System.Drawing.Size(377, 15);
            this.txtDireccionCliente.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(107)))), ((int)(((byte)(247)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Location = new System.Drawing.Point(0, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(381, 3);
            this.label1.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label8.Location = new System.Drawing.Point(15, 109);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 15);
            this.label8.TabIndex = 20;
            this.label8.Text = "Dirección";
            // 
            // frmPuntoVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(909, 559);
            this.Controls.Add(this.dgvPuntoVenta);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.statusPOS);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.pnMontosVenta);
            this.Controls.Add(this.gpDatosVenta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(5, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPuntoVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "NUEVA VENTA";
            this.Activated += new System.EventHandler(this.frmPuntoVenta_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPuntoVenta_FormClosing);
            this.Load += new System.EventHandler(this.frmPuntoVenta_Load);
            this.gpDatosVenta.ResumeLayout(false);
            this.gpDatosVenta.PerformLayout();
            this.pnMontosVenta.ResumeLayout(false);
            this.pnAside2.ResumeLayout(false);
            this.pnAside.ResumeLayout(false);
            this.pnAside.PerformLayout();
            this.statusPOS.ResumeLayout(false);
            this.statusPOS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPuntoVenta)).EndInit();
            this.pnIdentificacion.ResumeLayout(false);
            this.pnIdentificacion.PerformLayout();
            this.pnNombres.ResumeLayout(false);
            this.pnNombres.PerformLayout();
            this.pnDireccion.ResumeLayout(false);
            this.pnDireccion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gpDatosVenta;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.Panel pnMontosVenta;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label lblDescuento;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel pnAside;
        private System.Windows.Forms.Label lblDivisor;
        private System.Windows.Forms.Panel pnAside2;
        private System.Windows.Forms.Label lblFechaEmision;
        private System.Windows.Forms.DateTimePicker dtpFechaEmision;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.StatusStrip statusPOS;
        private System.Windows.Forms.ToolStripStatusLabel lblInfo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTotalPagar;
        private System.Windows.Forms.TextBox txtValorSubtotal;
        private System.Windows.Forms.TextBox txtValorIva;
        private System.Windows.Forms.TextBox txtValorDscto;
        private System.Windows.Forms.ToolStripStatusLabel lblEstadoProceso;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridView dgvPuntoVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDireccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotal;
        private System.Windows.Forms.Panel pnIdentificacion;
        private UIControls.NumericInput txtIdentCliente;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnNombres;
        private UIControls.TextInput txtNombresCliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel pnDireccion;
        private System.Windows.Forms.TextBox txtDireccionCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
    }
}