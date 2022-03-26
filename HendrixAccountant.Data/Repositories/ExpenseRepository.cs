using HendrixAccountant.ApplicationCore.DTOs;
using HendrixAccountant.ApplicationCore.Interfaces.Repositories;
using HendrixAccountant.Common;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace HendrixAccountant.Data.Repositories
{
    public class ExpenseRepository : IExpenseRepository
    {
        private readonly ISqlServer _sqlServer;

        public ExpenseRepository()
        {
            _sqlServer = new DataBase();
        }

        public bool Create(ExpenseDto expense)
        {
            var parms = new List<SqlParameter>();
            parms.Add(new SqlParameter("@opcion", "I"));
            parms.Add(new SqlParameter("@fecha", expense.Fecha));
            parms.Add(new SqlParameter("@id_tipo_gasto", expense.IdTipoGasto));
            parms.Add(new SqlParameter("@valor", expense.Valor));
            parms.Add(new SqlParameter("@detalle", expense.Detalle));
            parms.Add(new SqlParameter("@usuario", expense.Usuario));
            int resp = _sqlServer.ExecuteNonQuery("SP_EXPENSES", parms);
            return (resp > 0);
        }
    }
}
