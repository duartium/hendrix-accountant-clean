using HendrixAccountant.ApplicationCore.Models;
using HendrixAccountant.Common;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HendrixAccountant.ApplicationCore.Map
{
    public class CompanyMapper
    {
        public Company JsonToCompany(string jsonCompany)
        {
            Company company = null;
            if (jsonCompany == null) return null;
            try
			{
                company = JsonConvert.DeserializeObject<Company>(jsonCompany);
            }
			catch (Exception ex){
                Utils.GrabarLog("JsonToCompany", ex.ToString());
			}
            return company;
        }
    }
}
