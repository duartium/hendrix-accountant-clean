using HendrixAccountant.Common;
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
        #endregion
        private ISqlServer _sqlServer;
        public UserRepository()
        {
            this._sqlServer = new DataBase();
        }
        public bool Authenticate(string username, string password)
        {
            bool isAutenticated = false;
            try
            {
                var parms = new List<SqlParameter>();
                parms.Add(new SqlParameter("@accion", 'C'));
                parms.Add(new SqlParameter("@usuario", ""));
                parms.Add(new SqlParameter("@username", username));
                parms.Add(new SqlParameter("@password", Encrypt.GetSHA256(password)));

                var resp = _sqlServer.ExecuteProcedure(_storeProcedureName, parms);
                if (resp == null) return false;
                if (resp.Tables.Count <= 0) return false;

                isAutenticated = Boolean.Parse((resp.Tables[0].Rows[0]["RESP"].ToString().Equals("1")) ? "true" : "false");
            }
            catch (Exception ex)
            {
                Common.Utils.GrabarLog("Authenticate", ex.ToString());
            }
            return isAutenticated;
        }
    }
}
