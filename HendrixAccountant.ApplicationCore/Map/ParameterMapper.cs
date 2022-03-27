using HendrixAccountant.ApplicationCore.Models;
using HendrixAccountant.Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace HendrixAccountant.ApplicationCore.Map
{
    public class ParameterMapper
    {
        public List<Parameters> DatasetToParameters(DataSet data)
        {
            if (!Validator.DatasetIsValid(data)) return null;

            List<Parameters> parameters = new List<Parameters>();
            try
            {
                parameters = data.Tables[0].AsEnumerable().Select(field => new Parameters
                {
                    Nombre = field["nombre"].ToString(),
                    Valor = field["valor"].ToString(),
                    JsonValue = field["json"].ToString(),
                }).ToList();
            }
            catch (Exception ex)
            {
                Utils.GrabarLog("DatasetToParameters", ex.ToString());
            }
            return parameters;
        }

        public List<Parameters> DatasetToSequential(DataSet data)
        {
            if (!Validator.DatasetIsValid(data)) return null;

            List<Parameters> parameters = new List<Parameters>();
            try
            {
                parameters = data.Tables[0].AsEnumerable().Select(field => new Parameters
                {
                    Nombre = field["nombre"].ToString(),
                    Valor = field["valor"].ToString()
                }).ToList();
            }
            catch (Exception ex)
            {
                Utils.GrabarLog("DatasetToSequential", ex.ToString());
            }
            return parameters;
        }
    }
}
