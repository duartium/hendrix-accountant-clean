using HendrixAccountant.ApplicationCore.Interfaces.Services;
using HendrixAccountant.ApplicationCore.Models;
using System.Collections.Generic;

namespace HendrixAccountant.ApplicationCore.Interfaces.Repositories
{
    public interface IParameterRepository
    {
        bool CreateOrUpdate(IParameter parameter);
        bool CreateOrUpdate(List<Parameters> parameters);
        List<Parameters> GetPrintParams();
        IParameter Get();

    }
}
