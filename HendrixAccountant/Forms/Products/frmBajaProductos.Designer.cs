
namespace HendrixAccountant.Forms.Products
{
    partial class frmBajaProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBajaProductos));
            this.pnIdentificacion = new System.Windows.Forms.Panel();
            this.txtCantidad = new HendrixAccountant.UIControls.NumericInput();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDarBaja = new System.Windows.Forms.Button();
            this.pnCodProveedor = new System.Windows.Forms.Panel();
            this.txtCodProducto = new HendrixAccountant.UIControls.NumericInput();
            this.lblPnCodigoProv = new System.Windows.Forms.Label();
            this.pnNombreProveedor = new System.Windows.Forms.Panel();
            this.txtNombreProducto = new HendrixAccountant.UIControls.TextInput();
            this.lblPnNombreProv = new System.Windows.Forms.Label();
            this.cboMotivo = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnDireccion = new System.Windows.Forms.Panel();
            this.txtOtroMotivo = new System.Windows.Forms.TextBox();
            this.lblPnDescripcion = new System.Windows.Forms.Label();
            this.lblOtroMotivo = new System.Windows.Forms.Label();
            this.btnBuscarProductos = new System.Windows.Forms.Button();
            this.pnIdentificacion.SuspendLayout();
            this.pnCodProveedor.SuspendLayout();
            this.pnNombreProveedor.SuspendLayout();
            this.pnDireccion.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnIdentificacion
            // 
            this.pnIdentificacion.BackColor = System.Drawing.SystemColors.Control;
            this.pnIdentificacion.Controls.Add(this.txtCantidad);
            this.pnIdentificacion.Controls.Add(this.label1);
            this.pnIdentificacion.Location = new System.Drawing.Point(29, 112);
            this.pnIdentificacion.Name = "pnIdentificacion";
            this.pnIdentificacion.Size = new System.Drawing.Size(130, 32);
            this.pnIdentificacion.TabIndex = 105;
            // 
            // txtCantidad
            // 
            this.txtCantidad.BackColor = System.Drawing.SystemColors.Control;
            this.txtCantidad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCantidad.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.Location = new System.Drawing.Point(8, 6);
            this.txtCantidad.MaxLength = 13;
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(98, 19);
            this.txtCantidad.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(107)))), ((int)(((byte)(247)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Location = new System.Drawing.Point(0, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 2);
            this.label1.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label4.Location = new System.Drawing.Point(26, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 15);
            this.label4.TabIndex = 106;
            this.label4.Text = "Cantidad a dar de baja";
            // 
            // btnDarBaja
            // 
            this.btnDarBaja.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnDarBaja.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDarBaja.FlatAppearance.BorderSize = 0;
            this.btnDarBaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDarBaja.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDarBaja.ForeColor = System.Drawing.SystemColors.Window;
            this.btnDarBaja.Image = global::HendrixAccountant.Properties.Resources.trashWhite20;
            this.btnDarBaja.Location = new System.Drawing.Point(416, 168);
            this.btnDarBaja.Name = "btnDarBaja";
            this.btnDarBaja.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnDarBaja.Size = new System.Drawing.Size(140, 32);
            this.btnDarBaja.TabIndex = 104;
            this.btnDarBaja.Text = "Dar de baja";
            this.btnDarBaja.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDarBaja.UseVisualStyleBackColor = false;
            this.btnDarBaja.Click += new System.EventHandler(this.btnDarBaja_Click_1);
            // 
            // pnCodProveedor
            // 
            this.pnCodProveedor.BackColor = System.Drawing.SystemColors.Control;
            this.pnCodProveedor.Controls.Add(this.txtCodProducto);
            this.pnCodProveedor.Controls.Add(this.lblPnCodigoProv);
            this.pnCodProveedor.Location = new System.Drawing.Point(29, 55);
            this.pnCodProveedor.Name = "pnCodProveedor";
            this.pnCodProveedor.Size = new System.Drawing.Size(113, 32);
            this.pnCodProveedor.TabIndex = 99;
            // 
            // txtCodProducto
            // 
            this.txtCodProducto.BackColor = System.Drawing.SystemColors.Control;
            this.txtCodProducto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCodProducto.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodProducto.Location = new System.Drawing.Point(6, 6);
            this.txtCodProducto.MaxLength = 10;
            this.txtCodProducto.Name = "txtCodProducto";
            this.txtCodProducto.Size = new System.Drawing.Size(100, 18);
            this.txtCodProducto.TabIndex = 6;
            this.txtCodProducto.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtCodProducto_KeyDown);
            // 
            // lblPnCodigoProv
            // 
            this.lblPnCodigoProv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(107)))), ((int)(((byte)(247)))));
            this.lblPnCodigoProv.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblPnCodigoProv.Location = new System.Drawing.Point(0, 30);
            this.lblPnCodigoProv.Name = "lblPnCodigoProv";
            this.lblPnCodigoProv.Size = new System.Drawing.Size(113, 2);
            this.lblPnCodigoProv.TabIndex = 9;
            // 
            // pnNombreProveedor
            // 
            this.pnNombreProveedor.BackColor = System.Drawing.SystemColors.Control;
            this.pnNombreProveedor.Controls.Add(this.txtNombreProducto);
            this.pnNombreProveedor.Controls.Add(this.lblPnNombreProv);
            this.pnNombreProveedor.Location = new System.Drawing.Point(156, 55);
            this.pnNombreProveedor.Name = "pnNombreProveedor";
            this.pnNombreProveedor.Size = new System.Drawing.Size(352, 32);
            this.pnNombreProveedor.TabIndex = 100;
            // 
            // txtNombreProducto
            // 
            this.txtNombreProducto.BackColor = System.Drawing.SystemColors.Control;
            this.txtNombreProducto.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNombreProducto.Enabled = false;
            this.txtNombreProducto.Font = new System.Drawing.Font("Arial", 10F);
            this.txtNombreProducto.Location = new System.Drawing.Point(8, 7);
            this.txtNombreProducto.MaxLength = 100;
            this.txtNombreProducto.Name = "txtNombreProducto";
            this.txtNombreProducto.Size = new System.Drawing.Size(335, 16);
            this.txtNombreProducto.TabIndex = 7;
            // 
            // lblPnNombreProv
            // 
            this.lblPnNombreProv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(107)))), ((int)(((byte)(247)))));
            this.lblPnNombreProv.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblPnNombreProv.Location = new System.Drawing.Point(0, 30);
            this.lblPnNombreProv.Name = "lblPnNombreProv";
            this.lblPnNombreProv.Size = new System.Drawing.Size(352, 2);
            this.lblPnNombreProv.TabIndex = 9;
            // 
            // cboMotivo
            // 
            this.cboMotivo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMotivo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMotivo.FormattingEnabled = true;
            this.cboMotivo.Items.AddRange(new object[] {
            "Consumo interno",
            "Producto vencido",
            "Extravío",
            "Otros"});
            this.cboMotivo.Location = new System.Drawing.Point(177, 114);
            this.cboMotivo.Name = "cboMotivo";
            this.cboMotivo.Size = new System.Drawing.Size(267, 24);
            this.cboMotivo.TabIndex = 95;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label3.Location = new System.Drawing.Point(26, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 15);
            this.label3.TabIndex = 103;
            this.label3.Text = "Código";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label7.Location = new System.Drawing.Point(174, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 15);
            this.label7.TabIndex = 96;
            this.label7.Text = "Motivo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label2.Location = new System.Drawing.Point(153, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 15);
            this.label2.TabIndex = 102;
            this.label2.Text = "Nombre del producto";
            // 
            // pnDireccion
            // 
            this.pnDireccion.BackColor = System.Drawing.SystemColors.Control;
            this.pnDireccion.Controls.Add(this.txtOtroMotivo);
            this.pnDireccion.Controls.Add(this.lblPnDescripcion);
            this.pnDireccion.Location = new System.Drawing.Point(29, 168);
            this.pnDireccion.Name = "pnDireccion";
            this.pnDireccion.Size = new System.Drawing.Size(309, 32);
            this.pnDireccion.TabIndex = 97;
            this.pnDireccion.Visible = false;
            // 
            // txtOtroMotivo
            // 
            this.txtOtroMotivo.BackColor = System.Drawing.SystemColors.Control;
            this.txtOtroMotivo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtOtroMotivo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOtroMotivo.Location = new System.Drawing.Point(7, 8);
            this.txtOtroMotivo.MaxLength = 150;
            this.txtOtroMotivo.Name = "txtOtroMotivo";
            this.txtOtroMotivo.Size = new System.Drawing.Size(299, 15);
            this.txtOtroMotivo.TabIndex = 6;
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
            // lblOtroMotivo
            // 
            this.lblOtroMotivo.AutoSize = true;
            this.lblOtroMotivo.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOtroMotivo.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lblOtroMotivo.Location = new System.Drawing.Point(26, 151);
            this.lblOtroMotivo.Name = "lblOtroMotivo";
            this.lblOtroMotivo.Size = new System.Drawing.Size(69, 15);
            this.lblOtroMotivo.TabIndex = 98;
            this.lblOtroMotivo.Text = "Otro motivo";
            this.lblOtroMotivo.Visible = false;
            // 
            // btnBuscarProductos
            // 
            this.btnBuscarProductos.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarProductos.Location = new System.Drawing.Point(514, 54);
            this.btnBuscarProductos.Name = "btnBuscarProductos";
            this.btnBuscarProductos.Size = new System.Drawing.Size(42, 34);
            this.btnBuscarProductos.TabIndex = 101;
            this.btnBuscarProductos.Text = "...";
            this.btnBuscarProductos.UseVisualStyleBackColor = true;
            this.btnBuscarProductos.Click += new System.EventHandler(this.btnBuscarProductos_Click);
            // 
            // frmBajaProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(603, 258);
            this.Controls.Add(this.pnIdentificacion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnDarBaja);
            this.Controls.Add(this.pnCodProveedor);
            this.Controls.Add(this.pnNombreProveedor);
            this.Controls.Add(this.cboMotivo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pnDireccion);
            this.Controls.Add(this.lblOtroMotivo);
            this.Controls.Add(this.btnBuscarProductos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(5, 5);
            this.Name = "frmBajaProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "BAJA DE PRODUCTOS";
            this.Activated += new System.EventHandler(this.frmBajaProductos_Activated);
            this.Load += new System.EventHandler(this.frmBajaProductos_Load);
            this.pnIdentificacion.ResumeLayout(false);
            this.pnIdentificacion.PerformLayout();
            this.pnCodProveedor.ResumeLayout(false);
            this.pnCodProveedor.PerformLayout();
            this.pnNombreProveedor.ResumeLayout(false);
            this.pnNombreProveedor.PerformLayout();
            this.pnDireccion.ResumeLayout(false);
            this.pnDireccion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnIdentificacion;
        private UIControls.NumericInput txtCantidad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDarBaja;
        private System.Windows.Forms.Panel pnCodProveedor;
        private UIControls.NumericInput txtCodProducto;
        private System.Windows.Forms.Label lblPnCodigoProv;
        private System.Windows.Forms.Panel pnNombreProveedor;
        private UIControls.TextInput txtNombreProducto;
        private System.Windows.Forms.Label lblPnNombreProv;
        private System.Windows.Forms.ComboBox cboMotivo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel pnDireccion;
        private System.Windows.Forms.TextBox txtOtroMotivo;
        private System.Windows.Forms.Label lblPnDescripcion;
        private System.Windows.Forms.Label lblOtroMotivo;
        private System.Windows.Forms.Button btnBuscarProductos;
    }
}