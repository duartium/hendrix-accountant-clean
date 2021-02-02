using HendrixAccountant.ApplicationCore.Map;
using HendrixAccountant.Common;
using HendrixAccountant.Data.Dtos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HendrixAccountant.Data
{
    public class UserRepository : IUserRepository
    {
        #region  "Nombre de los procedimientos de operación"
        private const string _storeProcedureName = "SP_USER_ATHENTICATION";
        private const string SP_QRY_USERS = "SP_QRY_USERS";
        #endregion
        private ISqlServer _sqlServer;
        public UserRepository()
        {
            this._sqlServer = new DataBase();
        }
        public UserAuthDto Authenticate(string username, string password)
        {
            UserAuthDto user  = null;
            try
            {
                var parms = new List<SqlParameter>();
                parms.Add(new SqlParameter("@accion", 'A'));
                parms.Add(new SqlParameter("@username", username));
                parms.Add(new SqlParameter("@password", Encrypt.GetSHA256(password)));
                var resp = _sqlServer.ExecuteProcedure(_storeProcedureName, parms);
                user = new UserMapper().DatasetToUser(resp);
            }
            catch (Exception ex)
            {
                Utils.GrabarLog("Authenticate", ex.ToString());
            }
            return user;
        }

        public List<UserDto> GetAll()
        {
            var parms = new List<SqlParameter>();
            parms.Add(new SqlParameter("@accion", 'G'));
            var dsResp = _sqlServer.ExecuteProcedure(SP_QRY_USERS, parms);
            return new UserMapper().DatasetToUsers(dsResp);
        }

        public List<Rol> GetRol()
        {
            var parms = new List<SqlParameter>();
            parms.Add(new SqlParameter("@accion", 'R'));
            var dsResp = _sqlServer.ExecuteProcedure(SP_QRY_USERS, parms);
            return new UserMapper().DatasetToRol(dsResp);
        }

        public bool Remove(int idUser, string username)
        {
            var parms = new List<SqlParameter>();
            parms.Add(new SqlParameter("@accion", "E"));
            parms.Add(new SqlParameter("@usuario", username));
            parms.Add(new SqlParameter("@id_usuario", idUser));
            int resp = _sqlServer.ExecuteNonQuery(SP_QRY_USERS, parms);
            if (resp > 0) return true; else return false;
        }

        public bool Save(UserSaveDto user, bool isUpdate = false)
        {
            char action = 'I';
            if (isUpdate) action = 'M';

            var parms = new List<SqlParameter>();
            parms.Add(new SqlParameter("@accion", action));
            parms.Add(new SqlParameter("@usuario", user.Usuario));
            parms.Add(new SqlParameter("@nombreUsuario", user.NombreUsuario));
            parms.Add(new SqlParameter("@clave", user.Clave));
            parms.Add(new SqlParameter("@idRol", user.IdRol));
            if (isUpdate) parms.Add(new SqlParameter("@id_usuario", user.IdUsuario));
            int resp = _sqlServer.ExecuteNonQuery(SP_QRY_USERS, parms);
            if (resp > 0) return true; else return false;
        }
    }
}
