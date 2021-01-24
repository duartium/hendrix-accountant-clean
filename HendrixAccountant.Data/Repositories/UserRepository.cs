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

    }
}
