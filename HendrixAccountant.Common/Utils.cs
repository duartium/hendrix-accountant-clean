using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.IO;
using System.Globalization;
using System.Management;
using System.Xml.Serialization;

namespace HendrixAccountant.Common
{
    public class Constants
    {
        public const string QRY_SERIAL = "SELECT * FROM Win32_BaseBoard"; //consulta WQL
    }
    public class Utils
    {
        public static void GrabarLog(string metodo, string mensaje)
        {
            try
            {
                string path = ConfigurationManager.AppSettings["rutaLogs"].ToString();
                if (!Directory.Exists(path))
                    Directory.CreateDirectory(path);
                string fileName = "Logs_HendrixAccount_" + DateTime.Now.ToString("yyyy-MM-dd") + ".txt";
                using (StreamWriter sw = File.AppendText(path + fileName))
                {
                    sw.WriteLine(DateTime.Now.ToString("yyyy-MM-dd H:mm:ss") + " " + metodo + ": " + mensaje + "\n\r");
                }
            }
            catch (Exception)
            {
            }
        }

        //obtiene el serial mainboard del pc actual
        public static string GetSerial()
        {
            string serialCode = String.Empty;
            try
            {
                var mos = new ManagementObjectSearcher(Constants.QRY_SERIAL);
                foreach (ManagementObject serial in mos.Get())
                    if (serial != null)
                        serialCode = serial.Properties["SerialNumber"].Value.ToString();
            }
            catch (Exception ex)
            {
                Utils.GrabarLog("GetSerial", ex.ToString());
            }
            return serialCode;
        }

        public static string GetValueSetting(string key)
        {
           return ConfigurationManager.AppSettings[key].ToString();
        }

        public bool DatasetIsValid(System.Data.DataSet data)
        {
            bool resp = true;
            if (data == null) resp = false;
            if (data.Tables.Count <= 0) resp = false;
            if (data.Tables[0].Rows.Count <= 0) resp = false; // solo recorrer la primera tabla
            return resp;
        }

        public static string SerializeToXml<T>(T data)
        {
            if (data == null) return String.Empty;
            string result = String.Empty;
            try
            {
                var sWriter = new StringWriter();
                var serializer = new XmlSerializer(typeof(T));
                serializer.Serialize(sWriter, data);
                result = sWriter.ToString();
            }
            catch(Exception ex)
            {
                Utils.GrabarLog("SerializeToXml", ex.ToString());
            }
            return result;
        }

        public static T DeserializeXml<T>(string xml)
        {
            if (String.IsNullOrEmpty(xml)) return default(T);
            T TResult = default(T);
            try
            {
                var stringReader = new StringReader(xml);
                var serializer = new XmlSerializer(typeof(T));
                TResult = (T)serializer.Deserialize(stringReader);
            }
            catch(Exception ex)
            {
                Utils.GrabarLog("SerializeToXml", ex.ToString());
            }
            return TResult;
        }

        public static CultureInfo GetCulture()
        {
            CultureInfo myCI = new CultureInfo("en-US", false);
            CultureInfo myCIclone = (CultureInfo)myCI.Clone();
            //myCIclone.NumberFormat.CurrencySymbol = "USD";
            myCIclone.NumberFormat.NumberDecimalDigits = 2;
            return myCI;
        }

    }
}
