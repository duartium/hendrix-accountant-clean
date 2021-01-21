using HendrixAccountant.ApplicationCore.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HendrixAccountant.ApplicationCore.Interfaces.Repositories
{
    public interface IClientRepository
    {
        //List<ClientDto> GetByIdentification(string numberID);
        //List<ClientDto> GetByName(string numberID);
        IEnumerable<ClientDto> GetAll();
    }
}
