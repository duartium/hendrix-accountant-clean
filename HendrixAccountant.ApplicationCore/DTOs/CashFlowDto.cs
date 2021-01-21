using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HendrixAccountant.Data.Dtos
{
    public class CashFlowDto
    {
        public int tipoMovimiento { get; set; }
        public decimal ingresos { get; set; }
        public decimal egresos { get; set; }
        public decimal saldo { get; set; }
        public string usuario { get; set; }
    }
}
