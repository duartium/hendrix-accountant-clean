
namespace HendrixAccountant.Forms.Sales
{
    partial class frmTicketVenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTicketVenta));
            this.rptViewerTicket = new Telerik.ReportViewer.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rptViewerTicket
            // 
            this.rptViewerTicket.AccessibilityKeyMap = null;
            this.rptViewerTicket.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rptViewerTicket.Location = new System.Drawing.Point(0, 0);
            this.rptViewerTicket.Name = "rptViewerTicket";
            this.rptViewerTicket.Size = new System.Drawing.Size(800, 450);
            this.rptViewerTicket.TabIndex = 0;
            // 
            // frmTicketVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rptViewerTicket);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmTicketVenta";
            this.Text = "TICKET DE VENTA";
            this.Load += new System.EventHandler(this.frmTicketVenta_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Telerik.ReportViewer.WinForms.ReportViewer rptViewerTicket;
    }
}