using HendrixAccountant.ApplicationCore.DTOs;
using HendrixAccountant.ApplicationCore.Entities;
using HendrixAccountant.ApplicationCore.Interfaces.Repositories;
using HendrixAccountant.ApplicationCore.Map;
using HendrixAccountant.Common;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HendrixAccountant.Data.Repositories
{
    public class KardexRepository : IKardexRepository
    {
        private readonly ISqlServer _sqlServer;

        public KardexRepository()
        {
            _sqlServer = new DataBase();
        }

        #region  "Nombre de los procedimientos de operación"
        private const string _storeProcedureName = "SP_KARDEX";
        #endregion

        public IEnumerable<Kardex> GetAll(KardexFilterDto filters)
        {
            try
            {
                var parms = new List<SqlParameter>();
                parms.Add(new SqlParameter("@accion", 'G'));
                parms.Add(new SqlParameter("@id_producto", filters.IdProducto));
                parms.Add(new SqlParameter("@fecha_desde", filters.FechaDesde));
                parms.Add(new SqlParameter("@fecha_hasta", filters.FechaHasta));
                parms.Add(new SqlParameter("@tipo_movimiento", filters.TipoMovimiento));
                var dsResp = _sqlServer.ExecuteProcedure(_storeProcedureName, parms);
                return new KardexMapper().DatasetToKardex(dsResp);
            }
            catch (Exception ex)
            {
                Utils.GrabarLog("GetAll", ex.ToString());
                return null;
            }
        }
    }
}
