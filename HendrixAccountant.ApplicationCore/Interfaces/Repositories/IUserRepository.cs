using HendrixAccountant.Data.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HendrixAccountant.Data
{
    public interface IUserRepository
    {
        UserAuthDto Authenticate(string username, string password);
        List<UserDto> GetAll();
        bool Save(UserSaveDto user, bool isUpdate = false);
        List<Rol> GetRol();
        bool Remove(int idUser, string username);
    }
}
