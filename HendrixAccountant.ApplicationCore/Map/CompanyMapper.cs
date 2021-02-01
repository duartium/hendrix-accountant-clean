using HendrixAccountant.ApplicationCore.Models;
using HendrixAccountant.Common;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
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

        public DataTable JsonCompanyToDataTable(Company company)
        {
            DataTable dtCompany = null;
            if (company == null) return null;
            try
            {
                dtCompany = new DataTable("dtCompany");
                dtCompany.Columns.Add("RazonSocial");
                dtCompany.Columns.Add("NombreComercial");
                dtCompany.Columns.Add("Ruc");
                dtCompany.Columns.Add("DirMatriz");

                DataRow dr = dtCompany.NewRow();
                dr["RazonSocial"] = company.RazonSocial;
                dr["NombreComercial"] = company.NombreComercial;
                dr["Ruc"] = company.Ruc;
                dr["DirMatriz"] = company.DirMatriz;
                dtCompany.Rows.Add(dr);
            }
            catch (Exception ex)
            {
                Utils.GrabarLog("JsonToCompany", ex.ToString());
            }
            return dtCompany;
        }
    }
}
