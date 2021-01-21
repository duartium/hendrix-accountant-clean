using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HendrixAccountant.ApplicationCore.Map
{
    public class Validator
    {
        public static bool DatasetIsValid(System.Data.DataSet data)
        {
            bool resp = true;
            if (data == null) resp = false;
            if (data.Tables.Count <= 0) resp = false;
            if (data.Tables[0].Rows.Count <= 0) resp = false; // solo recorrer la primera tabla
            return resp;
        }
    }
}
