using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HendrixAccountant.ApplicationCore.DTOs
{
    public class InvoiceDetailDto
    {
        public int cantidad { get; set; }
        public decimal precio_unitario { get; set; }
        public decimal descuento { get; set; }
        public decimal total { get; set; }
    }
}
