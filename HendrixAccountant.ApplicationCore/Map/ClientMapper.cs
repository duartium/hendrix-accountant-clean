using HendrixAccountant.ApplicationCore.DTOs;
using HendrixAccountant.ApplicationCore.Entities;
using HendrixAccountant.Common;
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
                    TipoCliente = Convert.ToInt32(field["tipo_cliente"].ToString()),
                    Nombres = field["nombres"].ToString(),
                    Apellidos = field["apellidos"].ToString(),
                    Telefono = field["telefono"].ToString(),
                    Celular = field["celular"].ToString(),
                    Direccion = field["direccion"].ToString(),
                    Email = field["email"].ToString(),
                    FechaNacimiento = field["fecha_nacimiento"].ToString()
                }).ToList();
            }
            catch (Exception ex)
            {
            }
            return clientes;
        }

        public Client DatasetToClient(DataSet data)
        {
            if (!Validator.DatasetIsValid(data))
                return null;

            Client client = null;
            try
            {
                client = data.Tables[0].AsEnumerable().Select(field => new Client
                {
                    id_cliente = Convert.ToInt32(field["id_cliente"].ToString()),
                    identificacion = field["identificacion"].ToString(),
                    tipo_identificacion = Convert.ToInt32(field["tipo_identificacion"].ToString()),
                    tipo_cliente = Convert.ToInt32(field["tipo_cliente"].ToString()),
                    nombres = field["nombres"].ToString(),
                    apellidos = field["apellidos"].ToString(),
                    telefono = field["telefono"].ToString(),
                    celular = field["celular"].ToString(),
                    direccion = field["direccion"].ToString(),
                    email = field["email"].ToString(),
                    fecha_nacimiento = field["fecha_nacimiento"].ToString()
                }).FirstOrDefault();
            }
            catch (Exception ex)
            {
                Utils.GrabarLog("DatasetToClient", ex.ToString());
            }
            return client;
        }
    }
}
