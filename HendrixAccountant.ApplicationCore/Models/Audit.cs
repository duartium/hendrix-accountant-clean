using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HendrixAccountant.ApplicationCore.Models
{
    public class Audit
    {
        public string Ip { get; set; }
        public string SerialMainboard { get; set; }
        public int IdUser { get; set; }
        public string Username { get; set; }
    }
}
