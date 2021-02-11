using HendrixAccountant.ApplicationCore.DTOs;
using HendrixAccountant.Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HendrixAccountant.ApplicationCore.Map
{
    public class SizeMapper
    {
        public List<SizeDto> DatasetToSizes(DataSet data)
        {
            if (!Validator.DatasetIsValid(data)) return null;
            List<SizeDto> categories = null;
            try
            {
                categories = data.Tables[0].AsEnumerable().Select(field => new SizeDto
                {
                    IdTalla = Convert.ToInt32(field["id"].ToString()),
                    Codigo = field["codigo"].ToString(),
                    Descripcion = field["descripcion"].ToString()
                }).ToList();
            }
            catch (Exception ex)
            {
                Utils.GrabarLog("DatasetToSizes", ex.ToString());
            }
            return categories;
        }
    }
}
