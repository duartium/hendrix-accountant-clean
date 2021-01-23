using HendrixAccountant.ApplicationCore.Enums;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HendrixAccountant.ApplicationCore.Models
{
    public class ReportData
    {
        public DataSet Data { get; set; }
        public TipoReporte TipoReporte { get; set; }
    }
}
