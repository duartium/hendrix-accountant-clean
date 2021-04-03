using HendrixAccountant.ApplicationCore.DTOs;
using HendrixAccountant.ApplicationCore.Interfaces.Repositories;
using HendrixAccountant.Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HendrixAccountant.Data.Repositories
{
    public class PurchaseRepository : IPurchase
    {
        private readonly ISqlServer _sqlServer;
        #region  "Nombre de los procedimientos de operación"
        private const string _storeProcedureName = "SP_QRY_PURCHASE";
        #endregion
        public PurchaseRepository()
        {
            _sqlServer = new DataBase();
        }
        public int Save(PurchaseMerchandiseDto purchase)
        {
            int resp = -1;
            if (purchase == null) return resp;

            string strXmlCompra = CreateXmlPurchase(purchase);
            var parms = new List<SqlParameter>();
            parms.Add(new SqlParameter { ParameterName = "@accion", SqlDbType = SqlDbType.Char, Value = 'I' });
            parms.Add(new SqlParameter { ParameterName = "@usuario", SqlDbType = SqlDbType.VarChar, Value = purchase.Usuario });
            parms.Add(new SqlParameter { ParameterName = "@compra", SqlDbType = SqlDbType.VarChar, Value = strXmlCompra });

            int scope_identity = _sqlServer.ExecuteNonQuery(_storeProcedureName, parms);
            if (scope_identity > 0) resp = scope_identity;

            //if (_sqlServer.ExecuteNonQuery(_storeProcedureName, parms) > 0)
            //    resp = true;
            return resp;
        }

        private string CreateXmlPurchase(PurchaseMerchandiseDto purchase)
        {
            string xmlInvoice = String.Empty;
            try
            {
                using (var ms = new MemoryStream())
                {
                    XDocument xml = new XDocument(
                    new XElement("compra",
                        new XElement("fecha_emision", purchase.FechaEmision.ToString()),
                        new XElement("num_comprobante", purchase.NumComprobante),
                        new XElement("tipo_comprobante", "1"),
                        new XElement("proveedor_id", purchase.IdProveedor.ToString()),
                        new XElement("observaciones", purchase.Observaciones),
                        new XElement("total_compra", purchase.Total),
                        new XElement("detalles",
                            (from det in purchase.ProductosList
                             select new XElement("detalle",
                             new XElement[] {
                                 new XElement("producto_id", det.IdProducto),
                                 new XElement("stock_actual", 0),
                                 new XElement("stock_nuevo", 0),
                                 new XElement("cantidad", det.Cantidad),
                                 new XElement("precio", det.Precio)
                                })
                            ))
                        )
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
