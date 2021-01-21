using HendrixAccountant.ApplicationCore.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HendrixAccountant.Data.Repositories
{
    public class UnitOfWork: IUnitOfWork
    {
        private readonly AppDbContext _context;

        IProductRepository _products;

        public UnitOfWork(AppDbContext context)
        {
            this._context = context ?? throw new ArgumentNullException(nameof(context));
        }

        /// <summary>
        /// Example for Products: Singleton Pattern
        /// </summary>
        public IProductRepository Products
        {
            get
            {
                if (_products == null)
                    _products = new ProductoRepository(_context);
                return _products;
            }
        }

        public void Dispose()
        {
            // _context.Dispose();
            throw new NotImplementedException();

        }

        public int SaveChanges()
        {
            // return _context.SaveChanges();
            throw new NotImplementedException();
        }
    }
}
