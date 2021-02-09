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
    public class CategoriesRepository : ICategoriesRepository
    {
        #region  "Nombre de los procedimientos de operación"
        private const string _storeProcedureName = "SP_CATALOGS_HENDRIX";
        #endregion

        private readonly ISqlServer _sqlServer;
        public CategoriesRepository()
        {
            this._sqlServer = new DataBase();
        }

        public bool Save(CategoryDto category, bool isUpdate = false)
        {
            char action = 'I';
            if (isUpdate) action = 'M';

            var parms = new List<SqlParameter>();
            parms.Add(new SqlParameter("@accion", action));
            parms.Add(new SqlParameter("@usuario", category.Usuario));
            parms.Add(new SqlParameter("@codigo", category.Codigo));
            parms.Add(new SqlParameter("@nombre", category.Nombre));
            if (isUpdate) parms.Add(new SqlParameter("@id_item_catalogo", category.IdCategoria));
            int resp = _sqlServer.ExecuteNonQuery(_storeProcedureName, parms);
            if (resp > 0) return true; else return false;
        }

        public bool Remove(int idProveedor, string usuario)
        {
            var parms = new List<SqlParameter>();
            parms.Add(new SqlParameter("@accion", "E"));
            parms.Add(new SqlParameter("@usuario", usuario));
            parms.Add(new SqlParameter("@id_proveedor", idProveedor));
            int resp = _sqlServer.ExecuteNonQuery(_storeProcedureName, parms);
            if (resp > 0) return true; else return false;
        }

        public List<CategoryDto> GetAll()
        {
            var parms = new List<SqlParameter>();
            parms.Add(new SqlParameter("@accion", 'G'));
            parms.Add(new SqlParameter("@nombre", "categorias"));
            var dsResp = _sqlServer.ExecuteProcedure(_storeProcedureName, parms);
            return new CategoryMapper().DatasetToCategories(dsResp);
        }
    }
}
