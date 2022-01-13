using HendrixAccountant.ApplicationCore.DTOs;
using HendrixAccountant.ApplicationCore.Entities;
using HendrixAccountant.ApplicationCore.Models;
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
            if (!Validator.DatasetIsValid(data)) return null;
            
            List<Product> products = null;
            try
            {
                products = data.Tables[0].AsEnumerable().Select(field => new Product
                {
                    id_producto = Convert.ToInt32(field["idProducto"].ToString()),
                    nombre = field["nombre"].ToString(),
                    codigo = field["codigo"].ToString(),
                    descripcion = field["descripcion"].ToString(),
                    stock = Convert.ToInt32(field["stock"].ToString()),
                    costo = Convert.ToDecimal(field["costo"].ToString(), Utils.GetCulture()),
                    precio_venta = Convert.ToDecimal(field["precio"].ToString(), Utils.GetCulture()),
                    id_talla = Convert.ToInt32(field["idTalla"].ToString()),
                    talla = field["talla"].ToString(),
                    categoria_id = Convert.ToInt32(field["idCategoria"].ToString()),
                    categoria = field["categoria"].ToString(),
                    proveedor_id = Convert.ToInt32(field["idProveedor"].ToString()),
                    proveedor = field["nombreProveedor"].ToString(),
                    es_servicio = Convert.ToBoolean(field["es_servicio"].ToString()),

                    tarifa_iva = Convert.ToInt32(field["tarifa_iva"].ToString())
                }).ToList();
            }
            catch (Exception ex)
            {
                Utils.GrabarLog("DatasetToProducts", ex.ToString());
            }
            return products;
        }

        public ProductIdentityDto DatasetToProduct(DataSet data)
        {
            if (!Validator.DatasetIsValid(data)) return null;

            ProductIdentityDto product = null;
            try
            {
                product = data.Tables[0].AsEnumerable().Select(field => new ProductIdentityDto
                {
                    IdProducto = Convert.ToInt32(field["idProducto"].ToString()),
                    Nombre = field["nombre"].ToString(),
                    Codigo = field["codigo"].ToString(),
                    Stock = Convert.ToInt32(field["stock"].ToString()),
                    Precio = Convert.ToDecimal(field["precio"].ToString(), Utils.GetCulture()),
                    EsServicio = Convert.ToBoolean(field["es_servicio"].ToString()),
                    TarifaIva = Convert.ToInt32(field["tarifa_iva"].ToString())
                }).FirstOrDefault();
            }
            catch (Exception ex)
            {
                Utils.GrabarLog("DatasetToProduct", ex.ToString());
            }

            return product;
        }


        public List<BarcodeCard> DatasetToBarcodes(DataSet data)
        {
            if (!Validator.DatasetIsValid(data)) return null;

            List<BarcodeCard> barcodes = null;
            try
            {
                barcodes = data.Tables[0].AsEnumerable().Select(field => new BarcodeCard
                {
                    Codigo = field["codigo"].ToString(),
                    NombreProducto = field["nombre"].ToString(),
                    Precio = field["precio"].ToString()
                }).ToList();
            }
            catch (Exception ex)
            {
                Utils.GrabarLog("DatasetToBarcodes", ex.ToString());
            }
            return barcodes;
        }

    }
}
