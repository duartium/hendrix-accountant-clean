using HendrixAccountant.Common;
using HendrixAccountant.Data.Dtos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HendrixAccountant.ApplicationCore.Map
{
    public class UserMapper
    {
        public List<UserDto> DatasetToUsers(DataSet data)
        {
            if (!Validator.DatasetIsValid(data)) return null;

            List<UserDto> products = null;
            try
            {
                products = data.Tables[0].AsEnumerable().Select(field => new UserDto
                {
                    IdUsuario = Convert.ToInt32(field["idUsuario"].ToString()),
                    Usuario = field["usuario"].ToString(),
                    Clave = field["clave"].ToString(),
                    IdRol = Convert.ToInt32(field["rolId"].ToString()),
                    NombreRol = field["nombreRol"].ToString(),
                    FechaCreacion = field["creadoEn"].ToString()
                }).ToList();
            }
            catch (Exception ex )
            {
                Utils.GrabarLog("DatasetToUsers", ex.ToString());
            }
            return products;
        }

        public UserAuthDto DatasetToUser(DataSet data)
        {
            if (!Validator.DatasetIsValid(data))
                return null;

            UserAuthDto user = null;
            try
            {
                user = data.Tables[0].AsEnumerable().Select(field => new UserAuthDto
                {
                    IdUsuario = Convert.ToInt32(field["idUsuario"].ToString()),
                    Usuario = field["usuario"].ToString(),
                    IdRol = Convert.ToInt32(field["rolId"].ToString()),
                    NombreRol = field["rol"].ToString()
                }).FirstOrDefault();
            }
            catch (Exception ex)
            {
                Utils.GrabarLog("DatasetToUsers", ex.ToString());
            }
            return user;
        }

        public List<Rol> DatasetToRol(DataSet data)
        {
            if (!Validator.DatasetIsValid(data)) return null;

            List<Rol> rol = null;
            try
            {
                rol = data.Tables[0].AsEnumerable().Select(field => new Rol
                {
                    IdRol = Convert.ToInt32(field["idRol"].ToString()),
                    Nombre = field["nombre"].ToString()
                }).ToList();
            }
            catch (Exception ex)
            {
                Utils.GrabarLog("DatasetToRol", ex.ToString());
            }
            return rol;
        }
    }
}

