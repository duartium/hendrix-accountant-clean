using HendrixAccountant.ApplicationCore.DTOs;
using HendrixAccountant.ApplicationCore.Entities;
using System.Collections.Generic;
using System.Data;

namespace HendrixAccountant.ApplicationCore.Interfaces.Repositories
{
    public interface IClientRepository
    {
        Client GetByIdentification(string identificacion); 
        List<ClientDto> GetAll(ClientFilterDto filters);
        bool Save(ClientDto client, bool isUpdate = false);
        bool Remove(int idClient, string username);
        List<ClientDto> GetList();
        bool IsDuplicateClient(string identification);
        DataTable GetBirthdayCustomers(int month);
    }
}
