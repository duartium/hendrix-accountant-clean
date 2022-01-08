using HendrixAccountant.ApplicationCore.Models;
using HendrixAccountant.Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HendrixAccountant.ApplicationCore.Map
{
    public class CashMapper
    {
        public CashMovement DatasetToCashToday(DataSet data)
        {
            if (!Validator.DatasetIsValid(data)) return null;

            CashMovement cashMovement = null;
            try
            {
                cashMovement = data.Tables[0].AsEnumerable().Select(field => new CashMovement
                {
                    IdMovimiento = Convert.ToInt32(field["id_movimiento"].ToString()),
                    FechaHoraApertura = field["fecha"].ToString(),
                    TipoMovimiento = int.Parse(field["tipo_movimiento"].ToString()),
                    Ingresos = Convert.ToDecimal(field["ingresos"].ToString(), Utils.GetCulture()),
                    Egresos = Convert.ToDecimal(field["egresos"].ToString(), Utils.GetCulture()),
                    Saldo = Convert.ToDecimal(field["saldo"].ToString(), Utils.GetCulture()),
                    IdUsuario = Convert.ToInt32(field["usuario_id"].ToString()),
                    IdCaja = Convert.ToInt32(field["caja_id"].ToString())
                }).FirstOrDefault();
            }
            catch (Exception ex)
            {
                Utils.GrabarLog("DatasetToProduct", ex.ToString());
            }

            return cashMovement;
        }
    }
}
