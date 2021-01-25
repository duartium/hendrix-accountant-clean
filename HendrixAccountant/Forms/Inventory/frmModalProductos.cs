using HendrixAccountant.ApplicationCore.DTOs;
using HendrixAccountant.ApplicationCore.Entities;
using HendrixAccountant.ApplicationCore.Enums;
using HendrixAccountant.ApplicationCore.Interfaces.Repositories;
using HendrixAccountant.ApplicationCore.Interfaces.Services;
using HendrixAccountant.ApplicationCore.Services;
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
    public partial class frmModalProductos : Form
    {
        private readonly frmCompras compras;
        private IUnitOfWork _unitOfWork;

        private IProductService _productService;
        private readonly ProductoRepository _productoRepository;
        private Product _product;
        private int _flagEstadoCrud = 0;


        public frmModalProductos(frmCompras frmCompras)
        {
            InitializeComponent();
            this.compras = frmCompras;
            this._unitOfWork = new UnitOfWork(new AppDbContext());
            this.dgvListado.ReadOnly = true;
            this.dgvListado.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvListado.MultiSelect = true;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                this._productService = new ProductService(this._unitOfWork);
                List<Product> data = new List<Product>();
                int opcionComboBuscarPor = cboBuscarPor.SelectedIndex;
                switch (opcionComboBuscarPor)
                {
                    case (int)EnumCriterioBusquedaMantProducto.Nombre:
                        data = this._unitOfWork.Products.Find(x => x.proveedor_id == this.compras.Proveedor.proveedor_id && x.nombre.Contains(txtValorBuscarPor.Text.Trim()) && x.estado == true).ToList();
                        break;
                    case (int)EnumCriterioBusquedaMantProducto.Descripción:
                        data = this._unitOfWork.Products.Find(x => x.proveedor_id == this.compras.Proveedor.proveedor_id && x.descripcion.Contains(txtValorBuscarPor.Text.Trim()) && x.estado == true).ToList();
                        break;
                    case (int)EnumCriterioBusquedaMantProducto.PrecioDeVenta:
                        data = this._unitOfWork.Products.Find(x => x.proveedor_id == this.compras.Proveedor.proveedor_id && x.precio_venta.Equals(txtValorBuscarPor.Text.Trim()) && x.estado == true).ToList();
                        break;
                    case (int)EnumCriterioBusquedaMantProducto.Costo:
                        data = this._unitOfWork.Products.Find(x => x.proveedor_id == this.compras.Proveedor.proveedor_id && x.costo == Decimal.Parse(txtValorBuscarPor.Text.Trim()) && x.estado == true).ToList();
                        break;
                    default:
                        if (txtValorBuscarPor.Text.Trim().Equals("*"))
                        {
                            data = this._unitOfWork.Products.Find(x => x.proveedor_id == this.compras.Proveedor.proveedor_id && x.estado == true).ToList();
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
                MessageBox.Show("Error no controlado en el proceso.", "Productos", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            dgvListado.Columns["descripcion"].Visible = true;
            dgvListado.Columns["costo"].Visible = true;
            dgvListado.Columns["precio_venta"].Visible = true;
            dgvListado.Columns["stock"].Visible = true;


            // cambiar nombre de columna por
            dgvListado.Columns["nombre"].HeaderText = "Nombre";
            dgvListado.Columns["descripcion"].HeaderText = "Descripción";
            dgvListado.Columns["costo"].HeaderText = "Costo";
            dgvListado.Columns["precio_venta"].HeaderText = "Precio Vta.";
            dgvListado.Columns["stock"].HeaderText = "Stock";
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                var productosSeleccionados = new List<Product>(dgvListado.SelectedRows.Count);

                for (int index = 0; index < dgvListado.SelectedRows.Count; index++)
                {
                    var selectedRow = dgvListado.SelectedRows[index];
                    var producto = (Product)selectedRow.DataBoundItem;
                    productosSeleccionados.Add(producto);
                }

                var castproductosSeleccionados = CastProducToDetailProduct(productosSeleccionados);


                // if (this.compras.Productos == null)
                if (this.compras.ListaDetalleProductos == null)
                {
                    this.compras.ListaDetalleProductos = castproductosSeleccionados;
                    // this.compras.Productos = productosSeleccionados;
                }
                // else if (this.compras.Productos != null && this.compras.Productos.Count > 0)
                else if (this.compras.ListaDetalleProductos != null && this.compras.ListaDetalleProductos.Count > 0)
                {
                    this.compras.ListaDetalleProductos.AddRange(castproductosSeleccionados);
                    // this.compras.Productos.AddRange(productosSeleccionados);

                }
                this.compras.EstablecerListaProductosEnDataGridView();
                this.Close();

            }
            catch (Exception ex)
            {
                Utils.GrabarLog("Search", ex.ToString());
                MessageBox.Show("Error no controlado en el proceso.", "Proveedores", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private List<ProductDetailBuyDto> CastProducToDetailProduct(List<Product> fromProducts)
        {
            var response = new List<ProductDetailBuyDto>();
            foreach (var product in fromProducts)
            {
                response.Add(new ProductDetailBuyDto { Codigo = product.id_producto, Nombre = product.nombre });
            }
            return response;
        }
    }
}
