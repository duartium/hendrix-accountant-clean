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
    public class CatalogueRepository : ICatalogueRepository
    {
        #region  "Nombre de los procedimientos de operación"
        private const string _storeProcedureName = "SP_CATALOGS_HENDRIX";
        #endregion

        private readonly ISqlServer _sqlServer;
        public CatalogueRepository()
        {
            this._sqlServer = new DataBase();
        }

        public List<CatalogueDto> GetByName(string name)
        {
            var parms = new List<SqlParameter>();
            parms.Add(new SqlParameter("@accion", 'C'));
            parms.Add(new SqlParameter("@nombre", name));
            var dsResp = _sqlServer.ExecuteProcedure(_storeProcedureName, parms);
            return new CatalogueMapper().DatasetToCatalogue(dsResp);
        }
    }

}
