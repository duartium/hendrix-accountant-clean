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
    public class CategoryMapper
    {
        public List<CategoryDto> DatasetToCategories(DataSet data)
        {
            if (!Validator.DatasetIsValid(data)) return null;

            List<CategoryDto> suppliers = null;
            try
            {
                suppliers = data.Tables[0].AsEnumerable().Select(field => new CategoryDto
                {
                    IdCategoria = Convert.ToInt32(field["idProveedor"].ToString()),
                    Codigo = field["codigo"].ToString(),
                    Nombre = field["nombre"].ToString()
                }).ToList();
            }
            catch (Exception ex)
            {
                Utils.GrabarLog("DatasetToCategory", ex.ToString());
            }
            return suppliers;
        }
    }
}
