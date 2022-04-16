
namespace HendrixAccountant.Forms.CashRegister
{
    partial class frmCierreCaja
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCierreCaja));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblMontoApertura = new System.Windows.Forms.Label();
            this.lblFechaApertura = new System.Windows.Forms.Label();
            this.lblFechaCierre = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dgvDineroCaja = new System.Windows.Forms.DataGridView();
            this.btnCerrarCaja = new HendrixAccountant.UIControls.Buttons.ItemAsideSmall();
            this.label3 = new System.Windows.Forms.Label();
            this.lblTotalIngresos = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblTotalGastos = new System.Windows.Forms.Label();
            this.lblMontoTotal = new System.Windows.Forms.Label();
            this.lblCash = new System.Windows.Forms.Label();
            this.gbxMontoTotal = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.colDenominacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSubtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDineroCaja)).BeginInit();
            this.gbxMontoTotal.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblSaldo);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lblTotalGastos);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.lblTotalIngresos);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblMontoApertura);
            this.groupBox1.Controls.Add(this.lblFechaApertura);
            this.groupBox1.Controls.Add(this.lblFechaCierre);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Location = new System.Drawing.Point(27, 14);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(524, 161);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cierre de caja";
            // 
            // lblMontoApertura
            // 
            this.lblMontoApertura.AutoSize = true;
            this.lblMontoApertura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontoApertura.Location = new System.Drawing.Point(178, 61);
            this.lblMontoApertura.Name = "lblMontoApertura";
            this.lblMontoApertura.Size = new System.Drawing.Size(40, 20);
            this.lblMontoApertura.TabIndex = 5;
            this.lblMontoApertura.Text = "0.00";
            this.lblMontoApertura.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblFechaApertura
            // 
            this.lblFechaApertura.AutoSize = true;
            this.lblFechaApertura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaApertura.Location = new System.Drawing.Point(16, 37);
            this.lblFechaApertura.Name = "lblFechaApertura";
            this.lblFechaApertura.Size = new System.Drawing.Size(31, 15);
            this.lblFechaApertura.TabIndex = 4;
            this.lblFechaApertura.Text = "0.00";
            // 
            // lblFechaCierre
            // 
            this.lblFechaCierre.AutoSize = true;
            this.lblFechaCierre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaCierre.Location = new System.Drawing.Point(303, 37);
            this.lblFechaCierre.Name = "lblFechaCierre";
            this.lblFechaCierre.Size = new System.Drawing.Size(31, 15);
            this.lblFechaCierre.TabIndex = 3;
            this.lblFechaCierre.Text = "0.00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label2.Location = new System.Drawing.Point(13, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "MONTO DE APERTURA:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label1.Location = new System.Drawing.Point(301, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fecha/hora cierre:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label11.Location = new System.Drawing.Point(14, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(108, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Fecha/hora apertura:";
            // 
            // dgvDineroCaja
            // 
            this.dgvDineroCaja.AllowUserToAddRows = false;
            this.dgvDineroCaja.AllowUserToDeleteRows = false;
            this.dgvDineroCaja.AllowUserToResizeColumns = false;
            this.dgvDineroCaja.AllowUserToResizeRows = false;
            this.dgvDineroCaja.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvDineroCaja.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvDineroCaja.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dgvDineroCaja.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
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
            this.dgvDineroCaja.Location = new System.Drawing.Point(56, 185);
            this.dgvDineroCaja.MultiSelect = false;
            this.dgvDineroCaja.Name = "dgvDineroCaja";
            this.dgvDineroCaja.RowHeadersVisible = false;
            this.dgvDineroCaja.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDineroCaja.Size = new System.Drawing.Size(471, 261);
            this.dgvDineroCaja.TabIndex = 9;
            this.dgvDineroCaja.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvDineroCaja_EditingControlShowing);
            // 
            // btnCerrarCaja
            // 
            this.btnCerrarCaja.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(184)))), ((int)(((byte)(39)))));
            this.btnCerrarCaja.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCerrarCaja.FlatAppearance.BorderSize = 0;
            this.btnCerrarCaja.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(184)))), ((int)(((byte)(39)))));
            this.btnCerrarCaja.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(184)))), ((int)(((byte)(45)))));
            this.btnCerrarCaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarCaja.Font = new System.Drawing.Font("Arial", 9F);
            this.btnCerrarCaja.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(46)))), ((int)(((byte)(140)))));
            this.btnCerrarCaja.Image = global::HendrixAccountant.Properties.Resources.cashBlue20;
            this.btnCerrarCaja.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCerrarCaja.Location = new System.Drawing.Point(392, 462);
            this.btnCerrarCaja.Name = "btnCerrarCaja";
            this.btnCerrarCaja.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnCerrarCaja.Size = new System.Drawing.Size(135, 40);
            this.btnCerrarCaja.TabIndex = 11;
            this.btnCerrarCaja.Text = "Cerrar Caja";
            this.btnCerrarCaja.UseVisualStyleBackColor = false;
            this.btnCerrarCaja.Click += new System.EventHandler(this.btnCerrarCaja_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label3.Location = new System.Drawing.Point(13, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "TOTAL INGRESOS:";
            // 
            // lblTotalIngresos
            // 
            this.lblTotalIngresos.AutoSize = true;
            this.lblTotalIngresos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalIngresos.Location = new System.Drawing.Point(178, 81);
            this.lblTotalIngresos.Name = "lblTotalIngresos";
            this.lblTotalIngresos.Size = new System.Drawing.Size(40, 20);
            this.lblTotalIngresos.TabIndex = 7;
            this.lblTotalIngresos.Text = "0.00";
            this.lblTotalIngresos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label7.Location = new System.Drawing.Point(301, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 15);
            this.label7.TabIndex = 10;
            this.label7.Text = "TOTAL GASTOS:";
            // 
            // lblTotalGastos
            // 
            this.lblTotalGastos.AutoSize = true;
            this.lblTotalGastos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalGastos.Location = new System.Drawing.Point(423, 78);
            this.lblTotalGastos.Name = "lblTotalGastos";
            this.lblTotalGastos.Size = new System.Drawing.Size(40, 20);
            this.lblTotalGastos.TabIndex = 11;
            this.lblTotalGastos.Text = "0.00";
            this.lblTotalGastos.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblMontoTotal
            // 
            this.lblMontoTotal.AutoSize = true;
            this.lblMontoTotal.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontoTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(46)))), ((int)(((byte)(140)))));
            this.lblMontoTotal.Location = new System.Drawing.Point(74, 22);
            this.lblMontoTotal.Name = "lblMontoTotal";
            this.lblMontoTotal.Size = new System.Drawing.Size(93, 44);
            this.lblMontoTotal.TabIndex = 1;
            this.lblMontoTotal.Text = "0.00";
            // 
            // lblCash
            // 
            this.lblCash.AutoSize = true;
            this.lblCash.Font = new System.Drawing.Font("Arial", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCash.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(46)))), ((int)(((byte)(140)))));
            this.lblCash.Location = new System.Drawing.Point(29, 22);
            this.lblCash.Name = "lblCash";
            this.lblCash.Size = new System.Drawing.Size(39, 42);
            this.lblCash.TabIndex = 2;
            this.lblCash.Text = "$";
            // 
            // gbxMontoTotal
            // 
            this.gbxMontoTotal.Controls.Add(this.lblCash);
            this.gbxMontoTotal.Controls.Add(this.lblMontoTotal);
            this.gbxMontoTotal.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxMontoTotal.ForeColor = System.Drawing.SystemColors.GrayText;
            this.gbxMontoTotal.Location = new System.Drawing.Point(56, 452);
            this.gbxMontoTotal.Name = "gbxMontoTotal";
            this.gbxMontoTotal.Size = new System.Drawing.Size(318, 77);
            this.gbxMontoTotal.TabIndex = 8;
            this.gbxMontoTotal.TabStop = false;
            this.gbxMontoTotal.Text = "TOTAL EN CAJA";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(46)))), ((int)(((byte)(140)))));
            this.label5.Location = new System.Drawing.Point(15, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "SALDO DEL DÍA";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label6.Location = new System.Drawing.Point(14, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(493, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "_________________________________________________________________________________" +
    "";
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaldo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(46)))), ((int)(((byte)(140)))));
            this.lblSaldo.Location = new System.Drawing.Point(178, 125);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(44, 20);
            this.lblSaldo.TabIndex = 14;
            this.lblSaldo.Text = "0.00";
            // 
            // colDenominacion
            // 
            this.colDenominacion.HeaderText = "Denominación";
            this.colDenominacion.Name = "colDenominacion";
            this.colDenominacion.ReadOnly = true;
            this.colDenominacion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colDenominacion.Width = 205;
            // 
            // colCantidad
            // 
            this.colCantidad.HeaderText = "Cantidad";
            this.colCantidad.MaxInputLength = 9;
            this.colCantidad.Name = "colCantidad";
            this.colCantidad.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colCantidad.Width = 120;
            // 
            // colSubtotal
            // 
            this.colSubtotal.HeaderText = "Subtotal";
            this.colSubtotal.MaxInputLength = 10;
            this.colSubtotal.Name = "colSubtotal";
            this.colSubtotal.ReadOnly = true;
            this.colSubtotal.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.colSubtotal.Width = 130;
            // 
            // frmCierreCaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(597, 559);
            this.Controls.Add(this.btnCerrarCaja);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvDineroCaja);
            this.Controls.Add(this.gbxMontoTotal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(5, 5);
            this.Name = "frmCierreCaja";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "CIERRE DE CAJA";
            this.Load += new System.EventHandler(this.frmCierreCaja_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDineroCaja)).EndInit();
            this.gbxMontoTotal.ResumeLayout(false);
            this.gbxMontoTotal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dgvDineroCaja;
        private System.Windows.Forms.Label lblFechaCierre;
        private System.Windows.Forms.Label lblFechaApertura;
        private System.Windows.Forms.Label lblMontoApertura;
        private UIControls.Buttons.ItemAsideSmall btnCerrarCaja;
        private System.Windows.Forms.Label lblTotalIngresos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblTotalGastos;
        private System.Windows.Forms.Label lblMontoTotal;
        private System.Windows.Forms.Label lblCash;
        private System.Windows.Forms.GroupBox gbxMontoTotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDenominacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSubtotal;
    }
}