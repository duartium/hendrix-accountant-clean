using HendrixAccountant.ApplicationCore.DTOs;
using HendrixAccountant.ApplicationCore.Entities;
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
    public class ProductTempRepository : IProductTempRepository
    {
        private readonly ISqlServer _sqlServer;
        #region  "Nombre de los procedimientos de operación"
        private const string _storeProcedureName = "SP_PRODUCTS";
        #endregion
        public ProductTempRepository()
        {
            _sqlServer = new DataBase();
        }
        public IEnumerable<Product> GetAll(ProductFilterDto filters)
        {
            var parms = new List<SqlParameter>();
            parms.Add(new SqlParameter("@accion", 'G'));
            parms.Add(new SqlParameter("@idProducto", filters.IdProducto));
            parms.Add(new SqlParameter("@nombre", filters.NombreProducto));
            var dsResp = _sqlServer.ExecuteProcedure(_storeProcedureName, parms);
            return new ProductMapper().DatasetToProducts(dsResp);
        }
    }
}
