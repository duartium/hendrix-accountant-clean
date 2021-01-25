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
    public class BrandRepository: Repository<Brand>, IBrandRepository
    {
        private AppDbContext _appDbContext => (AppDbContext)_context;

        public BrandRepository(AppDbContext context) : base(context)
        {
        }

        public List<ComboBoxMarcaDTO> GetComboBoxMarcaDTOs()
        {
            var response = new List<ComboBoxMarcaDTO>();
            response.Add(new ComboBoxMarcaDTO { Id = 1, Descripcion = "Mar A" });
            response.Add(new ComboBoxMarcaDTO { Id = 2, Descripcion = "Mar B" });
            response.Add(new ComboBoxMarcaDTO { Id = 3, Descripcion = "Mar C" });
            return response;
        }
    }
}
