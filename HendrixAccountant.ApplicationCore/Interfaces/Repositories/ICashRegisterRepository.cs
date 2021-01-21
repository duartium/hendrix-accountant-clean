using HendrixAccountant.Data.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HendrixAccountant.ApplicationCore.Interfaces.Repositories
{
    public interface ICashRegisterRepository
    {
        bool RegisterMovement(CashFlowDto cashFlow);
    }
}
