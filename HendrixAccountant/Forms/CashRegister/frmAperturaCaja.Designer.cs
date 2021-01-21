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
            this.lblMontoTotal = new System.Windows.Forms.Label();
            this.gbxMontoTotal = new System.Windows.Forms.GroupBox();
            this.lblCash = new System.Windows.Forms.Label();
            this.dgvDineroCaja = new System.Windows.Forms.DataGridView();
            this.colDenominacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSubtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAperturar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblFechaCierre = new System.Windows.Forms.Label();
            this.lblFechaApertura = new System.Windows.Forms.Label();
            this.gbxMontoTotal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDineroCaja)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblMontoTotal
            // 
            this.lblMontoTotal.AutoSize = true;
            this.lblMontoTotal.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontoTotal.Location = new System.Drawing.Point(74, 26);
            this.lblMontoTotal.Name = "lblMontoTotal";
            this.lblMontoTotal.Size = new System.Drawing.Size(91, 42);
            this.lblMontoTotal.TabIndex = 1;
            this.lblMontoTotal.Text = "0.00";
            // 
            // gbxMontoTotal
            // 
            this.gbxMontoTotal.Controls.Add(this.lblCash);
            this.gbxMontoTotal.Controls.Add(this.lblMontoTotal);
            this.gbxMontoTotal.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxMontoTotal.Location = new System.Drawing.Point(122, 227);
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
            this.dgvDineroCaja.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvDineroCaja.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDineroCaja.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDenominacion,
            this.colCantidad,
            this.colSubtotal});
            this.dgvDineroCaja.Location = new System.Drawing.Point(9, 70);
            this.dgvDineroCaja.MultiSelect = false;
            this.dgvDineroCaja.Name = "dgvDineroCaja";
            this.dgvDineroCaja.RowHeadersVisible = false;
            this.dgvDineroCaja.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDineroCaja.Size = new System.Drawing.Size(433, 151);
            this.dgvDineroCaja.TabIndex = 5;
            this.dgvDineroCaja.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDineroCaja_CellValueChanged);
            // 
            // colDenominacion
            // 
            this.colDenominacion.HeaderText = "Denominación";
            this.colDenominacion.Name = "colDenominacion";
            this.colDenominacion.ReadOnly = true;
            this.colDenominacion.Width = 180;
            // 
            // colCantidad
            // 
            this.colCantidad.HeaderText = "Cantidad";
            this.colCantidad.Name = "colCantidad";
            this.colCantidad.Width = 120;
            // 
            // colSubtotal
            // 
            this.colSubtotal.HeaderText = "Subtotal";
            this.colSubtotal.Name = "colSubtotal";
            this.colSubtotal.ReadOnly = true;
            this.colSubtotal.Width = 130;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.btnAperturar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(449, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(125, 322);
            this.panel1.TabIndex = 6;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(6, 236);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(119, 30);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnAperturar
            // 
            this.btnAperturar.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAperturar.Location = new System.Drawing.Point(3, 18);
            this.btnAperturar.Name = "btnAperturar";
            this.btnAperturar.Size = new System.Drawing.Size(119, 30);
            this.btnAperturar.TabIndex = 0;
            this.btnAperturar.Text = "Aperturar";
            this.btnAperturar.UseVisualStyleBackColor = true;
            this.btnAperturar.Click += new System.EventHandler(this.btnAperturar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblFechaCierre);
            this.groupBox1.Controls.Add(this.lblFechaApertura);
            this.groupBox1.Location = new System.Drawing.Point(9, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(433, 52);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Apertura de caja";
            // 
            // lblFechaCierre
            // 
            this.lblFechaCierre.AutoSize = true;
            this.lblFechaCierre.Location = new System.Drawing.Point(230, 24);
            this.lblFechaCierre.Name = "lblFechaCierre";
            this.lblFechaCierre.Size = new System.Drawing.Size(69, 13);
            this.lblFechaCierre.TabIndex = 1;
            this.lblFechaCierre.Text = "Fecha cierre:";
            // 
            // lblFechaApertura
            // 
            this.lblFechaApertura.AutoSize = true;
            this.lblFechaApertura.Location = new System.Drawing.Point(6, 24);
            this.lblFechaApertura.Name = "lblFechaApertura";
            this.lblFechaApertura.Size = new System.Drawing.Size(82, 13);
            this.lblFechaApertura.TabIndex = 0;
            this.lblFechaApertura.Text = "Fecha apertura:";
            // 
            // frmAperturaCaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 322);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvDineroCaja);
            this.Controls.Add(this.gbxMontoTotal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmAperturaCaja";
            this.Text = "GESTOR DE CAJA";
            this.Load += new System.EventHandler(this.frmAperturaCaja_Load);
            this.gbxMontoTotal.ResumeLayout(false);
            this.gbxMontoTotal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDineroCaja)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblMontoTotal;
        private System.Windows.Forms.GroupBox gbxMontoTotal;
        private System.Windows.Forms.Label lblCash;
        private System.Windows.Forms.DataGridView dgvDineroCaja;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAperturar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblFechaApertura;
        private System.Windows.Forms.Label lblFechaCierre;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDenominacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSubtotal;
    }
}