using HendrixAccountant.ApplicationCore.Entities;
using HendrixAccountant.Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace HendrixAccountant.ApplicationCore.Map
{
    public class KardexMapper
    {
        public List<Kardex> DatasetToKardex(DataSet data)
        {
            if (!Validator.DatasetIsValid(data)) return null;

            List<Kardex> kardex = null;
            try
            {
                kardex = data.Tables[0].AsEnumerable().Select(field => new Kardex
                {
                    Date = field["fecha"].ToString(),
                    Name = field["nombre"].ToString(),
                    Secuential = field["secuencial"].ToString(),
                    Quantity = int.Parse(field["cantidad"].ToString()),
                    UnitValue = Convert.ToDecimal(field["valorUnit"].ToString(), Utils.GetCulture()),
                    TotalItem = Convert.ToDecimal(field["totalItem"].ToString(), Utils.GetCulture()),
                }).ToList();
            }
            catch (Exception ex)
            {
                Utils.GrabarLog("DatasetToKardex", ex.ToString());
            }
            return kardex;
        }
    }
}
