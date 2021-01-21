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

        

        private ISqlServer _sqlServer;

        
        public ProductoRepository(AppDbContext context) : base(context)
        {
        }

        public ProductoRepository(): base()
        {
            this._sqlServer = new DataBase();
        }

        public bool Save()
        {
            throw new NotImplementedException();
        }
    }
}
