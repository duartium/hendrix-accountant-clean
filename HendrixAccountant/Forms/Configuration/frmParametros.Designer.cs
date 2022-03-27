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
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pnRazonSocial = new System.Windows.Forms.Panel();
            this.txtRazonSocial = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pnNombreComercial = new System.Windows.Forms.Panel();
            this.txtNombreComercial = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblRazonSocial = new System.Windows.Forms.Label();
            this.pnIdentificacion = new System.Windows.Forms.Panel();
            this.txtRuc = new HendrixAccountant.UIControls.NumericInput();
            this.label7 = new System.Windows.Forms.Label();
            this.lblRuc = new System.Windows.Forms.Label();
            this.tcParametros = new System.Windows.Forms.TabControl();
            this.tpImpresora = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbImpresoraEtiquetas = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbImpresoras = new System.Windows.Forms.ComboBox();
            this.btnGuardarParamsImp = new System.Windows.Forms.Button();
            this.lblTarifaIva = new System.Windows.Forms.Label();
            this.cmbModoImpresion = new System.Windows.Forms.ComboBox();
            this.gbTipo = new System.Windows.Forms.GroupBox();
            this.rbTicket = new System.Windows.Forms.RadioButton();
            this.rbA4 = new System.Windows.Forms.RadioButton();
            this.tpFacturacion = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtSecuencialAct = new HendrixAccountant.UIControls.NumericInput();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbSistema = new System.Windows.Forms.RadioButton();
            this.rbSri = new System.Windows.Forms.RadioButton();
            this.btnGuardarParmsFact = new System.Windows.Forms.Button();
            this.pnHeader = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.tpEmpresa.SuspendLayout();
            this.pnDireccionEstablecimiento.SuspendLayout();
            this.pnRazonSocial.SuspendLayout();
            this.pnNombreComercial.SuspendLayout();
            this.pnIdentificacion.SuspendLayout();
            this.tcParametros.SuspendLayout();
            this.tpImpresora.SuspendLayout();
            this.gbTipo.SuspendLayout();
            this.tpFacturacion.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
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
            this.tpEmpresa.Location = new System.Drawing.Point(4, 34);
            this.tpEmpresa.Name = "tpEmpresa";
            this.tpEmpresa.Padding = new System.Windows.Forms.Padding(3);
            this.tpEmpresa.Size = new System.Drawing.Size(434, 307);
            this.tpEmpresa.TabIndex = 0;
            this.tpEmpresa.Text = "Empresa";
            this.tpEmpresa.UseVisualStyleBackColor = true;
            // 
            // chkEditar
            // 
            this.chkEditar.AutoSize = true;
            this.chkEditar.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkEditar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(46)))), ((int)(((byte)(140)))));
            this.chkEditar.Location = new System.Drawing.Point(348, 20);
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
            this.btnGuardar.Location = new System.Drawing.Point(317, 258);
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
            this.pnDireccionEstablecimiento.Location = new System.Drawing.Point(26, 210);
            this.pnDireccionEstablecimiento.Name = "pnDireccionEstablecimiento";
            this.pnDireccionEstablecimiento.Size = new System.Drawing.Size(381, 32);
            this.pnDireccionEstablecimiento.TabIndex = 17;
            // 
            // txtDireccion
            // 
            this.txtDireccion.BackColor = System.Drawing.SystemColors.Control;
            this.txtDireccion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDireccion.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.Location = new System.Drawing.Point(8, 8);
            this.txtDireccion.MaxLength = 150;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(362, 15);
            this.txtDireccion.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(107)))), ((int)(((byte)(247)))));
            this.label4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label4.Location = new System.Drawing.Point(0, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(381, 2);
            this.label4.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label5.Location = new System.Drawing.Point(23, 194);
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
            this.pnRazonSocial.Location = new System.Drawing.Point(25, 151);
            this.pnRazonSocial.Name = "pnRazonSocial";
            this.pnRazonSocial.Size = new System.Drawing.Size(381, 32);
            this.pnRazonSocial.TabIndex = 15;
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.BackColor = System.Drawing.SystemColors.Control;
            this.txtRazonSocial.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRazonSocial.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRazonSocial.Location = new System.Drawing.Point(8, 8);
            this.txtRazonSocial.MaxLength = 150;
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.Size = new System.Drawing.Size(362, 15);
            this.txtRazonSocial.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(107)))), ((int)(((byte)(247)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Location = new System.Drawing.Point(0, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(381, 2);
            this.label1.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label3.Location = new System.Drawing.Point(22, 135);
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
            this.pnNombreComercial.Location = new System.Drawing.Point(22, 93);
            this.pnNombreComercial.Name = "pnNombreComercial";
            this.pnNombreComercial.Size = new System.Drawing.Size(385, 32);
            this.pnNombreComercial.TabIndex = 13;
            // 
            // txtNombreComercial
            // 
            this.txtNombreComercial.BackColor = System.Drawing.SystemColors.Control;
            this.txtNombreComercial.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombreComercial.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreComercial.Location = new System.Drawing.Point(7, 8);
            this.txtNombreComercial.MaxLength = 150;
            this.txtNombreComercial.Name = "txtNombreComercial";
            this.txtNombreComercial.Size = new System.Drawing.Size(362, 15);
            this.txtNombreComercial.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(107)))), ((int)(((byte)(247)))));
            this.label2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label2.Location = new System.Drawing.Point(0, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(385, 2);
            this.label2.TabIndex = 9;
            // 
            // lblRazonSocial
            // 
            this.lblRazonSocial.AutoSize = true;
            this.lblRazonSocial.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRazonSocial.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblRazonSocial.Location = new System.Drawing.Point(19, 77);
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
            this.pnIdentificacion.Location = new System.Drawing.Point(21, 38);
            this.pnIdentificacion.Name = "pnIdentificacion";
            this.pnIdentificacion.Size = new System.Drawing.Size(188, 32);
            this.pnIdentificacion.TabIndex = 10;
            // 
            // txtRuc
            // 
            this.txtRuc.BackColor = System.Drawing.SystemColors.Control;
            this.txtRuc.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRuc.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRuc.Location = new System.Drawing.Point(8, 6);
            this.txtRuc.MaxLength = 13;
            this.txtRuc.Name = "txtRuc";
            this.txtRuc.Size = new System.Drawing.Size(178, 19);
            this.txtRuc.TabIndex = 1;
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
            // lblRuc
            // 
            this.lblRuc.AutoSize = true;
            this.lblRuc.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRuc.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblRuc.Location = new System.Drawing.Point(18, 22);
            this.lblRuc.Name = "lblRuc";
            this.lblRuc.Size = new System.Drawing.Size(40, 15);
            this.lblRuc.TabIndex = 9;
            this.lblRuc.Text = "R.U.C";
            // 
            // tcParametros
            // 
            this.tcParametros.Controls.Add(this.tpEmpresa);
            this.tcParametros.Controls.Add(this.tpImpresora);
            this.tcParametros.Controls.Add(this.tpFacturacion);
            this.tcParametros.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tcParametros.ItemSize = new System.Drawing.Size(63, 30);
            this.tcParametros.Location = new System.Drawing.Point(17, 80);
            this.tcParametros.Name = "tcParametros";
            this.tcParametros.SelectedIndex = 0;
            this.tcParametros.Size = new System.Drawing.Size(442, 345);
            this.tcParametros.TabIndex = 0;
            this.tcParametros.SelectedIndexChanged += new System.EventHandler(this.tcEmpresa_SelectedIndexChanged);
            // 
            // tpImpresora
            // 
            this.tpImpresora.Controls.Add(this.label8);
            this.tpImpresora.Controls.Add(this.cmbImpresoraEtiquetas);
            this.tpImpresora.Controls.Add(this.label6);
            this.tpImpresora.Controls.Add(this.cmbImpresoras);
            this.tpImpresora.Controls.Add(this.btnGuardarParamsImp);
            this.tpImpresora.Controls.Add(this.lblTarifaIva);
            this.tpImpresora.Controls.Add(this.cmbModoImpresion);
            this.tpImpresora.Controls.Add(this.gbTipo);
            this.tpImpresora.Location = new System.Drawing.Point(4, 34);
            this.tpImpresora.Name = "tpImpresora";
            this.tpImpresora.Padding = new System.Windows.Forms.Padding(3);
            this.tpImpresora.Size = new System.Drawing.Size(434, 307);
            this.tpImpresora.TabIndex = 1;
            this.tpImpresora.Text = "Impresión";
            this.tpImpresora.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label8.Location = new System.Drawing.Point(20, 160);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(135, 15);
            this.label8.TabIndex = 105;
            this.label8.Text = "Impresora de etiquetas";
            // 
            // cmbImpresoraEtiquetas
            // 
            this.cmbImpresoraEtiquetas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbImpresoraEtiquetas.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbImpresoraEtiquetas.FormattingEnabled = true;
            this.cmbImpresoraEtiquetas.Items.AddRange(new object[] {
            "Impresión directa",
            "Previsualizar comprobante",
            "Impresión directa y luego Previsualizar"});
            this.cmbImpresoraEtiquetas.Location = new System.Drawing.Point(23, 179);
            this.cmbImpresoraEtiquetas.Name = "cmbImpresoraEtiquetas";
            this.cmbImpresoraEtiquetas.Size = new System.Drawing.Size(262, 24);
            this.cmbImpresoraEtiquetas.TabIndex = 104;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label6.Location = new System.Drawing.Point(20, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 15);
            this.label6.TabIndex = 103;
            this.label6.Text = "Impresora principal";
            // 
            // cmbImpresoras
            // 
            this.cmbImpresoras.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbImpresoras.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbImpresoras.FormattingEnabled = true;
            this.cmbImpresoras.Items.AddRange(new object[] {
            "Impresión directa",
            "Previsualizar comprobante",
            "Impresión directa y luego Previsualizar"});
            this.cmbImpresoras.Location = new System.Drawing.Point(23, 39);
            this.cmbImpresoras.Name = "cmbImpresoras";
            this.cmbImpresoras.Size = new System.Drawing.Size(262, 24);
            this.cmbImpresoras.TabIndex = 102;
            // 
            // btnGuardarParamsImp
            // 
            this.btnGuardarParamsImp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(89)))));
            this.btnGuardarParamsImp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardarParamsImp.FlatAppearance.BorderSize = 0;
            this.btnGuardarParamsImp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarParamsImp.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarParamsImp.ForeColor = System.Drawing.SystemColors.Window;
            this.btnGuardarParamsImp.Image = global::HendrixAccountant.Properties.Resources.saveWhite20;
            this.btnGuardarParamsImp.Location = new System.Drawing.Point(316, 255);
            this.btnGuardarParamsImp.Name = "btnGuardarParamsImp";
            this.btnGuardarParamsImp.Size = new System.Drawing.Size(90, 30);
            this.btnGuardarParamsImp.TabIndex = 101;
            this.btnGuardarParamsImp.Text = "Guardar";
            this.btnGuardarParamsImp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardarParamsImp.UseVisualStyleBackColor = false;
            this.btnGuardarParamsImp.Click += new System.EventHandler(this.btnGuardarParamsImp_Click);
            // 
            // lblTarifaIva
            // 
            this.lblTarifaIva.AutoSize = true;
            this.lblTarifaIva.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTarifaIva.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblTarifaIva.Location = new System.Drawing.Point(20, 223);
            this.lblTarifaIva.Name = "lblTarifaIva";
            this.lblTarifaIva.Size = new System.Drawing.Size(140, 15);
            this.lblTarifaIva.TabIndex = 100;
            this.lblTarifaIva.Text = "Modalidad de impresión";
            this.lblTarifaIva.Visible = false;
            // 
            // cmbModoImpresion
            // 
            this.cmbModoImpresion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbModoImpresion.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbModoImpresion.FormattingEnabled = true;
            this.cmbModoImpresion.Items.AddRange(new object[] {
            "Impresión directa",
            "Previsualizar comprobante",
            "Impresión directa y luego previsualizar"});
            this.cmbModoImpresion.Location = new System.Drawing.Point(23, 242);
            this.cmbModoImpresion.Name = "cmbModoImpresion";
            this.cmbModoImpresion.Size = new System.Drawing.Size(262, 24);
            this.cmbModoImpresion.TabIndex = 99;
            this.cmbModoImpresion.Visible = false;
            // 
            // gbTipo
            // 
            this.gbTipo.Controls.Add(this.rbTicket);
            this.gbTipo.Controls.Add(this.rbA4);
            this.gbTipo.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbTipo.ForeColor = System.Drawing.SystemColors.GrayText;
            this.gbTipo.Location = new System.Drawing.Point(23, 80);
            this.gbTipo.Name = "gbTipo";
            this.gbTipo.Size = new System.Drawing.Size(181, 63);
            this.gbTipo.TabIndex = 98;
            this.gbTipo.TabStop = false;
            this.gbTipo.Text = "Formato comprobante de venta";
            // 
            // rbTicket
            // 
            this.rbTicket.AutoSize = true;
            this.rbTicket.Checked = true;
            this.rbTicket.ForeColor = System.Drawing.Color.Black;
            this.rbTicket.Location = new System.Drawing.Point(77, 28);
            this.rbTicket.Name = "rbTicket";
            this.rbTicket.Size = new System.Drawing.Size(84, 20);
            this.rbTicket.TabIndex = 4;
            this.rbTicket.TabStop = true;
            this.rbTicket.Text = "Ticket 80mm";
            this.rbTicket.UseVisualStyleBackColor = true;
            // 
            // rbA4
            // 
            this.rbA4.AutoSize = true;
            this.rbA4.ForeColor = System.Drawing.Color.Black;
            this.rbA4.Location = new System.Drawing.Point(14, 28);
            this.rbA4.Name = "rbA4";
            this.rbA4.Size = new System.Drawing.Size(39, 20);
            this.rbA4.TabIndex = 3;
            this.rbA4.Text = "A4";
            this.rbA4.UseVisualStyleBackColor = true;
            // 
            // tpFacturacion
            // 
            this.tpFacturacion.Controls.Add(this.panel1);
            this.tpFacturacion.Controls.Add(this.label9);
            this.tpFacturacion.Controls.Add(this.groupBox1);
            this.tpFacturacion.Controls.Add(this.btnGuardarParmsFact);
            this.tpFacturacion.Location = new System.Drawing.Point(4, 34);
            this.tpFacturacion.Name = "tpFacturacion";
            this.tpFacturacion.Size = new System.Drawing.Size(434, 307);
            this.tpFacturacion.TabIndex = 2;
            this.tpFacturacion.Text = "Facturación";
            this.tpFacturacion.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.txtSecuencialAct);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Location = new System.Drawing.Point(259, 53);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(111, 32);
            this.panel1.TabIndex = 109;
            // 
            // txtSecuencialAct
            // 
            this.txtSecuencialAct.BackColor = System.Drawing.SystemColors.Control;
            this.txtSecuencialAct.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSecuencialAct.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSecuencialAct.Location = new System.Drawing.Point(10, 6);
            this.txtSecuencialAct.MaxLength = 13;
            this.txtSecuencialAct.Name = "txtSecuencialAct";
            this.txtSecuencialAct.Size = new System.Drawing.Size(91, 19);
            this.txtSecuencialAct.TabIndex = 1;
            this.txtSecuencialAct.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(107)))), ((int)(((byte)(247)))));
            this.label10.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label10.Location = new System.Drawing.Point(0, 30);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(111, 2);
            this.label10.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label9.Location = new System.Drawing.Point(262, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 15);
            this.label9.TabIndex = 108;
            this.label9.Text = "Secuencial Actual";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbSistema);
            this.groupBox1.Controls.Add(this.rbSri);
            this.groupBox1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.groupBox1.Location = new System.Drawing.Point(22, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(181, 63);
            this.groupBox1.TabIndex = 107;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo de Secuencial";
            // 
            // rbSistema
            // 
            this.rbSistema.AutoSize = true;
            this.rbSistema.Checked = true;
            this.rbSistema.ForeColor = System.Drawing.Color.Black;
            this.rbSistema.Location = new System.Drawing.Point(77, 28);
            this.rbSistema.Name = "rbSistema";
            this.rbSistema.Size = new System.Drawing.Size(73, 20);
            this.rbSistema.TabIndex = 4;
            this.rbSistema.TabStop = true;
            this.rbSistema.Text = "SISTEMA";
            this.rbSistema.UseVisualStyleBackColor = true;
            this.rbSistema.CheckedChanged += new System.EventHandler(this.rbSistema_CheckedChanged);
            // 
            // rbSri
            // 
            this.rbSri.AutoSize = true;
            this.rbSri.ForeColor = System.Drawing.Color.Black;
            this.rbSri.Location = new System.Drawing.Point(14, 28);
            this.rbSri.Name = "rbSri";
            this.rbSri.Size = new System.Drawing.Size(44, 20);
            this.rbSri.TabIndex = 3;
            this.rbSri.Text = "SRI";
            this.rbSri.UseVisualStyleBackColor = true;
            this.rbSri.CheckedChanged += new System.EventHandler(this.rbSri_CheckedChanged);
            // 
            // btnGuardarParmsFact
            // 
            this.btnGuardarParmsFact.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(89)))));
            this.btnGuardarParmsFact.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardarParmsFact.FlatAppearance.BorderSize = 0;
            this.btnGuardarParmsFact.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarParmsFact.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarParmsFact.ForeColor = System.Drawing.SystemColors.Window;
            this.btnGuardarParmsFact.Image = global::HendrixAccountant.Properties.Resources.saveWhite20;
            this.btnGuardarParmsFact.Location = new System.Drawing.Point(316, 255);
            this.btnGuardarParmsFact.Name = "btnGuardarParmsFact";
            this.btnGuardarParmsFact.Size = new System.Drawing.Size(90, 30);
            this.btnGuardarParmsFact.TabIndex = 106;
            this.btnGuardarParmsFact.Text = "Guardar";
            this.btnGuardarParmsFact.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardarParmsFact.UseVisualStyleBackColor = false;
            this.btnGuardarParmsFact.Click += new System.EventHandler(this.btnGuardarParmsFact_Click);
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
            this.pnHeader.Size = new System.Drawing.Size(479, 60);
            this.pnHeader.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HendrixAccountant.Properties.Resources.configWhite25;
            this.pictureBox1.Location = new System.Drawing.Point(103, 15);
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
            this.panel2.Size = new System.Drawing.Size(479, 5);
            this.panel2.TabIndex = 2;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.Window;
            this.lblTitulo.Location = new System.Drawing.Point(130, 19);
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
            this.ClientSize = new System.Drawing.Size(479, 451);
            this.Controls.Add(this.pnHeader);
            this.Controls.Add(this.tcParametros);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(5, 5);
            this.Name = "frmParametros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "CONFIGURACIÓN";
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
            this.tcParametros.ResumeLayout(false);
            this.tpImpresora.ResumeLayout(false);
            this.tpImpresora.PerformLayout();
            this.gbTipo.ResumeLayout(false);
            this.gbTipo.PerformLayout();
            this.tpFacturacion.ResumeLayout(false);
            this.tpFacturacion.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnHeader.ResumeLayout(false);
            this.pnHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tpEmpresa;
        private System.Windows.Forms.TabControl tcParametros;
        private System.Windows.Forms.Panel pnHeader;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel pnIdentificacion;
        private UIControls.NumericInput txtRuc;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblRuc;
        private System.Windows.Forms.Panel pnRazonSocial;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnNombreComercial;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblRazonSocial;
        private System.Windows.Forms.Panel pnDireccionEstablecimiento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.CheckBox chkEditar;
        private System.Windows.Forms.TabPage tpImpresora;
        private System.Windows.Forms.GroupBox gbTipo;
        private System.Windows.Forms.RadioButton rbTicket;
        private System.Windows.Forms.RadioButton rbA4;
        private System.Windows.Forms.Label lblTarifaIva;
        private System.Windows.Forms.ComboBox cmbModoImpresion;
        private System.Windows.Forms.Button btnGuardarParamsImp;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbImpresoras;
        private System.Windows.Forms.TextBox txtNombreComercial;
        private System.Windows.Forms.TextBox txtRazonSocial;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbImpresoraEtiquetas;
        private System.Windows.Forms.TabPage tpFacturacion;
        private System.Windows.Forms.Button btnGuardarParmsFact;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbSistema;
        private System.Windows.Forms.RadioButton rbSri;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel1;
        private UIControls.NumericInput txtSecuencialAct;
        private System.Windows.Forms.Label label10;
    }
}