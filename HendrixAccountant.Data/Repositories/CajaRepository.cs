﻿using HendrixAccountant.ApplicationCore.Interfaces.Repositories;
using HendrixAccountant.Common;
using HendrixAccountant.Data.Dtos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace HendrixAccountant.Data
{
    public class CajaRepository : ICashRegisterRepository
    {
        #region  "Nombre de los procedimientos de operación"
        private const string _storeProcedureName = "SP_CASH_FLOW";
        #endregion
        private readonly ISqlServer _sqlServer;
        public CajaRepository()
        {
            this._sqlServer = new DataBase();
        }

        public bool RegisterMovement(CashFlowDto cashFlow)
        {
            var parms = new List<SqlParameter>();
            parms.Add(new SqlParameter("@accion", 'I'));
            parms.Add(new SqlParameter("@usuario", cashFlow.usuario));
            parms.Add(new SqlParameter("@tipo_movimiento", cashFlow.tipoMovimiento));
            parms.Add(new SqlParameter("@saldo", cashFlow.saldo));
            parms.Add(new SqlParameter("@serial", Utils.GetSerial()));
            int numRows = _sqlServer.ExecuteNonQuery(_storeProcedureName, parms);
            return ( numRows > 0) ? true : false;
        }
        
    }
}
