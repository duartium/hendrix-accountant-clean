using HendrixAccountant.ApplicationCore.DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HendrixAccountant.ApplicationCore.Entities
{
    //[Table("PRODUCTOS", Schema = "inventory")]
    public class Product : ISaleElement
    {
        //[Key]
        public int id_producto { get; set; }
        public string nombre { get; set; }
        public string descripcion { get; set; }
        public decimal costo { get; set; }
        public decimal precio_venta { get; set; }
        public int stock { get; set; }
        public decimal descuento { get; set; }
        public int id_talla { get; set; }
        public string talla { get; set; }
        public int marca { get; set; }
        public int color { get; set; }
        public bool estado { get; set; }
        public int categoria_id { get; set; }
        public string categoria { get; set; }
        public int proveedor_id { get; set; }
        public string proveedor { get; set; }
        public DateTime creado_en { get; set; }
        public string usuario_crea { get; set; }
        public DateTime modificado_en { get; set; }
        public string usuario_mod { get; set; }
        public DateTime eliminado_en { get; set; }
        public string usuario_elim { get; set; }
    }
}
