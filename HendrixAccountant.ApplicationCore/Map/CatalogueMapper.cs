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
    public class CatalogueMapper
    {
        public List<CatalogueDto> DatasetToCatalogue(DataSet data)
        {
            if (!Validator.DatasetIsValid(data)) return null;

            List<CatalogueDto> catalogue = null;
            try
            {
                catalogue = data.Tables[0].AsEnumerable().Select(field => new CatalogueDto
                {
                    Id = Convert.ToInt32(field["id"].ToString()),
                    Descripcion = field["descripcion"].ToString()
                }).ToList();
            }
            catch (Exception ex)
            {
                Utils.GrabarLog("DatasetToClient", ex.ToString());
            }
            return catalogue;
        }
    }
}
