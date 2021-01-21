using HendrixAccountant.ApplicationCore.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HendrixAccountant.ApplicationCore.Interfaces.Services
{
    public interface IProductService
    {
        List<ProductDTO> GetProducts();
    }
}
