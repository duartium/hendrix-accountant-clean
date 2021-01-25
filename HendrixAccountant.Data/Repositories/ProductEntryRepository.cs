using HendrixAccountant.ApplicationCore.DTOs;
using HendrixAccountant.ApplicationCore.Entities;
using HendrixAccountant.ApplicationCore.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HendrixAccountant.Data.Repositories
{
    public class ProductEntryRepository: Repository<ProductEntry>, IProductEntryRepository
    {
        private AppDbContext _appDbContext => (AppDbContext)_context;

        public ProductEntryRepository(AppDbContext context) : base(context)
        {
        }

        public bool GuardarTransaccionDetalleCompra(List<ProductDetailBuyDto> detalle, long idproveedor, ref string mensaje)
        {
            throw new NotImplementedException();
        }
    }
}
