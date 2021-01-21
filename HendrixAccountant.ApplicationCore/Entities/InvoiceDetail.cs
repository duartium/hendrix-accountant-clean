using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HendrixAccountant.ApplicationCore.Entities
{
    public class InvoiceDetail
    {
        public int id_factura_detalle { get; set; }
        public int cantidad { get; set; }
        public decimal precioUnitario { get; set; }
        public decimal descuento { get; set; }
        public decimal precioTotalSinImpuestos { get; set; }
        public bool estado { get; set; }
    }
}
