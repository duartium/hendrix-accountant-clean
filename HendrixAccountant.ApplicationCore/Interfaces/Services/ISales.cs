using HendrixAccountant.ApplicationCore.DTOs;

namespace HendrixAccountant.ApplicationCore.Interfaces.Services
{
    public interface ISales
    {
        int Generate(InvoiceDto invoice);
    }
}
