using System;
using System.Collections.Generic;

namespace HendrixAccountant.ApplicationCore.DTOs
{
    public class PurchaseMerchandiseDto
    {
        public int IdEntrada { get; set; }
        public string NumComprobante { get; set; }
        public DateTime FechaEmision { get; set; }
        public int IdProveedor { get; set; }
        public string Observaciones { get; set; }
        public string Usuario { get; set; }
        public decimal Total { get; set; }
        public List<ProductIdentityDto> ProductosList { get; set; }

    }
}
