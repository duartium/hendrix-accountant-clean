using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HendrixAccountant.Forms.PdfViewer
{
    public partial class frmPdfReader : Form
    {
        public frmPdfReader(string pdfName)
        {
            InitializeComponent();
            axAcroPDF1.LoadFile(pdfName);
            //axAcroPDF1.src = pdfName;
        }

        private void frmPdfReader_Load(object sender, EventArgs e)
        {

        }

        [System.Runtime.InteropServices.DllImport("ole32.dll")]
        static extern void CoFreeUnusedLibraries();
        private void frmPdfReader_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (axAcroPDF1 != null)
            {
                axAcroPDF1.Dispose();
                Application.DoEvents();
                CoFreeUnusedLibraries();

                Process[] processes = Process.GetProcessesByName("AcroRd32");
                foreach (Process process in processes)
                {
                    process.Kill();
                }
            }


        }
    }
}
