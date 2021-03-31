using HendrixAccountant.ApplicationCore.DTOs;
using System.Collections.Generic;

namespace HendrixAccountant.ApplicationCore.Interfaces.Services
{
    public interface IProductService
    {
        List<ProductDTO> GetProducts();
    }
}
