using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HendrixAccountant.ApplicationCore.Entities
{
    [Table("ENTRADAS", Schema = "inventory")]
    public class ProductEntry
    {
        [Key]
        public long entrada_id { get; set; }
        public DateTime fecha_emision { get; set; }
        public string numero_comprobante { get; set; }
        public int tipo_comprobante { get; set; }
        public long proveedor_id { get; set; }
        public string observaciones { get; set; }
        public int producto_id { get; set; }
        public string nombre_producto { get; set; }
        public int stock_actual { get; set; }
        public int stock_nuevo { get; set; }
        public int cantidad { get; set; }
        public decimal precio_compra { get; set; }
        public decimal precio_venta { get; set; }
        public decimal total_compra { get; set; }
        public bool estado { get; set; }
        public DateTime creado_en { get; set; }
        public string usuario_crea { get; set; }
        public DateTime modificado_en { get; set; }
        public string usuario_mod { get; set; }
        public DateTime eliminado_en { get; set; }
        public string usuario_elim { get; set; }
    }
}
