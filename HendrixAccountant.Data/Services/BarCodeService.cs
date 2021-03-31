using HendrixAccountant.ApplicationCore.Interfaces.Services;
using HendrixAccountant.Common;
using System;
using BarcodeLib;
using System.Drawing;

namespace HendrixAccountant.Data.Services
{
    public class BarCodeService : IBarCodeService
    {
        public void Generate(string code)
        {
			try
			{
                Barcode barcode = new Barcode();
                barcode.IncludeLabel = true;
                Image img = barcode.Encode(TYPE.CODE128, code, Color.Black, Color.White, 300, 120);

                string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFilesX86) + "";
            }
			catch (Exception ex)
			{
                Utils.GrabarLog("Generate", ex.ToString());
			}
        }
    }
}
