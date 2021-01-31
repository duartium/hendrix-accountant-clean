using HendrixAccountant.ApplicationCore.DTOs;
using HendrixAccountant.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HendrixAccountant.ApplicationCore.Interfaces.Repositories
{
    public interface ICatalogueRepository
    {
        List<CatalogueDto> GetByName(string name);
    }
}
