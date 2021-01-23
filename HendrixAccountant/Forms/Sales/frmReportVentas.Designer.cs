namespace HendrixAccountant.Forms
{
    partial class frmReportVentas
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
            this.rptViewerVentas = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rptViewerVentas
            // 
            this.rptViewerVentas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rptViewerVentas.LocalReport.ReportEmbeddedResource = "HendrixAccountant.Reports.rptFacturaVenta.rdlc";
            this.rptViewerVentas.Location = new System.Drawing.Point(0, 0);
            this.rptViewerVentas.Name = "rptViewerVentas";
            this.rptViewerVentas.ServerReport.BearerToken = null;
            this.rptViewerVentas.Size = new System.Drawing.Size(800, 450);
            this.rptViewerVentas.TabIndex = 0;
            // 
            // frmReportVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rptViewerVentas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmReportVentas";
            this.Text = "REPORTE DE VENTA";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmReportVentas_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rptViewerVentas;
    }
}