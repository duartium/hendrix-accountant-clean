﻿using HendrixAccountant.ApplicationCore.DTOs;
using HendrixAccountant.ApplicationCore.Interfaces.Services;
using HendrixAccountant.Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HendrixAccountant.Data.Services
{
    public class SaleReportService : IReports
    {
        private readonly ISqlServer _sqlServer;
        #region  "Nombre de los procedimientos de operación"
        private const string _storeProcedureName = "SP_RPT_SALE";
        #endregion
        public SaleReportService()
        {
            _sqlServer = new DataBase();
        }
        public DataSet Get(SalesFilterDto salesFilter)
        {
            var parms = new List<SqlParameter>();
            parms.Add(new SqlParameter("@accion", 'C'));
            parms.Add(new SqlParameter("@secuencial", salesFilter.Secuencial));
            parms.Add(new SqlParameter("@fecha_desde", salesFilter.FechaDesde));
            parms.Add(new SqlParameter("@fecha_hasta", salesFilter.FechaHasta));
            parms.Add(new SqlParameter("@id_cliente", salesFilter.IdentificacionClte));
            parms.Add(new SqlParameter("@id_usuario", salesFilter.IdUsuario));
            return _sqlServer.ExecuteProcedure(_storeProcedureName, parms);
        }

        public DataSet GetByInvoice(string secuencial)
        {
            var parms = new List<SqlParameter>();
            parms.Add(new SqlParameter("@accion", 'C'));
            parms.Add(new SqlParameter("@secuencial", secuencial));
            return _sqlServer.ExecuteProcedure(_storeProcedureName, parms);
        }
    }
}
