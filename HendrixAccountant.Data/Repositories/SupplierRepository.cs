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
    public class SupplierRepository : ISupplierRepository
    {
        #region  "Nombre de los procedimientos de operación"
        private const string _storeProcedureName = "SP_SUPPLIERS";
        #endregion

        private readonly ISqlServer _sqlServer;
        public SupplierRepository()
        {
            this._sqlServer = new DataBase();
        }

        //public List<SupplierDto> GetAll(SupplierDto supplier)
        //{
        //    var parms = new List<SqlParameter>();
        //    parms.Add(new SqlParameter("@accion", 'G'));
        //    parms.Add(new SqlParameter("@identificacion", supplier.Identificacion));
        //    parms.Add(new SqlParameter("@nombres", filters.Nombres));
        //    parms.Add(new SqlParameter("@apellidos", filters.Apellidos));
        //    var dsResp = _sqlServer.ExecuteProcedure(_storeProcedureName, parms);
        //    return new SupplierMapper().DatasetToSupplierS(dsResp); ;
        //}

        public bool Save(SupplierDto supplier, bool isUpdate = false)
        {
            char action = 'I';
            if (isUpdate) action = 'M';

            var parms = new List<SqlParameter>();
            parms.Add(new SqlParameter("@accion", action));
            parms.Add(new SqlParameter("@usuario", supplier.Usuario));
            parms.Add(new SqlParameter("@ruc", supplier.Ruc));
            parms.Add(new SqlParameter("@nombre", supplier.Nombre));
            parms.Add(new SqlParameter("@direccion", supplier.Direccion));
            parms.Add(new SqlParameter("@email", supplier.Email));
            if (isUpdate) parms.Add(new SqlParameter("@id_proveedor", supplier.IdProveedor));
            int resp = _sqlServer.ExecuteNonQuery(_storeProcedureName, parms);
            if (resp > 0) return true; else return false;
        }

        public bool Remove(int idProveedor, string usuario)
        {
            var parms = new List<SqlParameter>();
            parms.Add(new SqlParameter("@accion", "E"));
            parms.Add(new SqlParameter("@usuario", usuario));
            parms.Add(new SqlParameter("@id_proveedor", idProveedor));
            int resp = _sqlServer.ExecuteNonQuery(_storeProcedureName, parms);
            if (resp > 0) return true; else return false;
        }

        public List<SupplierDto> GetAll(SupplierFilterDto dto)
        {
            var parms = new List<SqlParameter>();
            parms.Add(new SqlParameter("@accion", 'G'));
            parms.Add(new SqlParameter("@id_proveedor", dto.IdProveedor));
            parms.Add(new SqlParameter("@nombre", dto.NombreProveedor));
            var dsResp = _sqlServer.ExecuteProcedure(_storeProcedureName, parms);
            return new SupplierMapper().DatasetToSuppliers(dsResp);
        }
    }
}
