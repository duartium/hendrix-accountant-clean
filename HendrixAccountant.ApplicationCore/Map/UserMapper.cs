using HendrixAccountant.Common;
using HendrixAccountant.Data.Dtos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HendrixAccountant.ApplicationCore.Map
{
    public class UserMapper
    {
        public List<UserDto> DatasetToUsers(DataSet data)
        {
            if (!Validator.DatasetIsValid(data))
                return null;

            List<UserDto> products = null;
            try
            {
                products = data.Tables[0].AsEnumerable().Select(field => new UserDto
                {
                    IdUsuario = Convert.ToInt32(field["idUsuario"].ToString()),
                    Usuario = field["usuario"].ToString(),
                    FechaCreacion = field["creadoEn"].ToString()
                }).ToList();
            }
            catch (Exception ex )
            {
                Utils.GrabarLog("DatasetToUsers", ex.ToString());
            }
            return products;
        }
    }
}

