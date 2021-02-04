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
    public class SupplierMapper
    {
        public SupplierDto DatasetToSupplier(DataSet data)
        {
            if (!Validator.DatasetIsValid(data)) return null;

            SupplierDto supplier = null;
            try
            {
                supplier = data.Tables[0].AsEnumerable().Select(field => new SupplierDto
                {
                    IdProveedor = Convert.ToInt32(field["idProveedor"].ToString()),
                    Ruc = field["ruc"].ToString(),
                    Nombre = field["nombre"].ToString(),
                    Direccion = field["direccion"].ToString(),
                    Email = field["email"].ToString()
                }).FirstOrDefault();
            }
            catch (Exception ex)
            {
                Utils.GrabarLog("DatasetToClient", ex.ToString());
            }
            return supplier;
        }
    }
}
