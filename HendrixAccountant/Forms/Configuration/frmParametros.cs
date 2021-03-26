using HendrixAccountant.ApplicationCore.Constants;
using HendrixAccountant.ApplicationCore.Interfaces.Repositories;
using HendrixAccountant.ApplicationCore.Interfaces.Services;
using HendrixAccountant.ApplicationCore.Map;
using HendrixAccountant.ApplicationCore.Models;
using HendrixAccountant.Data.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

        private void EnabledTextboxs(bool value)
        {
            txtRuc.Enabled = value;
            txtNombreComercial.Enabled = value;
            txtRazonSocial.Enabled = value;
            txtDireccion.Enabled = value;
        }

        private void chkEditar_CheckedChanged(object sender, EventArgs e)
        {
            EnabledTextboxs(true);
            txtRuc.Focus();
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
    }
}
