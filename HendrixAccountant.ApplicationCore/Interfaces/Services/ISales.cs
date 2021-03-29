using HendrixAccountant.ApplicationCore.DTOs;
using HendrixAccountant.ApplicationCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HendrixAccountant.ApplicationCore.Interfaces.Services
{
    public interface ISales
    {
        int Generate(InvoiceDto invoice);
    }
}
