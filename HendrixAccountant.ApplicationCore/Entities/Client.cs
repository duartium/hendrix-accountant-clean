using System;

namespace HendrixAccountant.ApplicationCore.Entities
{
    public class Client
    {
        public int id_cliente { get; set; }
        public string identificacion { get; set; }
        public int tipo_identificacion { get; set; }
        public int tipo_cliente { get; set; }
        public string nombres { get; set; }
        public string apellidos { get; set; }
        public string telefono { get; set; }
        public string celular { get; set; }
        public string direccion { get; set; }
        public string email { get; set; }
        public string fecha_nacimiento { get; set; }
        public string estado { get; set; }
        public string usuario_crea { get; set; }
        public DateTime creado_en { get; set; }
        public string usuario_mod { get; set; }
        public DateTime modificado_en { get; set; }
        public string usuario_elim { get; set; }
        public DateTime eliminado_en { get; set; }
    }
}
