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
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private AppDbContext _appDbContext => (AppDbContext)_context;

        public CategoryRepository(AppDbContext context) : base(context)
        {
        }

        public List<ComboBoxCategoriaDTO> GetComboBoxCategoriaDTOs()
        {
            var response = new List<ComboBoxCategoriaDTO>();
            response.Add(new ComboBoxCategoriaDTO { Id = 1, Descripcion = "Cat A" });
            response.Add(new ComboBoxCategoriaDTO { Id = 2, Descripcion = "Cat B" });
            response.Add(new ComboBoxCategoriaDTO { Id = 3, Descripcion = "Cat C" });
            return response;
        }
    }
}
