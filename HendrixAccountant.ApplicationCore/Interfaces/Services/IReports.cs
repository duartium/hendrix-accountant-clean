using HendrixAccountant.ApplicationCore.DTOs;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HendrixAccountant.ApplicationCore.Interfaces.Services
{
    public interface IReports
    {
        DataSet Get(SalesFilterDto salesFilter);
        DataSet GetByInvoice(string numFactura);
    }
}
