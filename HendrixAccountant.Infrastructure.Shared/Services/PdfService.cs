using HendrixAccountant.ApplicationCore.Constants;
using HendrixAccountant.ApplicationCore.Interfaces.Repositories;
using HendrixAccountant.ApplicationCore.Interfaces.Services;
using HendrixAccountant.ApplicationCore.Models;
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

        public string Generate(List<BarcodeCard> barcodes)
        {
            try
            {
                string folderPath = _rpsParameter.Get(CString.PATH_PDF_BARCODES);
                string folderPathImgs = _rpsParameter.Get(CString.PATH_BARCODES);
                if (!Directory.Exists(folderPath))
                    Directory.CreateDirectory(folderPath);

                if (!Directory.Exists(folderPathImgs))
                    Directory.CreateDirectory(folderPathImgs);

                string path = String.Empty, pathImg = String.Empty;
                int count = barcodes.Count;
                if (count == 1)
                    path = System.IO.Path.Combine(folderPath, $"PROD_{barcodes.First().Codigo}.pdf");
                else
                    path = System.IO.Path.Combine(folderPath, $"PROD_TODOS_{DateTime.Now.ToString("yyyy_MM_dd")}.pdf");

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
                    float[] pointColumnWidths = null;
                    if (count == 1)
                        pointColumnWidths = new float[]{ 120F };
                    else if(count == 2)
                        pointColumnWidths = new float[] { 120F, 120F };
                    else if (count == 3)
                        pointColumnWidths = new float[] { 120F, 120F, 120F };
                    else if (count > 3)
                        pointColumnWidths = new float[] { 120F, 120F, 120F, 120F };

                    Table table = new Table(pointColumnWidths);

                    //textos
                    Text company = new Text("NOVEDADES CHIC BOUTIQUE");
                    company.SetFont(fontSubtitle);
                    company.SetFontSize(6);
                    company.SetTextAlignment(TextAlignment.CENTER);

                    foreach (var card in barcodes)
                    {
                        pathImg = System.IO.Path.Combine(folderPathImgs, $"PROD_{card.Codigo}.jpg");

                        //card title
                        Text productName = new Text(card.NombreProducto);
                        productName.SetFont(fontTitle);
                        productName.SetFontSize(8);
                        productName.SetTextAlignment(TextAlignment.CENTER);

                        //card price
                        Text price = new Text($"$ {card.Precio}");
                        price.SetFont(fontSubtitle);
                        price.SetFontSize(9);
                        price.SetTextAlignment(TextAlignment.CENTER);


                        //imagen
                        ImageData imageData = ImageDataFactory.Create(pathImg);
                        Image image = new Image(imageData).SetAutoScale(true);

                        Cell column1 = new Cell();
                        column1.Add(new Paragraph(productName).SetTextAlignment(TextAlignment.CENTER));
                        column1.Add(new Paragraph(price).SetTextAlignment(TextAlignment.CENTER));
                        column1.Add(image);
                        column1.Add(new Paragraph(company).SetTextAlignment(TextAlignment.CENTER));
                        table.AddCell(column1);
                    }

                    document.Add(table);
                    document.Close();
                    pdfDocument.Close();

                    return path;
                }
            }
            catch (Exception ex)
            {
                Utils.GrabarLog("PdfService>>Generate", ex.ToString());
                return String.Empty;
            }
        }
    }
}
