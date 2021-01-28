using HendrixAccountant.ApplicationCore.Entities;
using HendrixAccountant.Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HendrixAccountant.ApplicationCore.Map
{
    public class ProductMapper
    {
        public List<Product> DatasetToProducts(DataSet data) {
            if (!Validator.DatasetIsValid(data))
                return null;
            
            List<Product> products = null;
            try
            {
                products = data.Tables[0].AsEnumerable().Select(field => new Product
                {
                    id_producto = Convert.ToInt32(field["idProducto"].ToString()),
                    nombre = field["nombre"].ToString(),
                    descripcion = field["descripcion"].ToString(),
                    stock = Convert.ToInt32(field["stock"].ToString()),
                    precio_venta = Convert.ToDecimal(field["precio"].ToString(), Utils.GetCulture()),
                    marca = Convert.ToInt32(field["marca"].ToString()),
                    categoria_id = Convert.ToInt32(field["categoria"].ToString())
                }).ToList();
            }
            catch (Exception ex)
            {
                Utils.GrabarLog("DatasetToProducts", ex.ToString());
            }
            return products;
        }
    }
}
