using HendrixAccountant.ApplicationCore.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HendrixAccountant.ApplicationCore.Interfaces.Repositories
{
    public interface IParameterRepository
    {
        bool CreateOrUpdate(IParameter parameter);
        IParameter Get();

    }
}
