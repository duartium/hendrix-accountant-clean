using HendrixAccountant.ApplicationCore.DTOs;
using HendrixAccountant.Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HendrixAccountant.ApplicationCore.Map
{
    public class ReportMapper
    {
        public DataTable criteriosToDataTable(List<ReportCriteriaDto> criterios)
        {
            DataTable dtCriterios = null;
            if (criterios == null) return null;
            try
            {
                dtCriterios = new DataTable("dtCriterios");
                dtCriterios.Columns.Add("nombre");
                dtCriterios.Columns.Add("descripcion");

                foreach (var item in criterios)
                {
                    DataRow dr = dtCriterios.NewRow();
                    dr["nombre"] = item.Nombre;
                    dr["descripcion"] = item.Descripcion;
                    dtCriterios.Rows.Add(dr);
                }
            }
            catch (Exception ex)
            {
                Utils.GrabarLog("criteriosToDataTable", ex.ToString());
            }
            return dtCriterios;
        }
    }
}
