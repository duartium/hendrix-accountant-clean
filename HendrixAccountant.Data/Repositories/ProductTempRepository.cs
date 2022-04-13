using HendrixAccountant.ApplicationCore.DTOs;
using HendrixAccountant.ApplicationCore.Entities;
using HendrixAccountant.ApplicationCore.Interfaces.Repositories;
using HendrixAccountant.ApplicationCore.Map;
using HendrixAccountant.ApplicationCore.Models;
using HendrixAccountant.Common;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
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
        public List<Product> GetAll(ProductFilterDto filters)
        {

            var parms = new List<SqlParameter>();
            parms.Add(new SqlParameter("@accion", 'G'));
            parms.Add(new SqlParameter("@idProducto", filters.IdProducto));
            parms.Add(new SqlParameter("@nombre", filters.NombreProducto));
            parms.Add(new SqlParameter("@codigo", filters.Codigo));

            if(filters.EsServicio >= 0)
                parms.Add(new SqlParameter("@es_servicio", filters.EsServicio));
            else
                parms.Add(new SqlParameter("@es_servicio", DBNull.Value));

            var dsResp = _sqlServer.ExecuteProcedure(_storeProcedureName, parms);
            return new ProductMapper().DatasetToProducts(dsResp);
        }

        public bool IsDuplicateCode(string code)
        {
            var parms = new List<SqlParameter>();
            parms.Add(new SqlParameter("@accion", "D"));
            parms.Add(new SqlParameter("@codigo", code));
            var dsResp = _sqlServer.ExecuteProcedure(_storeProcedureName, parms);
            return (int.Parse(dsResp.Tables[0].Rows[0]["RESULT"].ToString()) > 0);
        }

        public List<BarcodeCard> GetBarcodes()
        {
            var parms = new List<SqlParameter>();
            parms.Add(new SqlParameter("@accion", 'B'));
            var dsResp = _sqlServer.ExecuteProcedure(_storeProcedureName, parms);
            return new ProductMapper().DatasetToBarcodes(dsResp);
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

        public int Save(ProductDto product, bool isUpdate = false)
        {
            char action = 'I';
            if (isUpdate) action = 'M';

            var parms = new List<SqlParameter>();
            parms.Add(new SqlParameter("@accion", action));
            parms.Add(new SqlParameter("@usuario", product.Usuario));
            parms.Add(new SqlParameter("@codigo", product.CodigoBarras));
            parms.Add(new SqlParameter("@nombre", product.Nombre));
            parms.Add(new SqlParameter("@descripcion", product.Descripcion));
            parms.Add(new SqlParameter("@costo", product.Costo));
            parms.Add(new SqlParameter("@precioVenta", product.Precio));
            parms.Add(new SqlParameter("@stock", product.Stock));
            parms.Add(new SqlParameter("@descuento", product.Descuento));
            parms.Add(new SqlParameter("@talla", product.IdTalla));
            parms.Add(new SqlParameter("@tarifaIva", product.TarifaIva));
            parms.Add(new SqlParameter("@idProveedor", product.IdProveedor));
            parms.Add(new SqlParameter("@idCategoria", product.IdCategoria));
            parms.Add(new SqlParameter("@es_servicio", product.EsServicio));
            if (isUpdate) parms.Add(new SqlParameter("@idProducto", product.IdProducto));
            var resp = _sqlServer.ExecuteProcedure(_storeProcedureName, parms);

            return int.Parse(resp.Tables[0].Rows[0][0].ToString());
        }

        public bool Remove(int idProduct, string usuario)
        {
            var parms = new List<SqlParameter>();
            parms.Add(new SqlParameter("@accion", "E"));
            parms.Add(new SqlParameter("@usuario", usuario));
            parms.Add(new SqlParameter("@idProducto", idProduct));
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

        public ProductIdentityDto GetByCode(string code)
        {
            var parms = new List<SqlParameter>();
            parms.Add(new SqlParameter("@accion", 'C'));
            parms.Add(new SqlParameter("@codigo", code));
            var dsResp = _sqlServer.ExecuteProcedure(_storeProcedureName, parms);
            return new ProductMapper().DatasetToProduct(dsResp);
        }

        public bool UnsuscribeProduct(ProductWithdrawal product)
        {
            var parms = new List<SqlParameter>();
            parms.Add(new SqlParameter("@accion", "U"));
            parms.Add(new SqlParameter("@idProducto", product.IdProducto));
            parms.Add(new SqlParameter("@idMotivo", product.IdMotivo));
            parms.Add(new SqlParameter("@cantidad", product.Cantidad));
            parms.Add(new SqlParameter("@otroMotivo", product.OtroMotivo));
            parms.Add(new SqlParameter("@usuario", product.Usuario));
            int resp = _sqlServer.ExecuteNonQuery("SP_UNSUSCRIBE_PRODUCT", parms);
            if (resp > 0) return true; else return false;
        }

        System.Data.DataTable IProductTempRepository.GetProductsBySale(int secuencial)
        {
            var parms = new List<SqlParameter>();
            parms.Add(new SqlParameter("@accion", "C"));
            parms.Add(new SqlParameter("@secuencial", secuencial));
            var dsResp = _sqlServer.ExecuteProcedure("QRY_CUSTOMER_HISTORY", parms);
            return dsResp.Tables[0];
        }
    }
}
