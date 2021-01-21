using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HendrixAccountant.ApplicationCore.Entities
{
    public class Invoice
    {
        public int id_factura { get; set; }
        public int factura_detalle_id{ get; set; }
        public int cliente_id { get; set; }
        public int usuario_id { get; set; }
        public int secuencial { get; set; }
        public DateTime fecha_emision { get; set; }
        public decimal base_imponible { get; set; }
        public decimal iva { get; set; }
        public decimal total { get; set; }
        public bool estado { get; set; }
        public string usuario_crea { get; set; }
        public DateTime modificado_en { get; set; }
        public string usuario_mod { get; set; }
        public DateTime eliminado_en { get; set; }
        public string usuario_elim { get; set; }
    }
}
