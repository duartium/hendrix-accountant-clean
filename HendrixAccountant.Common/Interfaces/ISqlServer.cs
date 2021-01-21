using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HendrixAccountant.Common
{
    public interface ISqlServer
    {
        DataSet ExecuteProcedure(string nameProcedure, List<SqlParameter> parameters = null);
        DataSet ExecuteProcedure(string connectionString, string nameProcedure, List<SqlParameter> parameters = null);
        int ExecuteNonQuery(string nameProcedure, List<SqlParameter> parameters = null);
    }
}
