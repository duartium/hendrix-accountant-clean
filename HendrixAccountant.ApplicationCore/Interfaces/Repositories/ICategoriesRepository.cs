using HendrixAccountant.ApplicationCore.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HendrixAccountant.ApplicationCore.Interfaces.Repositories
{
    public interface ICategoriesRepository
    {
        bool Save(CategoryDto category, bool isUpdate);
        List<CategoryDto> GetAll();
        bool Remove(int idCategory, string usuario);
    }
}
