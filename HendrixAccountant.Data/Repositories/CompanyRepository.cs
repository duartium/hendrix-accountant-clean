using HendrixAccountant.ApplicationCore.Constants;
using HendrixAccountant.ApplicationCore.Interfaces.Repositories;
using HendrixAccountant.ApplicationCore.Interfaces.Services;
using HendrixAccountant.ApplicationCore.Map;
using HendrixAccountant.ApplicationCore.Models;
using HendrixAccountant.Common;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HendrixAccountant.Data.Repositories
{
    public class CompanyRepository : IParameterRepository
    {
        #region  "Nombre de los procedimientos de operación"
        private const string _storeProcedureName = "SP_PARAMETERS";
        #endregion

        private readonly ISqlServer _sqlServer;
        public CompanyRepository()
        {
            this._sqlServer = new DataBase();
        }

        public bool CreateOrUpdate(IParameter parameter)
        {
            Company company = parameter as Company;
            string jsonCompany = JsonConvert.SerializeObject(company);
            var parms = new List<SqlParameter>();
            parms.Add(new SqlParameter("@accion", 'I'));
            parms.Add(new SqlParameter("@nombre", CString.COMPANY));
            parms.Add(new SqlParameter("@valor", DBNull.Value));
            parms.Add(new SqlParameter("@json", jsonCompany));
            int resp = _sqlServer.ExecuteNonQuery(_storeProcedureName, parms);
            return resp > 0 ? true : false;
        }

        public IParameter Get()
        {
            var parms = new List<SqlParameter>();
            parms.Add(new SqlParameter("@accion", 'C'));
            parms.Add(new SqlParameter("@esJson", 1));
            parms.Add(new SqlParameter("@nombre", CString.COMPANY));
            var dsResp = _sqlServer.ExecuteProcedure(_storeProcedureName, parms);
            if (!Validator.DatasetIsValid(dsResp)) return null;
            string json = dsResp.Tables[0].Rows[0]["dato"].ToString();
            var company = JsonConvert.DeserializeObject<Company>(json);
            return company;
        }
    }
}
