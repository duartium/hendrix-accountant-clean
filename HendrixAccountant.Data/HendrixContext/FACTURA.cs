//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HendrixAccountant.Data.HendrixContext
{
    using System;
    using System.Collections.Generic;
    
    public partial class FACTURA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FACTURA()
        {
            this.FACTURA_DETALLE = new HashSet<FACTURA_DETALLE>();
        }
    
        public int id_factura { get; set; }
        public int secuencial { get; set; }
        public int usuario_id { get; set; }
        public int cliente_id { get; set; }
        public System.DateTime fecha_emision { get; set; }
        public decimal base_imponible { get; set; }
        public decimal iva { get; set; }
        public decimal total { get; set; }
        public bool estado { get; set; }
        public string usuario_crea { get; set; }
        public System.DateTime creado_en { get; set; }
        public string usuario_mod { get; set; }
        public Nullable<System.DateTime> modificado_en { get; set; }
        public string usuario_elim { get; set; }
        public Nullable<System.DateTime> eliminado_en { get; set; }
        public Nullable<decimal> descuento { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FACTURA_DETALLE> FACTURA_DETALLE { get; set; }
    }
}