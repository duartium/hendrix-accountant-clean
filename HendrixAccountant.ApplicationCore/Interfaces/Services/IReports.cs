using HendrixAccountant.ApplicationCore.DTOs;
using System.Data;

namespace HendrixAccountant.ApplicationCore.Interfaces.Services
{
    public interface IReports
    {
        DataSet Get(SalesFilterDto salesFilter);
        DataSet GetByInvoice(string numFactura);
    }
}
