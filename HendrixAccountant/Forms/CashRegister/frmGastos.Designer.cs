
namespace HendrixAccountant.Forms.CashRegister
{
    partial class frmGastos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGastos));
            this.gbProveedor = new System.Windows.Forms.GroupBox();
            this.lblPrecioVenta = new System.Windows.Forms.Label();
            this.pnlPrecioVenta = new System.Windows.Forms.Panel();
            this.lblPnPrecioVenta = new System.Windows.Forms.Label();
            this.txtValorGasto = new System.Windows.Forms.TextBox();
            this.btnRegistrarGasto = new System.Windows.Forms.Button();
            this.cboTipoGasto = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.pnDireccion = new System.Windows.Forms.Panel();
            this.txtObservaciones = new System.Windows.Forms.TextBox();
            this.lblPnDescripcion = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpFechaGasto = new System.Windows.Forms.DateTimePicker();
            this.gbProveedor.SuspendLayout();
            this.pnlPrecioVenta.SuspendLayout();
            this.pnDireccion.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbProveedor
            // 
            this.gbProveedor.Controls.Add(this.lblPrecioVenta);
            this.gbProveedor.Controls.Add(this.pnlPrecioVenta);
            this.gbProveedor.Controls.Add(this.btnRegistrarGasto);
            this.gbProveedor.Controls.Add(this.cboTipoGasto);
            this.gbProveedor.Controls.Add(this.label13);
            this.gbProveedor.Controls.Add(this.label15);
            this.gbProveedor.Controls.Add(this.pnDireccion);
            this.gbProveedor.Controls.Add(this.label6);
            this.gbProveedor.Controls.Add(this.dtpFechaGasto);
            this.gbProveedor.Location = new System.Drawing.Point(22, 20);
            this.gbProveedor.Name = "gbProveedor";
            this.gbProveedor.Size = new System.Drawing.Size(572, 209);
            this.gbProveedor.TabIndex = 1;
            this.gbProveedor.TabStop = false;
            // 
            // lblPrecioVenta
            // 
            this.lblPrecioVenta.AutoSize = true;
            this.lblPrecioVenta.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecioVenta.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblPrecioVenta.Location = new System.Drawing.Point(277, 79);
            this.lblPrecioVenta.Name = "lblPrecioVenta";
            this.lblPrecioVenta.Size = new System.Drawing.Size(34, 15);
            this.lblPrecioVenta.TabIndex = 85;
            this.lblPrecioVenta.Text = "Valor";
            // 
            // pnlPrecioVenta
            // 
            this.pnlPrecioVenta.BackColor = System.Drawing.SystemColors.Control;
            this.pnlPrecioVenta.Controls.Add(this.lblPnPrecioVenta);
            this.pnlPrecioVenta.Controls.Add(this.txtValorGasto);
            this.pnlPrecioVenta.Location = new System.Drawing.Point(280, 96);
            this.pnlPrecioVenta.Name = "pnlPrecioVenta";
            this.pnlPrecioVenta.Size = new System.Drawing.Size(98, 32);
            this.pnlPrecioVenta.TabIndex = 84;
            // 
            // lblPnPrecioVenta
            // 
            this.lblPnPrecioVenta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(107)))), ((int)(((byte)(247)))));
            this.lblPnPrecioVenta.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblPnPrecioVenta.Location = new System.Drawing.Point(0, 30);
            this.lblPnPrecioVenta.Name = "lblPnPrecioVenta";
            this.lblPnPrecioVenta.Size = new System.Drawing.Size(98, 2);
            this.lblPnPrecioVenta.TabIndex = 9;
            // 
            // txtValorGasto
            // 
            this.txtValorGasto.BackColor = System.Drawing.SystemColors.Control;
            this.txtValorGasto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtValorGasto.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValorGasto.Location = new System.Drawing.Point(8, 8);
            this.txtValorGasto.MaxLength = 10;
            this.txtValorGasto.Name = "txtValorGasto";
            this.txtValorGasto.Size = new System.Drawing.Size(85, 15);
            this.txtValorGasto.TabIndex = 6;
            this.txtValorGasto.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnRegistrarGasto
            // 
            this.btnRegistrarGasto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(46)))), ((int)(((byte)(140)))));
            this.btnRegistrarGasto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegistrarGasto.FlatAppearance.BorderSize = 0;
            this.btnRegistrarGasto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarGasto.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarGasto.ForeColor = System.Drawing.SystemColors.Window;
            this.btnRegistrarGasto.Location = new System.Drawing.Point(456, 151);
            this.btnRegistrarGasto.Name = "btnRegistrarGasto";
            this.btnRegistrarGasto.Size = new System.Drawing.Size(90, 30);
            this.btnRegistrarGasto.TabIndex = 83;
            this.btnRegistrarGasto.Text = "Registrar";
            this.btnRegistrarGasto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRegistrarGasto.UseVisualStyleBackColor = false;
            this.btnRegistrarGasto.Click += new System.EventHandler(this.btnRegistrarGasto_Click);
            // 
            // cboTipoGasto
            // 
            this.cboTipoGasto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoGasto.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboTipoGasto.FormattingEnabled = true;
            this.cboTipoGasto.Location = new System.Drawing.Point(21, 96);
            this.cboTipoGasto.Name = "cboTipoGasto";
            this.cboTipoGasto.Size = new System.Drawing.Size(243, 24);
            this.cboTipoGasto.TabIndex = 82;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label13.Location = new System.Drawing.Point(19, 77);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(67, 15);
            this.label13.TabIndex = 81;
            this.label13.Text = "Tipo Gasto";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label15.Location = new System.Drawing.Point(19, 131);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(46, 15);
            this.label15.TabIndex = 78;
            this.label15.Text = "Detalle";
            // 
            // pnDireccion
            // 
            this.pnDireccion.BackColor = System.Drawing.SystemColors.Control;
            this.pnDireccion.Controls.Add(this.txtObservaciones);
            this.pnDireccion.Controls.Add(this.lblPnDescripcion);
            this.pnDireccion.Location = new System.Drawing.Point(22, 149);
            this.pnDireccion.Name = "pnDireccion";
            this.pnDireccion.Size = new System.Drawing.Size(411, 32);
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
            this.txtObservaciones.Size = new System.Drawing.Size(404, 15);
            this.txtObservaciones.TabIndex = 2;
            // 
            // lblPnDescripcion
            // 
            this.lblPnDescripcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(107)))), ((int)(((byte)(247)))));
            this.lblPnDescripcion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblPnDescripcion.Location = new System.Drawing.Point(0, 30);
            this.lblPnDescripcion.Name = "lblPnDescripcion";
            this.lblPnDescripcion.Size = new System.Drawing.Size(411, 2);
            this.lblPnDescripcion.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label6.Location = new System.Drawing.Point(18, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 15);
            this.label6.TabIndex = 78;
            this.label6.Text = "Fecha de gasto";
            // 
            // dtpFechaGasto
            // 
            this.dtpFechaGasto.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaGasto.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFechaGasto.Location = new System.Drawing.Point(21, 40);
            this.dtpFechaGasto.Name = "dtpFechaGasto";
            this.dtpFechaGasto.Size = new System.Drawing.Size(115, 25);
            this.dtpFechaGasto.TabIndex = 13;
            // 
            // frmGastos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(620, 368);
            this.Controls.Add(this.gbProveedor);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(5, 5);
            this.Name = "frmGastos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "GASTOS";
            this.Load += new System.EventHandler(this.frmGastos_Load);
            this.gbProveedor.ResumeLayout(false);
            this.gbProveedor.PerformLayout();
            this.pnlPrecioVenta.ResumeLayout(false);
            this.pnlPrecioVenta.PerformLayout();
            this.pnDireccion.ResumeLayout(false);
            this.pnDireccion.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbProveedor;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel pnDireccion;
        private System.Windows.Forms.TextBox txtObservaciones;
        private System.Windows.Forms.Label lblPnDescripcion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpFechaGasto;
        private System.Windows.Forms.ComboBox cboTipoGasto;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnRegistrarGasto;
        private System.Windows.Forms.Label lblPrecioVenta;
        private System.Windows.Forms.Panel pnlPrecioVenta;
        private System.Windows.Forms.Label lblPnPrecioVenta;
        private System.Windows.Forms.TextBox txtValorGasto;
    }
}