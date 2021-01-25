using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HendrixAccountant.ApplicationCore.Interfaces.Repositories
{
    public interface IUnitOfWork : IDisposable
    {
        IProductRepository Products { get; }
        IColorRepository Colors { get; }
        IBrandRepository Brands { get; }
        ICategoryRepository Categories { get; }
        ISupplierRepository Suppliers { get; }
        int SaveChanges();

       
    }
}
