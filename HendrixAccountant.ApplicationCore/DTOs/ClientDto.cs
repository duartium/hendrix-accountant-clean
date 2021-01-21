using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HendrixAccountant.ApplicationCore.DTOs
{
    public class ClientDto
    {
        private string _nombres = String.Empty;
        private string _apellidos = String.Empty;

        public int IdCliente { get; set; }
        public string Identificacion { get; set; }
        public int TipoIdentificacion { get; set; }
        public int TipoCliente { get; set; }
        public string Nombres { get => _nombres; set => _nombres = value; }
        public string Apellidos { get => _apellidos; set => _apellidos = value; }
        public string NombresCompletos { get { return _nombres + " " + _apellidos; } }
        public string Telefono { get; set; }
        public string Celular { get; set; }
        public string Direccion { get; set; }
        public string Email { get; set; }
    }

    public class ClientIdentity : ISaleElement
    {
        public int IdCliente { get; set; }
        public string Identificacion { get; set; }
        public string NombresCompletos { get; set; }
    }
}
