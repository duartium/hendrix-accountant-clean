namespace HendrixAccountant
{
    partial class frmBuscarUsuario
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
            this.gbUsuario = new System.Windows.Forms.GroupBox();
            this.lblCodUsuario = new System.Windows.Forms.Label();
            this.txtNombreUsuario = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtCodUsuario = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.colCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColFechaCreacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnConsultar = new HendrixAccountant.UIControls.Buttons.ItemAsideSmall();
            this.btnLimpiar = new HendrixAccountant.UIControls.Buttons.ItemAsideSmall();
            this.gbUsuario.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // gbUsuario
            // 
            this.gbUsuario.Controls.Add(this.lblCodUsuario);
            this.gbUsuario.Controls.Add(this.txtNombreUsuario);
            this.gbUsuario.Controls.Add(this.lblUsuario);
            this.gbUsuario.Controls.Add(this.txtCodUsuario);
            this.gbUsuario.Location = new System.Drawing.Point(8, 12);
            this.gbUsuario.Name = "gbUsuario";
            this.gbUsuario.Size = new System.Drawing.Size(280, 69);
            this.gbUsuario.TabIndex = 29;
            this.gbUsuario.TabStop = false;
            this.gbUsuario.Text = "Usuario";
            // 
            // lblCodUsuario
            // 
            this.lblCodUsuario.AutoSize = true;
            this.lblCodUsuario.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodUsuario.Location = new System.Drawing.Point(6, 20);
            this.lblCodUsuario.Name = "lblCodUsuario";
            this.lblCodUsuario.Size = new System.Drawing.Size(40, 14);
            this.lblCodUsuario.TabIndex = 6;
            this.lblCodUsuario.Text = "Código";
            // 
            // txtNombreUsuario
            // 
            this.txtNombreUsuario.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreUsuario.Location = new System.Drawing.Point(71, 36);
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.Size = new System.Drawing.Size(197, 22);
            this.txtNombreUsuario.TabIndex = 26;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(68, 20);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(98, 14);
            this.lblUsuario.TabIndex = 7;
            this.lblUsuario.Text = "Nombre de usuario";
            // 
            // txtCodUsuario
            // 
            this.txtCodUsuario.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodUsuario.Location = new System.Drawing.Point(8, 36);
            this.txtCodUsuario.Name = "txtCodUsuario";
            this.txtCodUsuario.Size = new System.Drawing.Size(57, 22);
            this.txtCodUsuario.TabIndex = 19;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(46)))), ((int)(((byte)(140)))));
            this.panel1.Controls.Add(this.btnLimpiar);
            this.panel1.Controls.Add(this.btnConsultar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(365, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(127, 296);
            this.panel1.TabIndex = 30;
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.AllowUserToAddRows = false;
            this.dgvUsuarios.AllowUserToResizeRows = false;
            this.dgvUsuarios.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvUsuarios.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(46)))), ((int)(((byte)(140)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUsuarios.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUsuarios.ColumnHeadersHeight = 27;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCodigo,
            this.colUsuario,
            this.ColFechaCreacion});
            this.dgvUsuarios.EnableHeadersVisualStyles = false;
            this.dgvUsuarios.Location = new System.Drawing.Point(8, 91);
            this.dgvUsuarios.MultiSelect = false;
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.RowHeadersVisible = false;
            this.dgvUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsuarios.Size = new System.Drawing.Size(353, 193);
            this.dgvUsuarios.TabIndex = 31;
            this.dgvUsuarios.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuarios_CellDoubleClick);
            // 
            // colCodigo
            // 
            this.colCodigo.HeaderText = "Codigo";
            this.colCodigo.Name = "colCodigo";
            this.colCodigo.ReadOnly = true;
            this.colCodigo.Width = 70;
            // 
            // colUsuario
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.colUsuario.DefaultCellStyle = dataGridViewCellStyle2;
            this.colUsuario.HeaderText = "Nombre de Usuario";
            this.colUsuario.Name = "colUsuario";
            this.colUsuario.ReadOnly = true;
            this.colUsuario.Width = 160;
            // 
            // ColFechaCreacion
            // 
            this.ColFechaCreacion.HeaderText = "Creado en";
            this.ColFechaCreacion.Name = "ColFechaCreacion";
            this.ColFechaCreacion.ReadOnly = true;
            this.ColFechaCreacion.Width = 120;
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(184)))), ((int)(((byte)(39)))));
            this.btnConsultar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsultar.FlatAppearance.BorderSize = 0;
            this.btnConsultar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(184)))), ((int)(((byte)(39)))));
            this.btnConsultar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(184)))), ((int)(((byte)(45)))));
            this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultar.Font = new System.Drawing.Font("Arial", 9F);
            this.btnConsultar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(46)))), ((int)(((byte)(140)))));
            this.btnConsultar.Location = new System.Drawing.Point(0, 18);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(127, 40);
            this.btnConsultar.TabIndex = 1;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = false;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(184)))), ((int)(((byte)(39)))));
            this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(184)))), ((int)(((byte)(39)))));
            this.btnLimpiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(184)))), ((int)(((byte)(45)))));
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Arial", 9F);
            this.btnLimpiar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(46)))), ((int)(((byte)(140)))));
            this.btnLimpiar.Location = new System.Drawing.Point(0, 244);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(127, 40);
            this.btnLimpiar.TabIndex = 2;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // frmBuscarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(492, 296);
            this.Controls.Add(this.dgvUsuarios);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.gbUsuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBuscarUsuario";
            this.Text = "BUSCAR USUARIO";
            this.Load += new System.EventHandler(this.frmBuscarUsuario_Load);
            this.gbUsuario.ResumeLayout(false);
            this.gbUsuario.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbUsuario;
        private System.Windows.Forms.Label lblCodUsuario;
        private System.Windows.Forms.TextBox txtNombreUsuario;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox txtCodUsuario;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColFechaCreacion;
        private UIControls.Buttons.ItemAsideSmall btnConsultar;
        private UIControls.Buttons.ItemAsideSmall btnLimpiar;
    }
}