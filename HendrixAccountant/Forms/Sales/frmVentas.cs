﻿using HendrixAccountant.ApplicationCore.Constants;
using HendrixAccountant.ApplicationCore.DTOs;
using HendrixAccountant.ApplicationCore.Enums;
using HendrixAccountant.ApplicationCore.Interfaces.Forms;
using HendrixAccountant.ApplicationCore.Interfaces.Repositories;
using HendrixAccountant.ApplicationCore.Interfaces.Services;
using HendrixAccountant.ApplicationCore.Map;
using HendrixAccountant.ApplicationCore.Models;
using HendrixAccountant.Data;
using HendrixAccountant.Data.Dtos;
using HendrixAccountant.Data.Services;
using HendrixAccountant.Reports;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HendrixAccountant.Forms
{
    public partial class frmVentas : Form, IFindElement
    {
        private readonly IReports _rpsReports;
        private DataSet _dsResp;
        private  ConsultaVenta consultaVenta;
        private ClientIdentity _client;
        private UserDto _user;
        private TipoReporte _tipoReporte;
        private IClientRepository _rpsClient;
        public frmVentas()
        {
            InitializeComponent();
            _rpsReports = new SaleReportService();
            _dsResp = null;
            _client = null;
            _user = null;
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            Search();
        }



        private void rptVentas_Load(object sender, EventArgs e)
        {
            EnabledPrint(false);
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            if(consultaVenta == ConsultaVenta.COMP_INDIVIDUAL && dgvComprobanteInd.Rows.Count <= 0)
            {
                MessageBox.Show("Realice la consulta para procesar el reporte. No existen datos para imprimir.", CString.DEFAULT_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }else if (consultaVenta == ConsultaVenta.GENERAL && dgvVentaGeneral.Rows.Count <= 0)
            {
                MessageBox.Show("Realice la consulta para procesar el reporte. No existen datos para imprimir.", CString.DEFAULT_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            frmReportVentas frmReportVentas = new frmReportVentas(new ReportData { Data = _dsResp, TipoReporte = _tipoReporte });
            frmReportVentas.ShowDialog();
        }

        private void FillGrid()
        {
            if (_dsResp == null) return;

            dgvVentaGeneral.Rows.Clear();
            dgvComprobanteInd.Rows.Clear();

            if (_dsResp.Tables["Table1"].Rows.Count <= 0)
            {
                EnabledPrint(false);
                return;
            }

            if(consultaVenta == ConsultaVenta.COMP_INDIVIDUAL)
                foreach (var row in _dsResp.Tables[2].AsEnumerable())
                    dgvComprobanteInd.Rows.Add(row.ItemArray[0], row.ItemArray[1], row.ItemArray[2], row.ItemArray[3], row.ItemArray[4]);
            else
                foreach (var row in _dsResp.Tables[1].AsEnumerable())
                    dgvVentaGeneral.Rows.Add(row.ItemArray[1], row.ItemArray[2], row.ItemArray[4], row.ItemArray[7], row.ItemArray[8]);
            EnabledPrint(true);
        }

        private void frmVentas_Activated(object sender, EventArgs e)
        {
            txtIdentCliente.Focus();
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            frmBuscarClientes frmBuscarClientes = new frmBuscarClientes(this);
            frmBuscarClientes.ShowDialog();
        }

        public void Selected(ISaleElement entity)
        {
            if (entity == null) return;

            switch (entity.GetType().Name)
            {
                case "ClientIdentity":
                    _client = entity as ClientIdentity;
                    txtIdentCliente.Text = _client.Identificacion;
                    txtNombresCliente.Text = _client.NombresCompletos;
                    break;
                case "UserDto":
                    _user = entity as UserDto;
                    txtCodUsuario.Text = _user.IdUsuario.ToString();
                    txtNombreUsuario.Text = _user.Usuario;
                    break;
                default:
                    break;
            }
        }

        private void btnBuscarUsuario_Click(object sender, EventArgs e)
        {
            frmBuscarUsuario frmBuscarUsuario = new frmBuscarUsuario(this);
            frmBuscarUsuario.ShowDialog();
        }

        private void tabControlVentas_Selected(object sender, TabControlEventArgs e)
        {
            
        }

        private void tabControlVentas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControlVentas.SelectedTab.Name.Equals("tpGeneral"))
            {
                txtIdentCliente.Focus();
            }
            else
            {
                txtNumSecuencial.Focus();
            }
        }

        private void Search()
        {
            if (tabControlVentas.SelectedTab.Name.Equals("tpGeneral"))
            {
                consultaVenta = ConsultaVenta.GENERAL;
                _tipoReporte = TipoReporte.VENTAS_GENERALES;
                if (dtpFechaDesde.Value.Date > dtpFechaHasta.Value.Date)
                {
                    MessageBox.Show("La 'fecha desde' no puede ser mayor a 'fecha hasta'.", CString.DEFAULT_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                if (txtIdentCliente.Text.Length > 0 && txtIdentCliente.Text.Length < 10)
                {
                    MessageBox.Show("Identificación de cliente no válida.", CString.DEFAULT_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                var salesFilters = new SalesFilterDto
                {
                    FechaDesde = dtpFechaDesde.Value.Date.ToShortDateString(),
                    FechaHasta = dtpFechaHasta.Value.Date.ToShortDateString(),
                    IdCliente = (_client != null) ? _client.IdCliente : -1,
                    IdUsuario = (_user != null) ? _user.IdUsuario : -1
                };

                if (_dsResp != null) _dsResp.Clear();
                _dsResp = _rpsReports.Get(salesFilters);
                if (_dsResp == null)
                {
                    MessageBox.Show("No se obtuvieron resultados de la búsqueda.", CString.DEFAULT_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (_dsResp.Tables["table1"].Rows.Count <= 0)
                {
                    MessageBox.Show("No se obtuvieron resultados de la búsqueda.", CString.DEFAULT_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                FillGrid();
                
            }
            else if (tabControlVentas.SelectedTab.Name.Equals("tpCIndividual"))
            {
                consultaVenta = ConsultaVenta.COMP_INDIVIDUAL;
                _tipoReporte = TipoReporte.FACTURA_VENTA;
                if (txtNumSecuencial.Text.Length <= 0)
                {
                    MessageBox.Show("Ingrese en número de factura para realizar la búsqueda.", CString.DEFAULT_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                _dsResp = _rpsReports.GetByInvoice(txtNumSecuencial.Text.Trim());
                if (!Validator.DatasetIsValid(_dsResp))
                {
                    MessageBox.Show("No se obtuvieron resultados de la búsqueda.", CString.DEFAULT_TITLE);
                    return;
                }
                FillGrid();
                EnabledPrint(true);
            }
        }

        private void txtNumSecuencial_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
                Search();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void Clear()
        {
            if (consultaVenta == ConsultaVenta.COMP_INDIVIDUAL){
                txtNumSecuencial.Clear();
                dgvComprobanteInd.Rows.Clear();
            }
            else
            {
                txtCodUsuario.Clear();
                txtNombreUsuario.Clear();
                txtIdentCliente.Clear();
                txtNombresCliente.Clear();
                dtpFechaDesde.Value = DateTime.Now;
                dtpFechaHasta.Value = DateTime.Now;
                dgvVentaGeneral.Rows.Clear();
            }
            
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtIdentCliente_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                GetClient();
                e.Handled = e.SuppressKeyPress = true;
            }
        }

        private void GetClient()
        {
            if (txtIdentCliente.Text.Length <= 0)
            {
                MessageBox.Show("Ingrese la identifiación para buscar el cliente.", CString.DEFAULT_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (txtIdentCliente.Text.Length < 10)
            {
                MessageBox.Show("Ingrese una identifiación válida.", CString.DEFAULT_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _rpsClient = new ClienteRepository();
            var client = _rpsClient.GetByIdentification(txtIdentCliente.Text);
            if (client == null)
            {
                MessageBox.Show("No se econtró el cliente con la identificación: " + txtIdentCliente.Text + ".", CString.DEFAULT_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            _client = new ClientIdentity
            {
                IdCliente = client.id_cliente,
                Identificacion = client.identificacion,
                NombresCompletos = client.nombres + " " + client.apellidos
            };
            SetClient();
        }

        private void SetClient()
        {
            if (_client == null) return;
            txtIdentCliente.Text = _client.Identificacion;
            txtNombresCliente.Text = _client.NombresCompletos;
        }

        private void EnabledPrint(bool valor)
        {
            if (valor)
            {
                btnImprimir.Enabled = valor;
                btnImprimir.BackColor = Color.FromArgb(253, 184, 39);
            }
            else
            {
                btnImprimir.Enabled = valor;
                btnImprimir.BackColor = Color.DimGray;
            }
            
        }
    }
}
