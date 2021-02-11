using HendrixAccountant.ApplicationCore.DTOs;
using HendrixAccountant.ApplicationCore.Interfaces.Repositories;
using HendrixAccountant.ApplicationCore.Map;
using HendrixAccountant.Common;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HendrixAccountant.Data.Repositories
{
    public class SizeRepository : ISizeRepository
    {
        #region  "Nombre de los procedimientos de operación"
        private const string _storeProcedureName = "SP_CATALOGS_HENDRIX";
        #endregion

        private readonly ISqlServer _sqlServer;
        public SizeRepository()
        {
            this._sqlServer = new DataBase();
        }

        public bool Save(SizeDto size, bool isUpdate = false)
        {
            char action = 'I';
            if (isUpdate) action = 'M';

            var parms = new List<SqlParameter>();
            parms.Add(new SqlParameter("@accion", action));
            parms.Add(new SqlParameter("@nombre", "tallas"));
            parms.Add(new SqlParameter("@usuario", size.Usuario));
            parms.Add(new SqlParameter("@codigo", size.Codigo));
            parms.Add(new SqlParameter("@descripcion", size.Descripcion));
            if (isUpdate) parms.Add(new SqlParameter("@idItemCatalogo", size.IdTalla));
            int resp = _sqlServer.ExecuteNonQuery(_storeProcedureName, parms);
            if (resp > 0) return true; else return false;
        }

        public bool Remove(int idCategory, string usuario)
        {
            var parms = new List<SqlParameter>();
            parms.Add(new SqlParameter("@accion", "E"));
            parms.Add(new SqlParameter("@nombre", "tallas"));
            parms.Add(new SqlParameter("@usuario", usuario));
            parms.Add(new SqlParameter("@idItemCatalogo", idCategory));
            int resp = _sqlServer.ExecuteNonQuery(_storeProcedureName, parms);
            if (resp > 0) return true; else return false;
        }

        public List<SizeDto> GetAll()
        {
            var parms = new List<SqlParameter>();
            parms.Add(new SqlParameter("@accion", 'C'));
            parms.Add(new SqlParameter("@nombre", "tallas"));
            var dsResp = _sqlServer.ExecuteProcedure(_storeProcedureName, parms);
            return new SizeMapper().DatasetToSizes(dsResp);
        }
    }
}
