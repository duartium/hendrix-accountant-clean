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
    public class ColorRepository : Repository<Color>, IColorRepository
    {
        private AppDbContext _appDbContext => (AppDbContext)_context;

        public ColorRepository(AppDbContext context) : base(context)
        {
        }

        public List<ComboBoxColorDTO> GetComboBoxColorDTOs()
        {
            var response = new List<ComboBoxColorDTO>();
            response.Add(new ComboBoxColorDTO { Id = 1, Descripcion = "Col A" });
            response.Add(new ComboBoxColorDTO { Id = 2, Descripcion = "Col B" });
            response.Add(new ComboBoxColorDTO { Id = 3, Descripcion = "Col C" });
            return response;
        }
    }
}
