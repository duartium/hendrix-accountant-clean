
namespace HendrixAccountant.Forms.Sales
{
    partial class frmAnulacionComprobante
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAnulacionComprobante));
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pnCodigo = new System.Windows.Forms.Panel();
            this.lblPnCodigo = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.pnDireccion = new System.Windows.Forms.Panel();
            this.txtMotivoAnulacion = new System.Windows.Forms.TextBox();
            this.lblPnDescripcion = new System.Windows.Forms.Label();
            this.btnAnular = new System.Windows.Forms.Button();
            this.dgvComprobanteInd = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtNumSecuencial = new HendrixAccountant.UIControls.NumericInput();
            this.groupBox1.SuspendLayout();
            this.pnCodigo.SuspendLayout();
            this.pnDireccion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComprobanteInd)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label9.Location = new System.Drawing.Point(11, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(145, 15);
            this.label9.TabIndex = 64;
            this.label9.Text = "Número de comprobante";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pnCodigo);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Location = new System.Drawing.Point(20, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(181, 98);
            this.groupBox1.TabIndex = 65;
            this.groupBox1.TabStop = false;
            // 
            // pnCodigo
            // 
            this.pnCodigo.BackColor = System.Drawing.SystemColors.Control;
            this.pnCodigo.Controls.Add(this.txtNumSecuencial);
            this.pnCodigo.Controls.Add(this.lblPnCodigo);
            this.pnCodigo.Location = new System.Drawing.Point(14, 47);
            this.pnCodigo.Name = "pnCodigo";
            this.pnCodigo.Size = new System.Drawing.Size(142, 32);
            this.pnCodigo.TabIndex = 62;
            // 
            // lblPnCodigo
            // 
            this.lblPnCodigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(107)))), ((int)(((byte)(247)))));
            this.lblPnCodigo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblPnCodigo.Location = new System.Drawing.Point(0, 30);
            this.lblPnCodigo.Name = "lblPnCodigo";
            this.lblPnCodigo.Size = new System.Drawing.Size(142, 2);
            this.lblPnCodigo.TabIndex = 9;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label15.Location = new System.Drawing.Point(31, 30);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(115, 15);
            this.label15.TabIndex = 68;
            this.label15.Text = "Motivo de anulación";
            // 
            // pnDireccion
            // 
            this.pnDireccion.BackColor = System.Drawing.SystemColors.Control;
            this.pnDireccion.Controls.Add(this.txtMotivoAnulacion);
            this.pnDireccion.Controls.Add(this.lblPnDescripcion);
            this.pnDireccion.Location = new System.Drawing.Point(34, 46);
            this.pnDireccion.Name = "pnDireccion";
            this.pnDireccion.Size = new System.Drawing.Size(309, 32);
            this.pnDireccion.TabIndex = 67;
            // 
            // txtMotivoAnulacion
            // 
            this.txtMotivoAnulacion.BackColor = System.Drawing.SystemColors.Control;
            this.txtMotivoAnulacion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMotivoAnulacion.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMotivoAnulacion.Location = new System.Drawing.Point(7, 8);
            this.txtMotivoAnulacion.MaxLength = 150;
            this.txtMotivoAnulacion.Name = "txtMotivoAnulacion";
            this.txtMotivoAnulacion.Size = new System.Drawing.Size(299, 15);
            this.txtMotivoAnulacion.TabIndex = 1;
            // 
            // lblPnDescripcion
            // 
            this.lblPnDescripcion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(107)))), ((int)(((byte)(247)))));
            this.lblPnDescripcion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblPnDescripcion.Location = new System.Drawing.Point(0, 30);
            this.lblPnDescripcion.Name = "lblPnDescripcion";
            this.lblPnDescripcion.Size = new System.Drawing.Size(309, 2);
            this.lblPnDescripcion.TabIndex = 9;
            // 
            // btnAnular
            // 
            this.btnAnular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnAnular.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAnular.FlatAppearance.BorderSize = 0;
            this.btnAnular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnular.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnular.ForeColor = System.Drawing.SystemColors.Window;
            this.btnAnular.Image = global::HendrixAccountant.Properties.Resources.trashWhite20;
            this.btnAnular.Location = new System.Drawing.Point(353, 46);
            this.btnAnular.Name = "btnAnular";
            this.btnAnular.Padding = new System.Windows.Forms.Padding(8, 0, 0, 0);
            this.btnAnular.Size = new System.Drawing.Size(98, 32);
            this.btnAnular.TabIndex = 69;
            this.btnAnular.Text = "Anular";
            this.btnAnular.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAnular.UseVisualStyleBackColor = false;
            this.btnAnular.Click += new System.EventHandler(this.btnAnular_Click);
            // 
            // dgvComprobanteInd
            // 
            this.dgvComprobanteInd.AllowUserToAddRows = false;
            this.dgvComprobanteInd.AllowUserToResizeRows = false;
            this.dgvComprobanteInd.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvComprobanteInd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvComprobanteInd.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(46)))), ((int)(((byte)(140)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvComprobanteInd.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvComprobanteInd.ColumnHeadersHeight = 27;
            this.dgvComprobanteInd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvComprobanteInd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dgvComprobanteInd.EnableHeadersVisualStyles = false;
            this.dgvComprobanteInd.Location = new System.Drawing.Point(20, 124);
            this.dgvComprobanteInd.Name = "dgvComprobanteInd";
            this.dgvComprobanteInd.RowHeadersVisible = false;
            this.dgvComprobanteInd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvComprobanteInd.Size = new System.Drawing.Size(682, 318);
            this.dgvComprobanteInd.TabIndex = 70;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Código";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 60;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Nombre de producto";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 280;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewTextBoxColumn3.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewTextBoxColumn3.HeaderText = "Cantidad";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 80;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            this.dataGridViewTextBoxColumn4.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewTextBoxColumn4.HeaderText = "Precio";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 140;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle4.NullValue = "0";
            this.dataGridViewTextBoxColumn5.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewTextBoxColumn5.HeaderText = "Total";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 120;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pnDireccion);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.btnAnular);
            this.groupBox2.Location = new System.Drawing.Point(218, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(484, 98);
            this.groupBox2.TabIndex = 66;
            this.groupBox2.TabStop = false;
            // 
            // txtNumSecuencial
            // 
            this.txtNumSecuencial.BackColor = System.Drawing.SystemColors.Control;
            this.txtNumSecuencial.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNumSecuencial.Font = new System.Drawing.Font("Arial", 10F);
            this.txtNumSecuencial.Location = new System.Drawing.Point(10, 7);
            this.txtNumSecuencial.MaxLength = 13;
            this.txtNumSecuencial.Name = "txtNumSecuencial";
            this.txtNumSecuencial.Size = new System.Drawing.Size(126, 16);
            this.txtNumSecuencial.TabIndex = 71;
            this.txtNumSecuencial.TextChanged += new System.EventHandler(this.txtNumSecuencial_TextChanged);
            this.txtNumSecuencial.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtNumSecuencial_KeyDown);
            this.txtNumSecuencial.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtNumSecuencial_MouseDown);
            // 
            // frmAnulacionComprobante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(724, 463);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgvComprobanteInd);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(5, 5);
            this.Name = "frmAnulacionComprobante";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "ANULACIÓN DE COMPROBANTE DE VENTA";
            this.Activated += new System.EventHandler(this.frmAnulacionComprobante_Activated);
            this.Load += new System.EventHandler(this.frmAnulacionComprobante_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnCodigo.ResumeLayout(false);
            this.pnCodigo.PerformLayout();
            this.pnDireccion.ResumeLayout(false);
            this.pnDireccion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComprobanteInd)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel pnCodigo;
        private System.Windows.Forms.Label lblPnCodigo;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Panel pnDireccion;
        private System.Windows.Forms.TextBox txtMotivoAnulacion;
        private System.Windows.Forms.Label lblPnDescripcion;
        private System.Windows.Forms.Button btnAnular;
        private System.Windows.Forms.DataGridView dgvComprobanteInd;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.GroupBox groupBox2;
        private UIControls.NumericInput txtNumSecuencial;
    }
}