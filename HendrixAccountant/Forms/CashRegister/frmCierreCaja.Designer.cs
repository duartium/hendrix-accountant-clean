
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
            this.label11 = new System.Windows.Forms.Label();
            this.dgvDineroCaja = new System.Windows.Forms.DataGridView();
            this.colDenominacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSubtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbxMontoTotal = new System.Windows.Forms.GroupBox();
            this.lblCash = new System.Windows.Forms.Label();
            this.lblMontoTotal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblFechaCierre = new System.Windows.Forms.Label();
            this.lblFechaApertura = new System.Windows.Forms.Label();
            this.lblMontoApertura = new System.Windows.Forms.Label();
            this.btnCerrarCaja = new HendrixAccountant.UIControls.Buttons.ItemAsideSmall();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDineroCaja)).BeginInit();
            this.gbxMontoTotal.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblMontoApertura);
            this.groupBox1.Controls.Add(this.lblFechaApertura);
            this.groupBox1.Controls.Add(this.lblFechaCierre);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Location = new System.Drawing.Point(27, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(459, 101);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Apertura de caja";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(13, 31);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(121, 15);
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
            this.dgvDineroCaja.Location = new System.Drawing.Point(27, 140);
            this.dgvDineroCaja.MultiSelect = false;
            this.dgvDineroCaja.Name = "dgvDineroCaja";
            this.dgvDineroCaja.RowHeadersVisible = false;
            this.dgvDineroCaja.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDineroCaja.Size = new System.Drawing.Size(459, 151);
            this.dgvDineroCaja.TabIndex = 9;
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
            // gbxMontoTotal
            // 
            this.gbxMontoTotal.Controls.Add(this.lblCash);
            this.gbxMontoTotal.Controls.Add(this.lblMontoTotal);
            this.gbxMontoTotal.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxMontoTotal.Location = new System.Drawing.Point(27, 305);
            this.gbxMontoTotal.Name = "gbxMontoTotal";
            this.gbxMontoTotal.Size = new System.Drawing.Size(320, 87);
            this.gbxMontoTotal.TabIndex = 8;
            this.gbxMontoTotal.TabStop = false;
            this.gbxMontoTotal.Text = "TOTAL EN CAJA";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(265, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fecha/hora cierre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Base de apertura:";
            // 
            // lblFechaCierre
            // 
            this.lblFechaCierre.AutoSize = true;
            this.lblFechaCierre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaCierre.Location = new System.Drawing.Point(377, 31);
            this.lblFechaCierre.Name = "lblFechaCierre";
            this.lblFechaCierre.Size = new System.Drawing.Size(31, 15);
            this.lblFechaCierre.TabIndex = 3;
            this.lblFechaCierre.Text = "0.00";
            // 
            // lblFechaApertura
            // 
            this.lblFechaApertura.AutoSize = true;
            this.lblFechaApertura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaApertura.Location = new System.Drawing.Point(140, 31);
            this.lblFechaApertura.Name = "lblFechaApertura";
            this.lblFechaApertura.Size = new System.Drawing.Size(31, 15);
            this.lblFechaApertura.TabIndex = 4;
            this.lblFechaApertura.Text = "0.00";
            // 
            // lblMontoApertura
            // 
            this.lblMontoApertura.AutoSize = true;
            this.lblMontoApertura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMontoApertura.Location = new System.Drawing.Point(140, 63);
            this.lblMontoApertura.Name = "lblMontoApertura";
            this.lblMontoApertura.Size = new System.Drawing.Size(31, 15);
            this.lblMontoApertura.TabIndex = 5;
            this.lblMontoApertura.Text = "0.00";
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
            this.btnCerrarCaja.Location = new System.Drawing.Point(359, 313);
            this.btnCerrarCaja.Name = "btnCerrarCaja";
            this.btnCerrarCaja.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnCerrarCaja.Size = new System.Drawing.Size(127, 40);
            this.btnCerrarCaja.TabIndex = 11;
            this.btnCerrarCaja.Text = "Cerrar";
            this.btnCerrarCaja.UseVisualStyleBackColor = false;
            this.btnCerrarCaja.Click += new System.EventHandler(this.btnCerrarCaja_Click);
            // 
            // frmCierreCaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(518, 420);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn colDenominacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSubtotal;
        private System.Windows.Forms.GroupBox gbxMontoTotal;
        private System.Windows.Forms.Label lblCash;
        private System.Windows.Forms.Label lblMontoTotal;
        private System.Windows.Forms.Label lblFechaCierre;
        private System.Windows.Forms.Label lblFechaApertura;
        private System.Windows.Forms.Label lblMontoApertura;
        private UIControls.Buttons.ItemAsideSmall btnCerrarCaja;
    }
}