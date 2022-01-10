using HendrixAccountant.ApplicationCore.DTOs;
using HendrixAccountant.ApplicationCore.Entities;
using HendrixAccountant.ApplicationCore.Models;
using System.Collections.Generic;

namespace HendrixAccountant.ApplicationCore.Interfaces.Repositories
{
    public interface IProductTempRepository
    {
        List<Product> GetAll(ProductFilterDto filters);
        void UpdateStock(List<StockDto> stock, bool isDecrease);
        void UpdateStock(StockDto stock, bool isDecrease);
        int Save(ProductDto product, bool isUpdate = false);
        bool Remove(int idProduct, string usuario);
        List<BarcodeCard> GetBarcodes();
        ProductIdentityDto GetByCode(string code);
        bool IsDuplicateCode(string code);
        bool UnsuscribeProduct(ProductWithdrawal product);
    }
}
