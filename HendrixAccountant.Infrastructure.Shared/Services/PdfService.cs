using HendrixAccountant.ApplicationCore.Constants;
using HendrixAccountant.ApplicationCore.Interfaces.Repositories;
using HendrixAccountant.ApplicationCore.Interfaces.Services;
using HendrixAccountant.Common;
using HendrixAccountant.Data.Services;
using iText.Kernel.Geom;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HendrixAccountant.Infrastructure.Shared.Services
{
    public class PdfService
    {
        private readonly IParameterService _rpsParameter;
        public PdfService()
        {
            _rpsParameter = new ParameterServices();
        }

        public void Generate(string pdfName)
        {
            try
            {
                string folderPath = _rpsParameter.Get(CString.PATH_PDF_BARCODES);
                if (!Directory.Exists(folderPath))
                    Directory.CreateDirectory(folderPath);

                string path = System.IO.Path.Combine(folderPath, $"PROD_{pdfName}.pdf");
                var properties = new WriterProperties();
                properties.SetPdfVersion(PdfVersion.PDF_2_0);

                using (PdfWriter wPdf = new PdfWriter(path, properties))
                {
                    var pdfDocument = new PdfDocument(wPdf);
                    var document = new Document(pdfDocument, PageSize.A4);
                    document.Add(new Paragraph("Listo párrafo"));
                    document.Close();
                    pdfDocument.Close();
                }
            }
            catch (Exception ex)
            {
                Utils.GrabarLog("PdfService>>Generate", ex.ToString());
            }
        }
    }
}
