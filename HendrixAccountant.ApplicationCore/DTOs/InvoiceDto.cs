using HendrixAccountant.ApplicationCore.Models;
using System;
using System.Collections.Generic;

namespace HendrixAccountant.ApplicationCore.DTOs
{
    public class InvoiceDto
    {
        public int ClienteId { get; set; }
        public int FormaPago { get; set; }
        public DateTime FechaEmision { get; set; }
        public decimal BaseImponible { get; set; }
        public decimal TotalDescuento { get; set; }
        public decimal IVA { get; set; }
        public decimal Total { get; set; }
        public List<ProductIdentityDto> Detalle { get; set; }
        public Audit Auditoria { get; set; }
    }

    public class InvoiceHeader
    {
        public int IdFactura { get; set; }
        public int Secuencial { get; set; }
        public DateTime FechaEmision { get; set; }
        public decimal NombresCliente { get; set; }
        public decimal BaseImponible { get; set; }
        public decimal Iva { get; set; }
        public decimal Total { get; set; }
        public decimal UsuarioCrea { get; set; }
    }
}
