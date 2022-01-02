using HendrixAccountant.ApplicationCore.DTOs;
using HendrixAccountant.ApplicationCore.Interfaces.Services;
using HendrixAccountant.Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace HendrixAccountant.ApplicationCore.Services
{
    public class SaleService : ISales
    {
        private readonly ISqlServer _sqlServer;
        #region  "Nombre de los procedimientos de operación"
        private const string _storeProcedureName = "SP_REGISTER_SALE";
        #endregion
        public SaleService()
        {
            _sqlServer = new DataBase();
        }
        public int Generate(InvoiceDto invoice)
        {
            int resp = -1;
            if (invoice == null) return resp;

            string strXmlfactura = CreateXmlInvoice(invoice);
            var parms = new List<SqlParameter>();
            parms.Add(new SqlParameter { ParameterName = "@accion", SqlDbType = SqlDbType.Char, Value = 'I' });
            parms.Add(new SqlParameter { ParameterName = "@id_usuario", SqlDbType = SqlDbType.Int, Value = invoice.Auditoria.IdUser });
            parms.Add(new SqlParameter { ParameterName = "@usuario", SqlDbType = SqlDbType.VarChar, Value = invoice.Auditoria.Username });
            parms.Add(new SqlParameter { ParameterName = "@serial", SqlDbType = SqlDbType.VarChar, Value = invoice.Auditoria.SerialMainboard });
            parms.Add(new SqlParameter { ParameterName = "@factura", SqlDbType = SqlDbType.VarChar, Value = strXmlfactura });

            var data = _sqlServer.ExecuteProcedure(_storeProcedureName, parms);
            if (data.Tables.Contains("table"))
                if (data.Tables["table"].Rows.Count > 0)
                    resp = Convert.ToInt32(data.Tables["table"].Rows[0]["secuencial"].ToString());

            //if (_sqlServer.ExecuteNonQuery(_storeProcedureName, parms) > 0)
            //    resp = true;
            return resp;
        }

        public bool CancelInvoice(int secuencial, string motivoAnulacion)
        {
            var parms = new List<SqlParameter>();
            parms.Add(new SqlParameter { ParameterName = "@accion", SqlDbType = SqlDbType.Char, Value = 'A' });
            parms.Add(new SqlParameter { ParameterName = "@secuencial", SqlDbType = SqlDbType.Int, Value = secuencial });
            parms.Add(new SqlParameter { ParameterName = "@motivo_anulacion", SqlDbType = SqlDbType.VarChar, Value = motivoAnulacion });
            
            int resp = _sqlServer.ExecuteNonQuery("SP_QRY_SALE", parms);
            return (resp > 0);
        }

        private string CreateXmlInvoice(InvoiceDto invoice)
        {
            string xmlInvoice = String.Empty;
            try
            {
                using (var ms = new MemoryStream())
                {
                    XDocument xml = new XDocument(
                    new XElement("factura",
                        new XElement("clienteId", invoice.ClienteId.ToString()),
                        new XElement("formaPago", invoice.FormaPago),
                        new XElement("fechaEmision", invoice.FechaEmision.ToString("yyyy-MM-dd HH:mm:ss")),
                        new XElement("baseImponible", invoice.BaseImponible),
                        new XElement("iva", invoice.IVA),
                        new XElement("subtotal0", invoice.Subtotal0),
                        new XElement("subtotal12", invoice.Subtotal2),
                        new XElement("subtotal", invoice.SubtotaGeneral),
                        new XElement("total", invoice.Total),
                        new XElement("pago", invoice.Pago),
                        new XElement("cambio", invoice.Cambio),
                        new XElement("descuento", invoice.TotalDescuento),
                        new XElement("detalles",
                            (from det in invoice.Detalle
                             select new XElement("detalle",
                             new XElement[] {
                                 new XElement("productoId", det.IdProducto),
                                 new XElement("cantidad", det.Cantidad),
                                 new XElement("precioUnitario", det.Precio),
                                 new XElement("descuento", "0")
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
