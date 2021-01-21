using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HendrixAccountant.ApplicationCore.Constants
{
    public class CString
    {
        public const string ENVIRONMENT_LOCAL = "LOCAL";
        public const string ENVIRONMENT_DEV = "DEV";
        public const string ENVIRONMENT_QA = "QA";
        public const string ENVIRONMENT_PROD = "PROD";

        public const string DEFAULT_TITLE = "Notificación";
        public const string QRY_SERIAL = "SELECT * FROM Win32_BaseBoard"; //consulta WQL
        public static string[] DENOMINACIONES = {
            "Billete de $1",        "Billete de $2",        "Billete de $5",
            "Billete de $10",       "Billete de $20",       "Billete de $50",
            "Billete de $100",      "Billete de $500",      "Moneda de $0.01",      
            "Moneda de $0.05",      "Moneda de $0.10",      "Moneda de $0.25",
            "Moneda de $0.50",      "Moneda de $1"
        };
        public const string DEF_FORMAT_DATE = "dd/MM/yyyy";
    }
}
