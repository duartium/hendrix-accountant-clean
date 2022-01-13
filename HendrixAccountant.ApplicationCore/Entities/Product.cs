using HendrixAccountant.ApplicationCore.DTOs;
using System;

namespace HendrixAccountant.ApplicationCore.Entities
{
    //[Table("PRODUCTOS", Schema = "inventory")]
    public class Product : ISaleElement
    {
        //[Key]
        public int id_producto { get; set; }
        public string nombre { get; set; }
        public string codigo { get; set; }
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
        public bool es_servicio { get; set; }
        public string es_servicio_descr { get; set; }
        public int tarifa_iva { get; set; }
    }
}
