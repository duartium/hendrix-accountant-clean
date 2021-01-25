using HendrixAccountant.ApplicationCore.DTOs;
using HendrixAccountant.ApplicationCore.Entities;
using HendrixAccountant.ApplicationCore.Interfaces.Repositories;
using HendrixAccountant.ApplicationCore.Interfaces.Services;
using HendrixAccountant.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HendrixAccountant.ApplicationCore.Services
{
    public class ProductService : IProductService
    {
        private readonly IUnitOfWork _unitOfWork;

        public ProductService(IUnitOfWork unitOfWork)
        {
            this._unitOfWork = unitOfWork;
        }

        public List<ProductDTO> GetProducts()
        {
            var data = _unitOfWork.Products.GetAll();
            return GetListDTOFromListEntity(data.ToList());
        }

        /// <summary>
        /// Sirve para transformar lista de entitades a lista de tipo DTO
        /// </summary>
        /// <param name="listEntity"></param>
        /// <returns></returns>
        private List<ProductDTO> GetListDTOFromListEntity(List<Product> listEntity)
        {
            var response = new List<ProductDTO>();
            ProductDTO dto;
            listEntity.ForEach(x =>
            {
                dto = new ProductDTO();
                dto.Descripcion = x.descripcion;
                dto.Codigo = x.id_producto.ToString();
                response.Add(dto);
            });
            return response;
        }
    }
}
