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
    
    public partial class USUARIOS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public USUARIOS()
        {
            this.MOVIMIENTOS_CAJA = new HashSet<MOVIMIENTOS_CAJA>();
        }
    
        public int id_usuario { get; set; }
        public string usuario { get; set; }
        public string clave { get; set; }
        public bool estado { get; set; }
        public int rol_id { get; set; }
        public System.DateTime creado_en { get; set; }
        public string usuario_crea { get; set; }
        public Nullable<System.DateTime> modificado_en { get; set; }
        public string usuario_mod { get; set; }
        public Nullable<System.DateTime> eliminado_en { get; set; }
        public string usuario_elim { get; set; }
    
        public virtual ROLES ROLES { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MOVIMIENTOS_CAJA> MOVIMIENTOS_CAJA { get; set; }
    }
}
