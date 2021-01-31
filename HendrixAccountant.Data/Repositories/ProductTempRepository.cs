using HendrixAccountant.ApplicationCore.DTOs;
using HendrixAccountant.ApplicationCore.Entities;
using HendrixAccountant.ApplicationCore.Interfaces.Repositories;
using HendrixAccountant.ApplicationCore.Map;
using HendrixAccountant.Common;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HendrixAccountant.Data.Repositories
{
    public class ProductTempRepository : IProductTempRepository
    {
        private readonly ISqlServer _sqlServer;
        #region  "Nombre de los procedimientos de operación"
        private const string _storeProcedureName = "SP_PRODUCTS";
        private const string SP_STOCK = "SP_STOCK";
        #endregion
        public ProductTempRepository()
        {
            _sqlServer = new DataBase();
        }
        public IEnumerable<Product> GetAll(ProductFilterDto filters)
        {
            var parms = new List<SqlParameter>();
            parms.Add(new SqlParameter("@accion", 'G'));
            parms.Add(new SqlParameter("@idProducto", filters.IdProducto));
            parms.Add(new SqlParameter("@nombre", filters.NombreProducto));
            var dsResp = _sqlServer.ExecuteProcedure(_storeProcedureName, parms);
            return new ProductMapper().DatasetToProducts(dsResp);
        }

        public void UpdateStock(List<StockDto> stock, bool isDecrease)
        {
            string strXmlProducts = CreateXmlProducts(stock);
            if (isDecrease)
            {
                var parms = new List<SqlParameter>();
                parms.Add(new SqlParameter("@accion", 'M'));
                parms.Add(new SqlParameter("@products", strXmlProducts));
                int resp = _sqlServer.ExecuteNonQuery(SP_STOCK, parms);
            }
        }

        public void UpdateStock(StockDto stock, bool isDecrease)
        {
           var parms = new List<SqlParameter>();
           parms.Add(new SqlParameter("@accion", 'U'));
            parms.Add(new SqlParameter("@isDecrease", isDecrease? 1 : 0));
            parms.Add(new SqlParameter("@idProduct", stock.IdProducto));
           parms.Add(new SqlParameter("@quantity", stock.Cantidad));
           int resp = _sqlServer.ExecuteNonQuery(SP_STOCK, parms);
        }

        public bool Save(ProductDto product, bool isUpdate = false)
        {
            char action = 'I';
            if (isUpdate) action = 'M';

            var parms = new List<SqlParameter>();
            parms.Add(new SqlParameter("@accion", action));
            parms.Add(new SqlParameter("@usuario", product.Usuario));
            parms.Add(new SqlParameter("@nombre", product.Nombre));
            parms.Add(new SqlParameter("@descripcion", product.Descripcion));
            parms.Add(new SqlParameter("@costo", product.Costo));
            parms.Add(new SqlParameter("@precioVenta", product.Precio));
            parms.Add(new SqlParameter("@stock", product.Stock));
            parms.Add(new SqlParameter("@descuento", product.Descuento));
            parms.Add(new SqlParameter("@talla", product.IdTalla));
            parms.Add(new SqlParameter("@idProveedor", product.IdProveedor));
            parms.Add(new SqlParameter("@idCategoria", product.IdCategoria));
            if (isUpdate) parms.Add(new SqlParameter("@idProduct", product.IdProducto));
            int resp = _sqlServer.ExecuteNonQuery(_storeProcedureName, parms);
            if (resp > 0) return true; else return false;
        }

        private string CreateXmlProducts(List<StockDto> stock)
        {
            string xmlInvoice = String.Empty;
            try
            {
                using (var ms = new MemoryStream())
                {
                    XDocument xml = new XDocument(
                    new XElement("products",
                        (from info in stock
                         select new XElement("product",
                         new XElement[] {
                             new XElement("productoId", info.IdProducto),
                             new XElement("cantidad", info.Cantidad)
                            })
                        ))
                    );
                    xml.ToString();
                    xml.Save(ms);
                    xmlInvoice = UTF8Encoding.UTF8.GetString(ms.ToArray())
                                .Replace("﻿<?xml version=\"1.0\" encoding=\"utf-8\"?>", "").TrimStart();
                }
            }
            catch (Exception ex)
            {
                Utils.GrabarLog("CreateXmlInvoice", ex.ToString());
            }
            return xmlInvoice;
        }

    }
}
