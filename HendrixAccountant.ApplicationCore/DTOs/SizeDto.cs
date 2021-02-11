using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HendrixAccountant.ApplicationCore.DTOs
{
    public class SizeDto : ISaleElement
    {
        public string Usuario { get; set; }
        public int IdTalla { get; set; }
        public string Codigo { get; set; }
        public string Descripcion { get; set; }
    }
}
