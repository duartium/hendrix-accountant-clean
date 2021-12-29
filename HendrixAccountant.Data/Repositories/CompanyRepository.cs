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
            return (resp > 0);
        }

        public bool CreateOrUpdate(string xmlParameters)
        {
            var parms = new List<SqlParameter>();
            parms.Add(new SqlParameter("@accion", 'F'));
            parms.Add(new SqlParameter("@parameters", xmlParameters));
            int resp = _sqlServer.ExecuteNonQuery(_storeProcedureName, parms);
            return (resp > 0);
        }

        public bool CreateOrUpdate(List<Parameters> parameters)
        {
            int resp = 0;
            foreach (var item in parameters)
            {
                var parms = new List<SqlParameter>();
                parms.Add(new SqlParameter("@accion", 'I'));
                parms.Add(new SqlParameter("@nombre", item.Nombre));
                parms.Add(new SqlParameter("@valor", item.Valor));
                parms.Add(new SqlParameter("@json", DBNull.Value));
                resp += _sqlServer.ExecuteNonQuery(_storeProcedureName, parms);
            }
            return (resp == parameters.Count);
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
            var company = String.IsNullOrEmpty(json) ? null : JsonConvert.DeserializeObject<Company>(json);
            return company;
        }

        public List<Parameters> GetPrintParams()
        {
            var parms = new List<SqlParameter>();
            parms.Add(new SqlParameter("@accion", 'P'));
            var dsResp = _sqlServer.ExecuteProcedure(_storeProcedureName, parms);
            return new ParameterMapper().DatasetToParameters(dsResp);
        }
    }
}
