
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.colSecuencial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFechaEmision = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cboTipoFechas = new System.Windows.Forms.ComboBox();
            this.pnNombres.SuspendLayout();
            this.pnIdentificacion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistorialCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // pnNombres
            // 
            this.pnNombres.BackColor = System.Drawing.SystemColors.Control;
            this.pnNombres.Controls.Add(this.txtNombresCliente);
            this.pnNombres.Controls.Add(this.label4);
            this.pnNombres.Location = new System.Drawing.Point(227, 42);
            this.pnNombres.Name = "pnNombres";
            this.pnNombres.Size = new System.Drawing.Size(352, 32);
            this.pnNombres.TabIndex = 22;
            // 
            // txtNombresCliente
            // 
            this.txtNombresCliente.BackColor = System.Drawing.SystemColors.Control;
            this.txtNombresCliente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombresCliente.Enabled = false;
            this.txtNombresCliente.Font = new System.Drawing.Font("Arial", 10F);
            this.txtNombresCliente.Location = new System.Drawing.Point(9, 7);
            this.txtNombresCliente.MaxLength = 100;
            this.txtNombresCliente.Name = "txtNombresCliente";
            this.txtNombresCliente.Size = new System.Drawing.Size(333, 16);
            this.txtNombresCliente.TabIndex = 0;
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
            this.label5.Location = new System.Drawing.Point(224, 26);
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
            this.pnIdentificacion.Location = new System.Drawing.Point(30, 42);
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
            this.label3.Location = new System.Drawing.Point(27, 26);
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
            this.btnBuscar.Location = new System.Drawing.Point(840, 44);
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
            this.dgvHistorialCliente.AllowUserToResizeRows = false;
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
            this.colCliente,
            this.colTotal,
            this.colUsuario});
            this.dgvHistorialCliente.EnableHeadersVisualStyles = false;
            this.dgvHistorialCliente.Location = new System.Drawing.Point(30, 96);
            this.dgvHistorialCliente.Name = "dgvHistorialCliente";
            this.dgvHistorialCliente.RowHeadersVisible = false;
            this.dgvHistorialCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvHistorialCliente.Size = new System.Drawing.Size(903, 476);
            this.dgvHistorialCliente.TabIndex = 25;
            // 
            // colSecuencial
            // 
            this.colSecuencial.DataPropertyName = "secuencial";
            this.colSecuencial.HeaderText = "Número";
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
            this.colCliente.Width = 300;
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
            this.colTotal.Width = 120;
            // 
            // colUsuario
            // 
            this.colUsuario.DataPropertyName = "usuarioCrea";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.colUsuario.DefaultCellStyle = dataGridViewCellStyle4;
            this.colUsuario.HeaderText = "Nota/Observaciones";
            this.colUsuario.Name = "colUsuario";
            this.colUsuario.ReadOnly = true;
            this.colUsuario.Width = 270;
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
            this.cboTipoFechas.Location = new System.Drawing.Point(606, 49);
            this.cboTipoFechas.Name = "cboTipoFechas";
            this.cboTipoFechas.Size = new System.Drawing.Size(205, 24);
            this.cboTipoFechas.TabIndex = 82;
            // 
            // frmClienteHistorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(972, 606);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn colSecuencial;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFechaEmision;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUsuario;
    }
}