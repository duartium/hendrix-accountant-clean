using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HendrixAccountant.ApplicationCore.DTOs
{
    public class SupplierDto : ISaleElement
    {
        public int IdProveedor { get; set; }
        public string Ruc { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Email { get; set; }
        public string Usuario { get; set; }
        public bool IsDefault { get; set; }
    }

    public class ComboBoxProveedorDTO
    {
        public long Id { get; set; }
        public string Descripcion { get; set; }
    }
}
