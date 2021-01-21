using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HendrixAccountant.ApplicationCore.DTOs;
using HendrixAccountant.ApplicationCore.Interfaces.Repositories;
using HendrixAccountant.ApplicationCore.Map;
using HendrixAccountant.Common;

namespace HendrixAccountant.Data
{
    public class ClienteRepository : IClientRepository
    {
        #region  "Nombre de los procedimientos de operación"
        private const string _storeProcedureName = "SP_CONSULTA_CLIENTES";
        #endregion

        private readonly ISqlServer _sqlServer;
        public ClienteRepository()
        {
            this._sqlServer = new DataBase();
        }

        public IEnumerable<ClientDto> GetAll()
        {
            var parms = new List<SqlParameter>();
            parms.Add(new SqlParameter("@accion", 'G'));
            parms.Add(new SqlParameter("@usuario", ""));
            var dsResp = _sqlServer.ExecuteProcedure(_storeProcedureName, parms);
            return new ClientMapper().DatasetToClients(dsResp); ;
        } 
        public bool Save()
        {
            throw new NotImplementedException();
        }
    }
}
