using System;
using System.Threading;
using System.Windows.Forms;

namespace HendrixAccountant.Forms.PdfViewer
{
    public partial class frmPdfViewer : Form
    {
        private string _pdfPath;
        //private bool pageLoaded = false;
        public frmPdfViewer(string pdfPath)
        {
            InitializeComponent();
            _pdfPath = pdfPath;
        }

        private void frmPdfViewer_Load(object sender, EventArgs e)
        {
            try
            {
                //pageLoaded = false;
                webBrowserPdf.AllowNavigation = true;
                //webBrowserPdf.DocumentCompleted += webBrowserPdf_DocumentCompleted;
                webBrowserPdf.Navigate(_pdfPath);
                //waitForPageLoading();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error", ex.ToString());
            }
        }

        private void webBrowserPdf_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            //if ((sender as WebBrowser).ReadyState == WebBrowserReadyState.Complete)
            //{
            //    pageLoaded = true;
            //}
        }

        //private void waitForPageLoading()
        //{
        //    while (pageLoaded == false)
        //    {
        //        Thread.Sleep(3000);// keep sleeping until the page is ready   
        //    }
        //}
    }
}
