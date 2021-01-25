using HendrixAccountant.ApplicationCore.Entities;
using HendrixAccountant.ApplicationCore.Interfaces.Repositories;
using HendrixAccountant.Common;
using HendrixAccountant.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace HendrixAccountant.Data
{
    public class ProductoRepository : Repository<Product>, IProductRepository
    {
        private AppDbContext _appDbContext => (AppDbContext)_context;

        #region  "Nombre de los procedimientos de operación"
        private const string _storeProcedureName = "SP_CONSULTA_PRODUCTOS";

        #endregion
        private ISqlServer _sqlServer;


        public ProductoRepository(AppDbContext context) : base(context)
        {
            //var productos = context.Products.ToList();
        }

        public ProductoRepository() : base()
        {
            this._sqlServer = new DataBase();
        }

        public DataSet GetAllByADO()
        {
            DataSet ds = null;
            try
            {
                var parms = new List<SqlParameter>();
                parms.Add(new SqlParameter("@accion", 'G'));
                parms.Add(new SqlParameter("@usuario", ""));

                return _sqlServer.ExecuteProcedure(_storeProcedureName, parms);
            }
            catch (Exception ex)
            {
                Utils.GrabarLog("ProductoRepository>>GetAll", ex.ToString());
            }
            return ds;
        }

        public bool Save()
        {
            throw new NotImplementedException();
        }
    }
}
