using HendrixAccountant.ApplicationCore.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HendrixAccountant.ApplicationCore.Models
{
    public class Company : IParameter
    {
        public int IdCompania { get; set; }
        public string RazonSocial { get; set; }
        public string NombreComercial { get; set; }
        public string Ruc { get; set; }
        public string DirMatriz { get; set; }
    }
}
