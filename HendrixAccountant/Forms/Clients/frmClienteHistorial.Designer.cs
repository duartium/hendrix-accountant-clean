
namespace HendrixAccountant.Forms.Clients
{
    partial class frmClienteHistorial
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClienteHistorial));
            this.pnNombres = new System.Windows.Forms.Panel();
            this.txtNombresCliente = new HendrixAccountant.UIControls.TextInput();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pnIdentificacion = new System.Windows.Forms.Panel();
            this.txtIdentCliente = new HendrixAccountant.UIControls.NumericInput();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBuscar = new HendrixAccountant.UIControls.Buttons.ItemAsideSmall();
            this.dgvHistorialCliente = new System.Windows.Forms.DataGridView();
            this.cboTipoFechas = new System.Windows.Forms.ComboBox();
            this.lblNombresCliente = new System.Windows.Forms.Label();
            this.dgvProductoServicio = new System.Windows.Forms.DataGridView();
            this.colProductoServicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSecuencial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFechaEmision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colObservaciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnNombres.SuspendLayout();
            this.pnIdentificacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorialCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductoServicio)).BeginInit();
            this.SuspendLayout();
            // 
            // pnNombres
            // 
            this.pnNombres.BackColor = System.Drawing.SystemColors.Control;
            this.pnNombres.Controls.Add(this.txtNombresCliente);
            this.pnNombres.Controls.Add(this.label4);
            this.pnNombres.Location = new System.Drawing.Point(217, 38);
            this.pnNombres.Name = "pnNombres";
            this.pnNombres.Size = new System.Drawing.Size(352, 32);
            this.pnNombres.TabIndex = 22;
            // 
            // txtNombresCliente
            // 
            this.txtNombresCliente.BackColor = System.Drawing.SystemColors.Control;
            this.txtNombresCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombresCliente.Font = new System.Drawing.Font("Arial", 10F);
            this.txtNombresCliente.Location = new System.Drawing.Point(9, 7);
            this.txtNombresCliente.MaxLength = 100;
            this.txtNombresCliente.Name = "txtNombresCliente";
            this.txtNombresCliente.Size = new System.Drawing.Size(333, 16);
            this.txtNombresCliente.TabIndex = 0;
            this.txtNombresCliente.TextChanged += new System.EventHandler(this.txtNombresCliente_TextChanged);
            this.txtNombresCliente.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNombresCliente_KeyDown);
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(107)))), ((int)(((byte)(247)))));
            this.label4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label4.Location = new System.Drawing.Point(0, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(352, 2);
            this.label4.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label5.Location = new System.Drawing.Point(214, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(180, 15);
            this.label5.TabIndex = 23;
            this.label5.Text = "Nombres y apellidos del cliente";
            // 
            // pnIdentificacion
            // 
            this.pnIdentificacion.BackColor = System.Drawing.SystemColors.Control;
            this.pnIdentificacion.Controls.Add(this.txtIdentCliente);
            this.pnIdentificacion.Controls.Add(this.label7);
            this.pnIdentificacion.Location = new System.Drawing.Point(20, 38);
            this.pnIdentificacion.Name = "pnIdentificacion";
            this.pnIdentificacion.Size = new System.Drawing.Size(188, 32);
            this.pnIdentificacion.TabIndex = 20;
            // 
            // txtIdentCliente
            // 
            this.txtIdentCliente.BackColor = System.Drawing.SystemColors.Control;
            this.txtIdentCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIdentCliente.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdentCliente.Location = new System.Drawing.Point(8, 6);
            this.txtIdentCliente.MaxLength = 13;
            this.txtIdentCliente.Name = "txtIdentCliente";
            this.txtIdentCliente.Size = new System.Drawing.Size(166, 19);
            this.txtIdentCliente.TabIndex = 0;
            this.txtIdentCliente.TextChanged += new System.EventHandler(this.txtIdentCliente_TextChanged);
            this.txtIdentCliente.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtIdentCliente_KeyDown);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(107)))), ((int)(((byte)(247)))));
            this.label7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label7.Location = new System.Drawing.Point(0, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(188, 2);
            this.label7.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label3.Location = new System.Drawing.Point(17, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 15);
            this.label3.TabIndex = 21;
            this.label3.Text = "Identificación";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(184)))), ((int)(((byte)(39)))));
            this.btnBuscar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(184)))), ((int)(((byte)(39)))));
            this.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(184)))), ((int)(((byte)(45)))));
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(46)))), ((int)(((byte)(140)))));
            this.btnBuscar.Image = global::HendrixAccountant.Properties.Resources.searchBlue20;
            this.btnBuscar.Location = new System.Drawing.Point(830, 40);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(93, 32);
            this.btnBuscar.TabIndex = 24;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dgvHistorialCliente
            // 
            this.dgvHistorialCliente.AllowUserToAddRows = false;
            this.dgvHistorialCliente.AllowUserToDeleteRows = false;
            this.dgvHistorialCliente.AllowUserToResizeRows = false;
            this.dgvHistorialCliente.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvHistorialCliente.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvHistorialCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvHistorialCliente.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(46)))), ((int)(((byte)(140)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHistorialCliente.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvHistorialCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvHistorialCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSecuencial,
            this.colFechaEmision,
            this.colEstado,
            this.colTotal,
            this.colObservaciones});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvHistorialCliente.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvHistorialCliente.EnableHeadersVisualStyles = false;
            this.dgvHistorialCliente.Location = new System.Drawing.Point(19, 119);
            this.dgvHistorialCliente.Name = "dgvHistorialCliente";
            this.dgvHistorialCliente.ReadOnly = true;
            this.dgvHistorialCliente.RowHeadersVisible = false;
            this.dgvHistorialCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHistorialCliente.Size = new System.Drawing.Size(683, 449);
            this.dgvHistorialCliente.TabIndex = 25;
            this.dgvHistorialCliente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHistorialCliente_CellContentClick);
            this.dgvHistorialCliente.SelectionChanged += new System.EventHandler(this.dgvHistorialCliente_SelectionChanged);
            // 
            // cboTipoFechas
            // 
            this.cboTipoFechas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoFechas.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTipoFechas.FormattingEnabled = true;
            this.cboTipoFechas.Items.AddRange(new object[] {
            "ÚLTIMO MES",
            "ÚLTIMOS 3 MESES",
            "ÚLTIMOS 6 MESES",
            "ÚLTIMO AÑO",
            "TODO"});
            this.cboTipoFechas.Location = new System.Drawing.Point(596, 45);
            this.cboTipoFechas.Name = "cboTipoFechas";
            this.cboTipoFechas.Size = new System.Drawing.Size(205, 24);
            this.cboTipoFechas.TabIndex = 82;
            this.cboTipoFechas.SelectedIndexChanged += new System.EventHandler(this.cboTipoFechas_SelectedIndexChanged);
            // 
            // lblNombresCliente
            // 
            this.lblNombresCliente.AutoSize = true;
            this.lblNombresCliente.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombresCliente.ForeColor = System.Drawing.Color.Black;
            this.lblNombresCliente.Location = new System.Drawing.Point(17, 94);
            this.lblNombresCliente.Name = "lblNombresCliente";
            this.lblNombresCliente.Size = new System.Drawing.Size(64, 15);
            this.lblNombresCliente.TabIndex = 83;
            this.lblNombresCliente.Text = "CLIENTE: ";
            this.lblNombresCliente.Visible = false;
            // 
            // dgvProductoServicio
            // 
            this.dgvProductoServicio.AllowUserToAddRows = false;
            this.dgvProductoServicio.AllowUserToDeleteRows = false;
            this.dgvProductoServicio.AllowUserToResizeRows = false;
            this.dgvProductoServicio.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvProductoServicio.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvProductoServicio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProductoServicio.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(46)))), ((int)(((byte)(140)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductoServicio.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvProductoServicio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvProductoServicio.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colProductoServicio});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductoServicio.DefaultCellStyle = dataGridViewCellStyle7;
            this.dgvProductoServicio.EnableHeadersVisualStyles = false;
            this.dgvProductoServicio.Location = new System.Drawing.Point(710, 141);
            this.dgvProductoServicio.Name = "dgvProductoServicio";
            this.dgvProductoServicio.ReadOnly = true;
            this.dgvProductoServicio.RowHeadersVisible = false;
            this.dgvProductoServicio.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductoServicio.Size = new System.Drawing.Size(307, 427);
            this.dgvProductoServicio.TabIndex = 85;
            // 
            // colProductoServicio
            // 
            this.colProductoServicio.DataPropertyName = "productoServicio";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.colProductoServicio.DefaultCellStyle = dataGridViewCellStyle6;
            this.colProductoServicio.HeaderText = "Producto/Servicio";
            this.colProductoServicio.Name = "colProductoServicio";
            this.colProductoServicio.ReadOnly = true;
            this.colProductoServicio.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colProductoServicio.Width = 300;
            // 
            // colSecuencial
            // 
            this.colSecuencial.DataPropertyName = "secuencial";
            this.colSecuencial.HeaderText = "Nº Factura";
            this.colSecuencial.Name = "colSecuencial";
            this.colSecuencial.ReadOnly = true;
            this.colSecuencial.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colSecuencial.Width = 80;
            // 
            // colFechaEmision
            // 
            this.colFechaEmision.DataPropertyName = "fechaEmision";
            this.colFechaEmision.HeaderText = "Fecha de venta";
            this.colFechaEmision.Name = "colFechaEmision";
            this.colFechaEmision.ReadOnly = true;
            this.colFechaEmision.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colFechaEmision.Width = 130;
            // 
            // colEstado
            // 
            this.colEstado.DataPropertyName = "estado";
            this.colEstado.HeaderText = "Estado";
            this.colEstado.Name = "colEstado";
            this.colEstado.ReadOnly = true;
            this.colEstado.Width = 80;
            // 
            // colTotal
            // 
            this.colTotal.DataPropertyName = "total";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.NullValue = "0";
            this.colTotal.DefaultCellStyle = dataGridViewCellStyle2;
            this.colTotal.HeaderText = "Total";
            this.colTotal.Name = "colTotal";
            this.colTotal.ReadOnly = true;
            this.colTotal.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colTotal.Width = 120;
            // 
            // colObservaciones
            // 
            this.colObservaciones.DataPropertyName = "observaciones";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.colObservaciones.DefaultCellStyle = dataGridViewCellStyle3;
            this.colObservaciones.HeaderText = "Nota/Observaciones";
            this.colObservaciones.Name = "colObservaciones";
            this.colObservaciones.ReadOnly = true;
            this.colObservaciones.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colObservaciones.Width = 270;
            // 
            // frmClienteHistorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1035, 606);
            this.Controls.Add(this.dgvProductoServicio);
            this.Controls.Add(this.lblNombresCliente);
            this.Controls.Add(this.cboTipoFechas);
            this.Controls.Add(this.dgvHistorialCliente);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.pnNombres);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.pnIdentificacion);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(5, 5);
            this.Name = "frmClienteHistorial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "HISTORIAL DE CLIENTE";
            this.Load += new System.EventHandler(this.frmClienteHistorial_Load);
            this.pnNombres.ResumeLayout(false);
            this.pnNombres.PerformLayout();
            this.pnIdentificacion.ResumeLayout(false);
            this.pnIdentificacion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorialCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductoServicio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnNombres;
        private UIControls.TextInput txtNombresCliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel pnIdentificacion;
        private UIControls.NumericInput txtIdentCliente;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private UIControls.Buttons.ItemAsideSmall btnBuscar;
        private System.Windows.Forms.DataGridView dgvHistorialCliente;
        private System.Windows.Forms.ComboBox cboTipoFechas;
        private System.Windows.Forms.Label lblNombresCliente;
        private System.Windows.Forms.DataGridView dgvProductoServicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProductoServicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSecuencial;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFechaEmision;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colObservaciones;
    }
}