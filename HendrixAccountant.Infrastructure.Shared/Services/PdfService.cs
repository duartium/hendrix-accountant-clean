using HendrixAccountant.ApplicationCore.Constants;
using HendrixAccountant.ApplicationCore.Interfaces.Repositories;
using HendrixAccountant.ApplicationCore.Interfaces.Services;
using HendrixAccountant.Common;
using HendrixAccountant.Data.Services;
using iText.IO.Font.Constants;
using iText.IO.Image;
using iText.Kernel.Font;
using iText.Kernel.Geom;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
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
                string folderPathImgs = _rpsParameter.Get(CString.PATH_BARCODES);
                if (!Directory.Exists(folderPath))
                    Directory.CreateDirectory(folderPath);

                if (!Directory.Exists(folderPathImgs))
                    Directory.CreateDirectory(folderPathImgs);

                string path = System.IO.Path.Combine(folderPath, $"PROD_{pdfName}.pdf");
                string pathImg = System.IO.Path.Combine(folderPathImgs, "PROD_asdfasdf.jpg");

                var properties = new WriterProperties();
                properties.SetPdfVersion(PdfVersion.PDF_2_0);

               


                using (PdfWriter wPdf = new PdfWriter(path, properties))
                {
                    var pdfDocument = new PdfDocument(wPdf);
                    var document = new Document(pdfDocument, PageSize.A4);

                    //fuentes
                    PdfFont fontTitle = PdfFontFactory.CreateFont(StandardFonts.HELVETICA_BOLD);
                    PdfFont fontSubtitle = PdfFontFactory.CreateFont(StandardFonts.HELVETICA);

                    //contenido
                    float[] pointColumnWidths = { 120F, 120F, 120F };
                    Table table = new Table(pointColumnWidths);
                    
                    //textos
                    Text productName = new Text("CAMISA TIPO POLO");
                    productName.SetFont(fontTitle);
                    productName.SetFontSize(8);
                    productName.SetTextAlignment(TextAlignment.CENTER);

                    Text price = new Text("$ 45.87");
                    price.SetFont(fontSubtitle);
                    price.SetFontSize(9);
                    price.SetTextAlignment(TextAlignment.CENTER);

                    Text company = new Text("NOVEDADES CHIC BOUTIQUE");
                    company.SetFont(fontSubtitle);
                    company.SetFontSize(6);
                    company.SetTextAlignment(TextAlignment.CENTER);

                    //imagen
                    ImageData imageData = ImageDataFactory.Create(pathImg);
                    //Image image = new Image(imageData).ScaleAbsolute(300, 120).SetFixedPosition(1, 10, 10);
                    Image image = new Image(imageData).SetAutoScale(true);

                    Cell column1 = new Cell();
                    column1.Add(new Paragraph(productName));
                    column1.Add(new Paragraph(price));
                    column1.Add(image);
                    column1.Add(new Paragraph(company));
                    table.AddCell(column1);

                    Cell column2 = new Cell();
                    column2.Add(new Paragraph(productName));
                    column2.Add(new Paragraph(price));
                    column2.Add(image);
                    column2.Add(new Paragraph(company));
                    table.AddCell(column2);

                    Cell column3 = new Cell();
                    column3.Add(new Paragraph(productName));
                    column3.Add(new Paragraph(price));
                    column3.Add(image);
                    column3.Add(new Paragraph(company));
                    table.AddCell(column3);

                    document.Add(table);
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
