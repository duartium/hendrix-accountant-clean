using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HendrixAccountant.ApplicationCore.DTOs;
using HendrixAccountant.ApplicationCore.Entities;
using HendrixAccountant.ApplicationCore.Interfaces.Repositories;
using HendrixAccountant.ApplicationCore.Map;
using HendrixAccountant.Common;

namespace HendrixAccountant.Data
{
    public class ClienteRepository : IClientRepository
    {
        #region  "Nombre de los procedimientos de operación"
        private const string _storeProcedureName = "SP_QRY_CLIENTS";
        #endregion

        private readonly ISqlServer _sqlServer;
        public ClienteRepository()
        {
            this._sqlServer = new DataBase();
        }

        public List<ClientDto> GetAll(ClientFilterDto filters)
        {
            var parms = new List<SqlParameter>();
            parms.Add(new SqlParameter("@accion", 'G'));
            parms.Add(new SqlParameter("@identificacion", filters.Identificacion));
            parms.Add(new SqlParameter("@nombres", filters.Nombres));
            parms.Add(new SqlParameter("@apellidos", filters.Apellidos));
            var dsResp = _sqlServer.ExecuteProcedure(_storeProcedureName, parms);
            return new ClientMapper().DatasetToClients(dsResp); ;
        }

        public Client GetByIdentification(string identification)
        {
            var parms = new List<SqlParameter>();
            parms.Add(new SqlParameter("@accion", 'C'));
            parms.Add(new SqlParameter("@identificacion", identification));
            var dsResp = _sqlServer.ExecuteProcedure(_storeProcedureName, parms);
            return new ClientMapper().DatasetToClient(dsResp);
        }
        
        public bool Save(ClientDto client, bool isUpdate = false)
        {
            char action = 'I';
            if (isUpdate) action = 'M';

            var parms = new List<SqlParameter>();
            parms.Add(new SqlParameter("@accion", action));
            parms.Add(new SqlParameter("@usuario", client.Usuario));
            parms.Add(new SqlParameter("@identificacion", client.Identificacion));
            parms.Add(new SqlParameter("@nombres", client.Nombres));
            parms.Add(new SqlParameter("@apellidos", client.Apellidos));
            parms.Add(new SqlParameter("@tipo_identificacion", client.TipoIdentificacion));
            parms.Add(new SqlParameter("@tipo_cliente", client.TipoCliente));
            parms.Add(new SqlParameter("@direccion", client.Direccion));
            parms.Add(new SqlParameter("@email", client.Email));
            parms.Add(new SqlParameter("@telefono", client.Telefono));
            parms.Add(new SqlParameter("@celular", client.Celular));
            if (isUpdate) parms.Add(new SqlParameter("@id_cliente", client.IdCliente));
            int resp = _sqlServer.ExecuteNonQuery(_storeProcedureName, parms);
            if (resp > 0) return true; else return false;
        }

        public bool Remove(int idCliente, string usuario)
        {
            var parms = new List<SqlParameter>();
            parms.Add(new SqlParameter("@accion", "E"));
            parms.Add(new SqlParameter("@usuario", usuario));
            parms.Add(new SqlParameter("@id_cliente", idCliente));
            int resp = _sqlServer.ExecuteNonQuery(_storeProcedureName, parms);
            if (resp > 0) return true; else return false;
        }
    }
}
