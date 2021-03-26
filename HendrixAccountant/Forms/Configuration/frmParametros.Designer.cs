namespace HendrixAccountant
{
    partial class frmParametros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmParametros));
            this.tpEmpresa = new System.Windows.Forms.TabPage();
            this.chkEditar = new System.Windows.Forms.CheckBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.pnDireccionEstablecimiento = new System.Windows.Forms.Panel();
            this.txtDireccion = new HendrixAccountant.UIControls.TextInput();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pnRazonSocial = new System.Windows.Forms.Panel();
            this.txtRazonSocial = new HendrixAccountant.UIControls.TextInput();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pnNombreComercial = new System.Windows.Forms.Panel();
            this.txtNombreComercial = new HendrixAccountant.UIControls.TextInput();
            this.label2 = new System.Windows.Forms.Label();
            this.lblRazonSocial = new System.Windows.Forms.Label();
            this.pnIdentificacion = new System.Windows.Forms.Panel();
            this.txtRuc = new HendrixAccountant.UIControls.NumericInput();
            this.label7 = new System.Windows.Forms.Label();
            this.lblRuc = new System.Windows.Forms.Label();
            this.tcEmpresa = new System.Windows.Forms.TabControl();
            this.pnHeader = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.tpEmpresa.SuspendLayout();
            this.pnDireccionEstablecimiento.SuspendLayout();
            this.pnRazonSocial.SuspendLayout();
            this.pnNombreComercial.SuspendLayout();
            this.pnIdentificacion.SuspendLayout();
            this.tcEmpresa.SuspendLayout();
            this.pnHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tpEmpresa
            // 
            this.tpEmpresa.Controls.Add(this.chkEditar);
            this.tpEmpresa.Controls.Add(this.btnGuardar);
            this.tpEmpresa.Controls.Add(this.pnDireccionEstablecimiento);
            this.tpEmpresa.Controls.Add(this.label5);
            this.tpEmpresa.Controls.Add(this.pnRazonSocial);
            this.tpEmpresa.Controls.Add(this.label3);
            this.tpEmpresa.Controls.Add(this.pnNombreComercial);
            this.tpEmpresa.Controls.Add(this.lblRazonSocial);
            this.tpEmpresa.Controls.Add(this.pnIdentificacion);
            this.tpEmpresa.Controls.Add(this.lblRuc);
            this.tpEmpresa.Location = new System.Drawing.Point(4, 24);
            this.tpEmpresa.Name = "tpEmpresa";
            this.tpEmpresa.Padding = new System.Windows.Forms.Padding(3);
            this.tpEmpresa.Size = new System.Drawing.Size(402, 284);
            this.tpEmpresa.TabIndex = 0;
            this.tpEmpresa.Text = "Empresa";
            this.tpEmpresa.UseVisualStyleBackColor = true;
            // 
            // chkEditar
            // 
            this.chkEditar.AutoSize = true;
            this.chkEditar.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEditar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(46)))), ((int)(((byte)(140)))));
            this.chkEditar.Location = new System.Drawing.Point(330, 13);
            this.chkEditar.Name = "chkEditar";
            this.chkEditar.Size = new System.Drawing.Size(59, 19);
            this.chkEditar.TabIndex = 18;
            this.chkEditar.Text = "Editar";
            this.chkEditar.UseVisualStyleBackColor = true;
            this.chkEditar.CheckedChanged += new System.EventHandler(this.chkEditar_CheckedChanged);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(89)))));
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.SystemColors.Window;
            this.btnGuardar.Image = global::HendrixAccountant.Properties.Resources.saveWhite20;
            this.btnGuardar.Location = new System.Drawing.Point(302, 238);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(90, 30);
            this.btnGuardar.TabIndex = 5;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // pnDireccionEstablecimiento
            // 
            this.pnDireccionEstablecimiento.BackColor = System.Drawing.SystemColors.Control;
            this.pnDireccionEstablecimiento.Controls.Add(this.txtDireccion);
            this.pnDireccionEstablecimiento.Controls.Add(this.label4);
            this.pnDireccionEstablecimiento.Location = new System.Drawing.Point(11, 185);
            this.pnDireccionEstablecimiento.Name = "pnDireccionEstablecimiento";
            this.pnDireccionEstablecimiento.Size = new System.Drawing.Size(381, 32);
            this.pnDireccionEstablecimiento.TabIndex = 17;
            // 
            // txtDireccion
            // 
            this.txtDireccion.BackColor = System.Drawing.SystemColors.Control;
            this.txtDireccion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDireccion.Font = new System.Drawing.Font("Arial", 10F);
            this.txtDireccion.Location = new System.Drawing.Point(1, 7);
            this.txtDireccion.MaxLength = 100;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(378, 16);
            this.txtDireccion.TabIndex = 2;
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
            this.label5.Location = new System.Drawing.Point(8, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 15);
            this.label5.TabIndex = 16;
            this.label5.Text = "Dirección establecimiento";
            // 
            // pnRazonSocial
            // 
            this.pnRazonSocial.BackColor = System.Drawing.SystemColors.Control;
            this.pnRazonSocial.Controls.Add(this.txtRazonSocial);
            this.pnRazonSocial.Controls.Add(this.label1);
            this.pnRazonSocial.Location = new System.Drawing.Point(10, 132);
            this.pnRazonSocial.Name = "pnRazonSocial";
            this.pnRazonSocial.Size = new System.Drawing.Size(381, 32);
            this.pnRazonSocial.TabIndex = 15;
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.BackColor = System.Drawing.SystemColors.Control;
            this.txtRazonSocial.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRazonSocial.Font = new System.Drawing.Font("Arial", 10F);
            this.txtRazonSocial.Location = new System.Drawing.Point(1, 7);
            this.txtRazonSocial.MaxLength = 100;
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.Size = new System.Drawing.Size(378, 16);
            this.txtRazonSocial.TabIndex = 2;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label3.Location = new System.Drawing.Point(7, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 15);
            this.label3.TabIndex = 14;
            this.label3.Text = "Razón social";
            // 
            // pnNombreComercial
            // 
            this.pnNombreComercial.BackColor = System.Drawing.SystemColors.Control;
            this.pnNombreComercial.Controls.Add(this.txtNombreComercial);
            this.pnNombreComercial.Controls.Add(this.label2);
            this.pnNombreComercial.Location = new System.Drawing.Point(7, 79);
            this.pnNombreComercial.Name = "pnNombreComercial";
            this.pnNombreComercial.Size = new System.Drawing.Size(381, 32);
            this.pnNombreComercial.TabIndex = 13;
            // 
            // txtNombreComercial
            // 
            this.txtNombreComercial.BackColor = System.Drawing.SystemColors.Control;
            this.txtNombreComercial.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombreComercial.Font = new System.Drawing.Font("Arial", 10F);
            this.txtNombreComercial.Location = new System.Drawing.Point(1, 7);
            this.txtNombreComercial.MaxLength = 100;
            this.txtNombreComercial.Name = "txtNombreComercial";
            this.txtNombreComercial.Size = new System.Drawing.Size(378, 16);
            this.txtNombreComercial.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(107)))), ((int)(((byte)(247)))));
            this.label2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label2.Location = new System.Drawing.Point(0, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(381, 3);
            this.label2.TabIndex = 9;
            // 
            // lblRazonSocial
            // 
            this.lblRazonSocial.AutoSize = true;
            this.lblRazonSocial.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRazonSocial.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblRazonSocial.Location = new System.Drawing.Point(4, 64);
            this.lblRazonSocial.Name = "lblRazonSocial";
            this.lblRazonSocial.Size = new System.Drawing.Size(109, 15);
            this.lblRazonSocial.TabIndex = 12;
            this.lblRazonSocial.Text = "Nombre comercial";
            // 
            // pnIdentificacion
            // 
            this.pnIdentificacion.BackColor = System.Drawing.SystemColors.Control;
            this.pnIdentificacion.Controls.Add(this.txtRuc);
            this.pnIdentificacion.Controls.Add(this.label7);
            this.pnIdentificacion.Location = new System.Drawing.Point(6, 28);
            this.pnIdentificacion.Name = "pnIdentificacion";
            this.pnIdentificacion.Size = new System.Drawing.Size(188, 32);
            this.pnIdentificacion.TabIndex = 10;
            // 
            // txtRuc
            // 
            this.txtRuc.BackColor = System.Drawing.SystemColors.Control;
            this.txtRuc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRuc.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRuc.Location = new System.Drawing.Point(1, 6);
            this.txtRuc.MaxLength = 13;
            this.txtRuc.Name = "txtRuc";
            this.txtRuc.Size = new System.Drawing.Size(185, 19);
            this.txtRuc.TabIndex = 1;
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
            // lblRuc
            // 
            this.lblRuc.AutoSize = true;
            this.lblRuc.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRuc.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblRuc.Location = new System.Drawing.Point(3, 13);
            this.lblRuc.Name = "lblRuc";
            this.lblRuc.Size = new System.Drawing.Size(40, 15);
            this.lblRuc.TabIndex = 9;
            this.lblRuc.Text = "R.U.C";
            // 
            // tcEmpresa
            // 
            this.tcEmpresa.Controls.Add(this.tpEmpresa);
            this.tcEmpresa.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcEmpresa.Location = new System.Drawing.Point(14, 71);
            this.tcEmpresa.Name = "tcEmpresa";
            this.tcEmpresa.SelectedIndex = 0;
            this.tcEmpresa.Size = new System.Drawing.Size(410, 312);
            this.tcEmpresa.TabIndex = 0;
            // 
            // pnHeader
            // 
            this.pnHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(46)))), ((int)(((byte)(140)))));
            this.pnHeader.Controls.Add(this.pictureBox1);
            this.pnHeader.Controls.Add(this.panel2);
            this.pnHeader.Controls.Add(this.lblTitulo);
            this.pnHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnHeader.Location = new System.Drawing.Point(0, 0);
            this.pnHeader.Name = "pnHeader";
            this.pnHeader.Size = new System.Drawing.Size(439, 60);
            this.pnHeader.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HendrixAccountant.Properties.Resources.configWhite25;
            this.pictureBox1.Location = new System.Drawing.Point(100, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 25);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(184)))), ((int)(((byte)(39)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 55);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(439, 5);
            this.panel2.TabIndex = 2;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.Window;
            this.lblTitulo.Location = new System.Drawing.Point(127, 19);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(230, 19);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Parámetros de configuración";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmParametros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(439, 392);
            this.Controls.Add(this.pnHeader);
            this.Controls.Add(this.tcEmpresa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(5, 5);
            this.Name = "frmParametros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "PARÁMETROS";
            this.Activated += new System.EventHandler(this.frmParametros_Activated);
            this.Load += new System.EventHandler(this.frmParametros_Load);
            this.tpEmpresa.ResumeLayout(false);
            this.tpEmpresa.PerformLayout();
            this.pnDireccionEstablecimiento.ResumeLayout(false);
            this.pnDireccionEstablecimiento.PerformLayout();
            this.pnRazonSocial.ResumeLayout(false);
            this.pnRazonSocial.PerformLayout();
            this.pnNombreComercial.ResumeLayout(false);
            this.pnNombreComercial.PerformLayout();
            this.pnIdentificacion.ResumeLayout(false);
            this.pnIdentificacion.PerformLayout();
            this.tcEmpresa.ResumeLayout(false);
            this.pnHeader.ResumeLayout(false);
            this.pnHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tpEmpresa;
        private System.Windows.Forms.TabControl tcEmpresa;
        private System.Windows.Forms.Panel pnHeader;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel pnIdentificacion;
        private UIControls.NumericInput txtRuc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblRuc;
        private System.Windows.Forms.Panel pnRazonSocial;
        private UIControls.TextInput txtRazonSocial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnNombreComercial;
        private UIControls.TextInput txtNombreComercial;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblRazonSocial;
        private System.Windows.Forms.Panel pnDireccionEstablecimiento;
        private UIControls.TextInput txtDireccion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.CheckBox chkEditar;
    }
}