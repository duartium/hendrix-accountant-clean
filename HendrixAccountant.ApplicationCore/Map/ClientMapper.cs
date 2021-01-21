using HendrixAccountant.ApplicationCore.DTOs;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HendrixAccountant.ApplicationCore.Map
{
    public class ClientMapper
    {
        public List<ClientDto> DatasetToClients(DataSet data) {
            if (!Validator.DatasetIsValid(data))
                return null;
            
            List<ClientDto> clientes = null;
            try
            {
                clientes = data.Tables[0].AsEnumerable().Select(field => new ClientDto
                {
                    IdCliente = Convert.ToInt32(field["id_cliente"].ToString()),
                    Identificacion = field["identificacion"].ToString(),
                    TipoIdentificacion = Convert.ToInt32(field["tipo_identificacion"].ToString()),
                    TipoCliente = Convert.ToInt32(field["tipo_identificacion"].ToString()),
                    Nombres = field["nombres"].ToString(),
                    Apellidos = field["apellidos"].ToString(),
                    Telefono = field["telefono"].ToString(),
                    Celular = field["celular"].ToString(),
                    Direccion = field["direccion"].ToString(),
                    Email = field["email"].ToString()
                }).ToList();
            }
            catch (Exception)
            {
            }
            return clientes;
        }
    }
}
