using HendrixAccountant.ApplicationCore.Entities;
using HendrixAccountant.ApplicationCore.Enums;
using HendrixAccountant.ApplicationCore.Interfaces.Repositories;
using HendrixAccountant.ApplicationCore.Interfaces.Services;
using HendrixAccountant.Common;
using HendrixAccountant.Data;
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

namespace HendrixAccountant.Forms.Inventory
{
    public partial class frmModalProveedor : Form
    {
        private readonly frmCompras _form;
        private IUnitOfWork _unitOfWork;
        private ISupplierService _supplierService;
        private readonly SupplierRepository _supplierRepository;
        private Supplier _supplier;
        private int _flagEstadoCrud = 0;
        public frmModalProveedor(frmCompras form)
        {
            InitializeComponent();
            this._form = (frmCompras) form;
            this._unitOfWork = new UnitOfWork(new AppDbContext());
          
            this.dgvListado.ReadOnly = true;
            this.dgvListado.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvListado.MultiSelect = false;
        }
        public frmModalProveedor()
        {
            InitializeComponent();
            this._unitOfWork = new UnitOfWork(new AppDbContext());
           
            this.dgvListado.ReadOnly = true;
            this.dgvListado.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvListado.MultiSelect = false;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            TextBox nombreProveedor  = (TextBox) this._form.Controls.Find("txtNombreProveedor", true).FirstOrDefault();
            nombreProveedor.Text = "ddd"; try
            {
                List<Supplier> data = new List<Supplier>();
                int opcionComboBuscarPor = cboBuscarPor.SelectedIndex;
                switch (opcionComboBuscarPor)
                {
                    case (int)EnumCriterioBusquedaMantProveedor.Nombre:
                        data = this._unitOfWork.Suppliers.Find(x => x.nombre.Contains(txtValorBuscarPor.Text.Trim()) && x.estado == true).ToList();
                        break;
                    case (int)EnumCriterioBusquedaMantProveedor.RUC:
                        data = this._unitOfWork.Suppliers.Find(x => x.ruc.Contains(txtValorBuscarPor.Text.Trim()) && x.estado == true).ToList();
                        break;
                    case (int)EnumCriterioBusquedaMantProveedor.Ciudad:
                        data = this._unitOfWork.Suppliers.Find(x => x.ciudad.Contains(txtValorBuscarPor.Text.Trim()) && x.estado == true).ToList();
                        break;
                    case (int)EnumCriterioBusquedaMantProveedor.Provincia:
                        data = this._unitOfWork.Suppliers.Find(x => x.provincia.Contains(txtValorBuscarPor.Text.Trim()) && x.estado == true).ToList();
                        break;
                    default:
                        if (txtValorBuscarPor.Text.Trim().Equals("*"))
                        {
                            data = this._unitOfWork.Suppliers.Find(x => x.estado == true).ToList();
                        }
                        else
                        {
                            return;
                        }
                        break;
                }

                if (data.Count == 0)
                {
                    MessageBox.Show("No se obtuvieron datos.", "Notificación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                dgvListado.AutoGenerateColumns = true;
                dgvListado.DataSource = data;
                ConfigurarColumnas();
                dgvListado.Refresh();
            }
            catch (Exception ex)
            {
                Utils.GrabarLog("Search", ex.ToString());
                MessageBox.Show("Error no controlado en el proceso.", "Proveedores", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ConfigurarColumnas()
        {
            int cantidadColumnas = dgvListado.Columns.Count;
            for (int i = 0; i < cantidadColumnas; i++)
            {
                dgvListado.Columns[i].Visible = false;
            }

            // solo mostrar las siguientes columnas
            dgvListado.Columns["nombre"].Visible = true;
            dgvListado.Columns["ruc"].Visible = true;
            dgvListado.Columns["direccion"].Visible = true;
            dgvListado.Columns["ciudad"].Visible = true;
            dgvListado.Columns["provincia"].Visible = true;
        }

        private void dgvListado_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                var objeto = (Supplier)dgvListado.CurrentRow.DataBoundItem;
                if (objeto != null)
                {
                    this._flagEstadoCrud = (int)EstadoOperacionCrud.Edicion;
                    this._supplier = new Supplier();
                    this._supplier = objeto;
                    this._form.Proveedor = objeto;
                    this._form.EstablecerProveedorEnControlesEntrada();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                Utils.GrabarLog("Search", ex.ToString());
                MessageBox.Show("Error no controlado en el proceso.", "Proveedores", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
