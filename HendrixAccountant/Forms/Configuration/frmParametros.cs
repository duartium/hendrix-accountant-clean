using HendrixAccountant.ApplicationCore.Constants;
using HendrixAccountant.ApplicationCore.Interfaces.Repositories;
using HendrixAccountant.ApplicationCore.Interfaces.Services;
using HendrixAccountant.ApplicationCore.Map;
using HendrixAccountant.ApplicationCore.Models;
using HendrixAccountant.Common;
using HendrixAccountant.Data.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HendrixAccountant
{
    public partial class frmParametros : Form
    {
        private IParameterRepository _rpsParams;
        private Company _company;
        public frmParametros()
        {
            InitializeComponent();
            pnHeader.BackColor = DataOperator.Instance.ColorPrimary;
            _rpsParams = new CompanyRepository();
        }

        private void frmParametros_Load(object sender, EventArgs e)
        {
            GetCompany();
            if(_company != null)
                EnabledTextboxs(false);
            else
            {
                EnabledTextboxs(true);
                txtRuc.Focus();
            }
            LoadPrintersList();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if(txtRuc.Text.Trim().Length == 0 && txtNombreComercial.Text.Trim().Length == 0)
            {
                MessageBox.Show("RUC y Nombre comercial son campos obligatorios.", CString.DEFAULT_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

           IParameter company = new Company
            { 
                Ruc = txtRuc.Text.Trim(),
                NombreComercial = txtNombreComercial.Text,
                RazonSocial = txtRazonSocial.Text,
                DirMatriz = txtDireccion.Text
            };
            if (_rpsParams.CreateOrUpdate(company))
                MessageBox.Show("Se guardaron con éxito los datos de la empresa.", CString.DEFAULT_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("No se pudo grabar los datos de la empresa.", CString.DEFAULT_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Information);
            EnabledTextboxs(false);
            chkEditar.Checked = false;
        }

        private void LoadPrintersList()
        {
            var printers = GetAllPrinterList();
            cmbImpresoras.DataSource = printers;
        }

        private List<string> GetAllPrinterList()
        {
            var printers = new List<string>();
            var printerQuery = new ManagementObjectSearcher("SELECT * from Win32_Printer");
            foreach (var printer in printerQuery.Get())
                printers.Add(printer.GetPropertyValue("Name").ToString());
            return printers;
        }

        private void EnabledTextboxs(bool value)
        {
            txtRuc.Enabled = value;
            txtNombreComercial.Enabled = value;
            txtRazonSocial.Enabled = value;
            txtDireccion.Enabled = value;
        }

        private void chkEditar_CheckedChanged(object sender, EventArgs e)
        {
            if (chkEditar.Checked)
            {
                EnabledTextboxs(true);
                txtRuc.Focus();
            }
            else
                EnabledTextboxs(false);
        }

        private void GetCompany()
        {
            _company = _rpsParams.Get() as Company;
            SetCompany(_company);
        }

        private void SetCompany(Company company)
        {
            if (company == null) return;
            txtRuc.Text = company.Ruc;
            txtRazonSocial.Text = company.RazonSocial;
            txtNombreComercial.Text = company.NombreComercial;
            txtDireccion.Text = company.DirMatriz;
        }

        private void frmParametros_Activated(object sender, EventArgs e)
        {
            if (_company == null)
                txtRuc.Focus();
        }

        private void btnGuardarParamsImp_Click(object sender, EventArgs e)
        {
            var parameters = new List<Parameters>();
            parameters.Add(new Parameters { Nombre = "impresora", Valor= cmbImpresoras.SelectedItem.ToString() });
            parameters.Add(new Parameters { Nombre = "formato_comprobante", Valor = rbA4.Checked ? "1" :  "2" });

            if (_rpsParams.CreateOrUpdate(parameters))
                MessageBox.Show("Se guardaron los datos de impresión.", CString.DEFAULT_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("No se pudo grabar los datos de impresión.", CString.DEFAULT_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void tcEmpresa_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (tcParametros.SelectedTab == tcParametros.TabPages[tpImpresora.Name])
                {
                    SetPrintParams();
                }
            }
            catch (Exception ex)
            {
                Utils.GrabarLog("SetPrintParams", ex.ToString());
                MessageBox.Show(ex.Message, CString.DEFAULT_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void SetPrintParams()
        {
            var printParams = _rpsParams.GetPrintParams();
            cmbImpresoras.SelectedItem = printParams.Where(x => x.Nombre.Equals("impresora"))
                .Select(x => x.Valor).FirstOrDefault();
            
            int formatoComprobante = int.Parse(printParams.Where(x => x.Nombre.Equals("formato_comprobante"))
                .Select(x => x.Valor).FirstOrDefault().ToString());

            if (formatoComprobante == 1)
                rbA4.Checked = true;
            else
                rbTicket.Checked = true;
        }

    }
}
