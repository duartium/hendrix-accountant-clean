using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HendrixAccountant.ApplicationCore.Entities
{
    [Table("PRODUCTOS", Schema = "inventory")]
    public class Product
    {
        [Key]
        public int id_producto { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public decimal costo { get; set; }
        public decimal precio_venta { get; set; }
        public int stock { get; set; }
        public Nullable<decimal> descuento { get; set; }
        public Nullable<int> talla { get; set; }
        public Nullable<int> marca { get; set; }
        public Nullable<int> color { get; set; }
        public bool estado { get; set; }
        public Nullable<int> categoria_id { get; set; }
        public int proveedor_id { get; set; }
        public System.DateTime creado_en { get; set; }
        public string usuario_crea { get; set; }
        public Nullable<System.DateTime> modificado_en { get; set; }
        public string usuario_mod { get; set; }
        public Nullable<System.DateTime> eliminado_en { get; set; }
        public string usuario_elim { get; set; }
    }
}
