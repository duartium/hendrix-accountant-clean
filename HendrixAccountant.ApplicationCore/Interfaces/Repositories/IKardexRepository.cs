using HendrixAccountant.ApplicationCore.DTOs;
using HendrixAccountant.ApplicationCore.Entities;
using System.Collections.Generic;

namespace HendrixAccountant.ApplicationCore.Interfaces.Repositories
{
    public interface IKardexRepository
    {
        IEnumerable<Kardex> GetAll(KardexFilterDto filters);
    }
}
