using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HendrixAccountant.Common
{
    public class DataBase : ISqlServer
    {
        private SqlConnection _sqlConn = null;
        private string _strConnection = String.Empty;

        public SqlConnection SqlConn { get => _sqlConn; set => _sqlConn = value; }
        public string StrConnection { get => _strConnection; set => _strConnection = value; }

        public DataBase()
        {
//            this.Connect();
        }


        public DataSet ExecuteProcedure(string connectionString, string nameProcedure, List<SqlParameter> parameters = null)
        {
            throw new NotImplementedException();
        }

        public DataSet ExecuteProcedure(string nameProcedure, List<SqlParameter> parameters = null)
        {
            DataSet ds = null;
            SqlDataAdapter adapter = null;
            try
            {
                using (this.SqlConn = new SqlConnection())
                {
                    this.Connect();
                    using (var cmd = new SqlCommand(nameProcedure, this.SqlConn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        if (parameters != null)
                            foreach (var item in parameters)
                                cmd.Parameters.AddWithValue(item.ParameterName, item.Value);

                        ds = new DataSet("RESULTS");
                        adapter = new SqlDataAdapter(cmd);
                        adapter.Fill(ds);
                    }
                }
            }
            catch (Exception ex)
            {
                Utils.GrabarLog("ExecuteProcedure", ex.ToString());
            }
            finally
            {
                if (this._sqlConn.State == ConnectionState.Open)
                    this._sqlConn.Close();
            }
            return ds;
        }

        public int ExecuteNonQuery(string nameProcedure, List<SqlParameter> parameters = null)
        {
            int rowsAffected = -1;
            try
            {
                using (this.SqlConn = new SqlConnection())
                {
                    this.Connect();
                    using (var cmd = new SqlCommand(nameProcedure, this.SqlConn))
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                        if (parameters != null)
                            foreach (var item in parameters)
                                cmd.Parameters.AddWithValue(item.ParameterName, item.Value);

                        rowsAffected = cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                Utils.GrabarLog("ExecuteProcedure", ex.ToString());
            }
            finally
            {
                if (this._sqlConn.State == ConnectionState.Open)
                    this._sqlConn.Close();
            }
            return rowsAffected;
        }


        private void Connect()
        {
            try
            {
                if (_sqlConn.State == ConnectionState.Closed)
                {
                    this._sqlConn.ConnectionString = GetConnectionData();
                    this._sqlConn.Open();
                }
            }
            catch (Exception ex)
            {
                Utils.GrabarLog("Connect", ex.ToString());
            }
        }

        private string GetConnectionData()
        {
            string conn = String.Empty;
            try
            {
                string server, database, username, password;
                server = ConfigurationManager.AppSettings["server"];
                database = ConfigurationManager.AppSettings["database"];
                username = ConfigurationManager.AppSettings["username"];
                password = ConfigurationManager.AppSettings["password"];

                conn = "Data Source =" + server + "; Initial Catalog =" + database + "; User ID =" + username + "; Password =" + password + ";Pooling=false";
            }
            catch (Exception ex)
            {
                Utils.GrabarLog("GetConnectionString", ex.ToString());
            }
            return conn;
        }


    }

}
