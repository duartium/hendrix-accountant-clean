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
    
    public partial class VENTAS
    {
        public int id_venta { get; set; }
        public int cliente_id { get; set; }
        public int usuario_id { get; set; }
        public int factura_id { get; set; }
        public System.DateTime fecha { get; set; }
        public string usuario_crea { get; set; }
        public System.DateTime creado_en { get; set; }
        public string usuario_mod { get; set; }
        public Nullable<System.DateTime> modificado_en { get; set; }
        public string usuario_elim { get; set; }
        public Nullable<System.DateTime> elminado_en { get; set; }
    }
}
