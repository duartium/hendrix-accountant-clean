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
        IColorRepository _colors;
        IBrandRepository _brands;
        ICategoryRepository _categories;
        ISupplierRepository _suppliers;

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

        public IColorRepository Colors
        {
            get
            {
                if (_colors == null)
                    _colors = new ColorRepository(_context);
                return _colors;
            }
        }

        public IBrandRepository Brands
        {
            get
            {
                if (_brands == null)
                    _brands = new BrandRepository(_context);
                return _brands;
            }
        }

        public ICategoryRepository Categories
        {
            get
            {
                if (_categories == null)
                    _categories = new CategoryRepository(_context);
                return _categories;
            }
        }

        public ISupplierRepository Suppliers
        {
            get
            {
                if (_suppliers== null)
                    _suppliers = new SupplierRepository(_context);
                return _suppliers;
            }
        }

        public void Dispose()
        {
            _context.Dispose();
            

        }

        public int SaveChanges()
        {
            return _context.SaveChanges();
           
        }
    }
}
