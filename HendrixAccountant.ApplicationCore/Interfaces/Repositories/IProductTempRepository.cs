using HendrixAccountant.ApplicationCore.DTOs;
using HendrixAccountant.ApplicationCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HendrixAccountant.ApplicationCore.Interfaces.Repositories
{
    public interface IProductTempRepository
    {
        List<Product> GetAll(ProductFilterDto filters);
        void UpdateStock(List<StockDto> stock, bool isDecrease);
        void UpdateStock(StockDto stock, bool isDecrease);
        bool Save(ProductDto product, bool isUpdate = false);
        bool Remove(int idProduct, string usuario);
    }
}
