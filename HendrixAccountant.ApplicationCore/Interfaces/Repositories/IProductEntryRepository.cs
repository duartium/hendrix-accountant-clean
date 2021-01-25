using HendrixAccountant.ApplicationCore.DTOs;
using HendrixAccountant.ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HendrixAccountant.ApplicationCore.Interfaces.Repositories
{
    public interface IProductEntryRepository: IRepository<ProductEntry>
    {
        bool GuardarTransaccionDetalleCompra(List<ProductDetailBuyDto> detalle, long idproveedor, ref string mensaje);
    }
}
