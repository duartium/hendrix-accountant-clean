using HendrixAccountant.ApplicationCore.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HendrixAccountant.ApplicationCore.Interfaces.Repositories
{
    public interface ISizeRepository
    {
        bool Save(SizeDto size, bool isUpdate);
        List<SizeDto> GetAll();
        bool Remove(int idSize, string username);
    }
}
