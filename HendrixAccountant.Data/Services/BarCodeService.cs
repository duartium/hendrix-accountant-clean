using HendrixAccountant.ApplicationCore.Interfaces.Services;
using HendrixAccountant.Common;
using System;
using BarcodeLib;
using System.Drawing;
using System.IO;
using System.Drawing.Imaging;
using System.Security.Permissions;
using HendrixAccountant.ApplicationCore.Constants;

namespace HendrixAccountant.Data.Services
{
    public class BarCodeService : IBarCodeService
    {
        private readonly IParameterService _rpsParameter;
        public BarCodeService()
        {
            _rpsParameter = new ParameterServices();
        }
        public void Generate(string code)
        {
			try
			{
                Barcode barcode = new Barcode();
                barcode.IncludeLabel = true;
                Image imgBarcode = barcode.Encode(TYPE.CODE128, code, Color.Black, Color.White, 300, 120);

                string folderPath = _rpsParameter.Get(CString.PATH_BARCODES);
                if (!Directory.Exists(folderPath))
                    Directory.CreateDirectory(folderPath);

                string ruta = Path.Combine(folderPath, $"PROD_{code}.jpg");
                imgBarcode.Save(ruta, ImageFormat.Jpeg);
            }
            catch (Exception ex)
			{
                Utils.GrabarLog("Generate", ex.ToString());
			}
        }
    }
}
