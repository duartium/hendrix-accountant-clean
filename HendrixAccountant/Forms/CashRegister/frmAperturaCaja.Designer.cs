namespace HendrixAccountant
{
    partial class frmAperturaCaja
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAperturaCaja));
            this.lblMontoTotal = new System.Windows.Forms.Label();
            this.gbxMontoTotal = new System.Windows.Forms.GroupBox();
            this.lblCash = new System.Windows.Forms.Label();
            this.dgvDineroCaja = new System.Windows.Forms.DataGridView();
            this.colDenominacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSubtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAperturar = new HendrixAccountant.UIControls.Buttons.ItemAsideSmall();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblFechaApertura = new System.Windows.Forms.Label();
            this.gbxMontoTotal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDineroCaja)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMontoTotal
            // 
            this.lblMontoTotal.AutoSize = true;
            this.lblMontoTotal.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontoTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(46)))), ((int)(((byte)(140)))));
            this.lblMontoTotal.Location = new System.Drawing.Point(74, 26);
            this.lblMontoTotal.Name = "lblMontoTotal";
            this.lblMontoTotal.Size = new System.Drawing.Size(93, 44);
            this.lblMontoTotal.TabIndex = 1;
            this.lblMontoTotal.Text = "0.00";
            // 
            // gbxMontoTotal
            // 
            this.gbxMontoTotal.Controls.Add(this.lblCash);
            this.gbxMontoTotal.Controls.Add(this.lblMontoTotal);
            this.gbxMontoTotal.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxMontoTotal.Location = new System.Drawing.Point(22, 419);
            this.gbxMontoTotal.Name = "gbxMontoTotal";
            this.gbxMontoTotal.Size = new System.Drawing.Size(320, 87);
            this.gbxMontoTotal.TabIndex = 2;
            this.gbxMontoTotal.TabStop = false;
            this.gbxMontoTotal.Text = "SALDO";
            // 
            // lblCash
            // 
            this.lblCash.AutoSize = true;
            this.lblCash.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCash.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(46)))), ((int)(((byte)(140)))));
            this.lblCash.Location = new System.Drawing.Point(29, 26);
            this.lblCash.Name = "lblCash";
            this.lblCash.Size = new System.Drawing.Size(39, 42);
            this.lblCash.TabIndex = 2;
            this.lblCash.Text = "$";
            // 
            // dgvDineroCaja
            // 
            this.dgvDineroCaja.AllowUserToAddRows = false;
            this.dgvDineroCaja.AllowUserToDeleteRows = false;
            this.dgvDineroCaja.AllowUserToResizeColumns = false;
            this.dgvDineroCaja.AllowUserToResizeRows = false;
            this.dgvDineroCaja.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvDineroCaja.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(46)))), ((int)(((byte)(140)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDineroCaja.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDineroCaja.ColumnHeadersHeight = 27;
            this.dgvDineroCaja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDineroCaja.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDenominacion,
            this.colCantidad,
            this.colSubtotal});
            this.dgvDineroCaja.EnableHeadersVisualStyles = false;
            this.dgvDineroCaja.Location = new System.Drawing.Point(22, 85);
            this.dgvDineroCaja.MultiSelect = false;
            this.dgvDineroCaja.Name = "dgvDineroCaja";
            this.dgvDineroCaja.RowHeadersVisible = false;
            this.dgvDineroCaja.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDineroCaja.Size = new System.Drawing.Size(459, 323);
            this.dgvDineroCaja.TabIndex = 5;
            this.dgvDineroCaja.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDineroCaja_CellValueChanged);
            this.dgvDineroCaja.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvDineroCaja_EditingControlShowing);
            // 
            // colDenominacion
            // 
            this.colDenominacion.HeaderText = "Denominación";
            this.colDenominacion.Name = "colDenominacion";
            this.colDenominacion.ReadOnly = true;
            this.colDenominacion.Width = 205;
            // 
            // colCantidad
            // 
            this.colCantidad.HeaderText = "Cantidad";
            this.colCantidad.MaxInputLength = 9;
            this.colCantidad.Name = "colCantidad";
            this.colCantidad.Width = 120;
            // 
            // colSubtotal
            // 
            this.colSubtotal.HeaderText = "Subtotal";
            this.colSubtotal.MaxInputLength = 10;
            this.colSubtotal.Name = "colSubtotal";
            this.colSubtotal.ReadOnly = true;
            this.colSubtotal.Width = 130;
            // 
            // btnAperturar
            // 
            this.btnAperturar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(184)))), ((int)(((byte)(39)))));
            this.btnAperturar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAperturar.FlatAppearance.BorderSize = 0;
            this.btnAperturar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(184)))), ((int)(((byte)(39)))));
            this.btnAperturar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(184)))), ((int)(((byte)(45)))));
            this.btnAperturar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAperturar.Font = new System.Drawing.Font("Arial", 9F);
            this.btnAperturar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(46)))), ((int)(((byte)(140)))));
            this.btnAperturar.Image = global::HendrixAccountant.Properties.Resources.cashBlue20;
            this.btnAperturar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAperturar.Location = new System.Drawing.Point(354, 426);
            this.btnAperturar.Name = "btnAperturar";
            this.btnAperturar.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnAperturar.Size = new System.Drawing.Size(127, 40);
            this.btnAperturar.TabIndex = 2;
            this.btnAperturar.Text = "Aperturar";
            this.btnAperturar.UseVisualStyleBackColor = false;
            this.btnAperturar.Click += new System.EventHandler(this.btnAperturar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblFechaApertura);
            this.groupBox1.Location = new System.Drawing.Point(22, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(459, 59);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Apertura de caja";
            // 
            // lblFechaApertura
            // 
            this.lblFechaApertura.AutoSize = true;
            this.lblFechaApertura.Location = new System.Drawing.Point(6, 26);
            this.lblFechaApertura.Name = "lblFechaApertura";
            this.lblFechaApertura.Size = new System.Drawing.Size(108, 13);
            this.lblFechaApertura.TabIndex = 0;
            this.lblFechaApertura.Text = "Fecha/hora apertura:";
            // 
            // frmAperturaCaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(508, 522);
            this.Controls.Add(this.btnAperturar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvDineroCaja);
            this.Controls.Add(this.gbxMontoTotal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(5, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmAperturaCaja";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "APERTURA DE CAJA";
            this.Load += new System.EventHandler(this.frmAperturaCaja_Load);
            this.gbxMontoTotal.ResumeLayout(false);
            this.gbxMontoTotal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDineroCaja)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblMontoTotal;
        private System.Windows.Forms.GroupBox gbxMontoTotal;
        private System.Windows.Forms.Label lblCash;
        private System.Windows.Forms.DataGridView dgvDineroCaja;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblFechaApertura;
        private UIControls.Buttons.ItemAsideSmall btnAperturar;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDenominacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSubtotal;
    }
}