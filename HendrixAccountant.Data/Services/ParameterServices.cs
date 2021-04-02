using HendrixAccountant.ApplicationCore.Interfaces.Services;
using HendrixAccountant.ApplicationCore.Map;
using HendrixAccountant.Common;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace HendrixAccountant.Data.Services
{
    public class ParameterServices : IParameterService
    {
        #region  "Nombre de los procedimientos de operación"
        private const string _storeProcedureName = "SP_PARAMETERS";
        #endregion

        private readonly ISqlServer _sqlServer;

        public ParameterServices()
        {
            _sqlServer = new DataBase();
        }

        public string Get(string name)
        {
            var parms = new List<SqlParameter>();
            parms.Add(new SqlParameter("@accion", 'C'));
            parms.Add(new SqlParameter("@esJson", 0));
            parms.Add(new SqlParameter("@nombre", name));
            var dsResp = _sqlServer.ExecuteProcedure(_storeProcedureName, parms);
            if (!Validator.DatasetIsValid(dsResp)) return null;
            return dsResp.Tables[0].Rows[0]["dato"].ToString();
        }
    }
}
