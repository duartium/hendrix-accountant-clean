using HendrixAccountant.ApplicationCore.Interfaces.Services;
using HendrixAccountant.ApplicationCore.Models;
using System.Collections.Generic;

namespace HendrixAccountant.ApplicationCore.Interfaces.Repositories
{
    public interface IParameterRepository
    {
        bool CreateOrUpdate(IParameter parameter);
        bool CreateOrUpdate(List<Parameters> parameters);
        bool UpdateSequential(string nameSequential, int newSequential);

        List<Parameters> GetPrintParams();

        string GetByName(string name);

        IParameter Get();

        List<Parameters> GetSequential();

    }
}
