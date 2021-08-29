using HendrixAccountant.ApplicationCore.Constants;
using HendrixAccountant.ApplicationCore.DTOs;
using HendrixAccountant.ApplicationCore.Interfaces.Forms;
using HendrixAccountant.ApplicationCore.Interfaces.Repositories;
using HendrixAccountant.Common;
using HendrixAccountant.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace HendrixAccountant.Forms.Inventory
{
    public partial class frmCompras : Form, IFindElement, IQuantityPrice
    {
        private SupplierDto _supplier;
        private List<ProductIdentityDto> _lsProducts;
        private readonly ISupplierRepository _rpsSupplier;
        private ProductIdentityDto _product;
        private IProductTempRepository _rpsProduct;
        private PurchaseMerchandiseDto _purchase;
        private IPurchase _rpsPurchase;

        public frmCompras()
        {
            InitializeComponent();
            _supplier = null;
            _rpsSupplier = new SupplierRepository();
           _rpsProduct = new ProductTempRepository();
            _product = null;
            _lsProducts = new List<ProductIdentityDto>();
            LoadSupplierDefault();
            SetCompanyColors();
            _purchase = null;
            _rpsPurchase = new PurchaseRepository();
        }

        #region metodos privados

        #endregion

        private void frmCompras_Load(object sender, EventArgs e)
        {
            txtNumComprobante.Focus();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void Clear()
        {
            dgvProductos.Rows.Clear();
            _lsProducts = null;
            txtNumComprobante.Clear();
            txtObservaciones.Clear();
            txtTotalCompra.Clear();
        }

        private void btnGuardar_Click_2(object sender, EventArgs e)
        {
            if (_supplier == null)
            {
                MessageBox.Show("Seleccione un proveedor para continuar.", CString.DEFAULT_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            if (_lsProducts.Count <= 0)
            {
                MessageBox.Show("Agrege al menos 1 producto para continuar.", CString.DEFAULT_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("¿Está seguro que desea registrar la compra?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            try
            {
                var dataOp = DataOperator.Instance;
                _purchase = new PurchaseMerchandiseDto
                {
                    FechaEmision = dtpFechaEmision.Value,
                    NumComprobante = txtNumComprobante.Text.Trim(),
                    IdProveedor = Convert.ToInt32(txtCodProveedor.Text.Trim()),
                    Observaciones = txtObservaciones.Text,
                    Usuario = dataOp.Username,
                    Total = Convert.ToDecimal(txtTotalCompra.Text, Utils.GetCulture()),
                    ProductosList = _lsProducts,
                };
                
                int secuencial = _rpsPurchase.Save(_purchase);
                if (secuencial > 0)
                {
                    Clear();
                    MessageBox.Show("Compra registrada correctamente.", "Proceso exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else MessageBox.Show("No se pudo procesar la venta.", "Proceso fallido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                Utils.GrabarLog("btnGuardar_Click", ex.ToString());
            }


        }

        private void LoadSupplierDefault()
        {
            //consulta proveedor por defecto
            if (_supplier != null) return;
            _supplier = _rpsSupplier.GetDefault();
            SetSupplier();
        }

        private void SetSupplier()
        {
            if (_supplier == null) return;
            txtCodProveedor.Text = _supplier.IdProveedor.ToString();
            txtNombreProveedor.Text = _supplier.Nombre.ToString();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmBuscarProductos frmBuscarProductos = new frmBuscarProductos(this);
            frmBuscarProductos.ShowDialog();
        }

        public void GetQuantity(int quantity, decimal price)
        {
            if (_product == null) return;

            _product.Cantidad = quantity;
            _product.Precio = price;
            decimal total = _product.Precio * quantity;
            _product.Total = Math.Round(total, 2);
            if (_lsProducts == null)
                _lsProducts = new List<ProductIdentityDto>();
            _lsProducts.Add(_product);
            FillGrid();
            CalcularTotal();
        }

        public void Selected(ISaleElement entity)
        {
            if (entity == null) return;

            switch (entity.GetType().Name)
            {
                case "ProductIdentityDto":
                    _product = entity as ProductIdentityDto;
                    frmCantidadPrecio frmCantidad = new frmCantidadPrecio(this);
                    frmCantidad.ShowDialog();
                    break;
            }
        }

        private void FillGrid()
        {
            if (_product == null) return;
            dgvProductos.Rows.Add(_product.IdProducto, _product.Nombre, _product.Cantidad, _product.Precio, _product.Total);
            dgvProductos.FirstDisplayedScrollingRowIndex = dgvProductos.RowCount - 1;
            //EnableRemove();
        }

        private void CalcularTotal()
        {
            if (_lsProducts == null) return;
            if (_lsProducts.Count <= 0) return;
            decimal total = _lsProducts.Select(x => x.Total).Sum();
            txtTotalCompra.Text = total.ToString().Replace(",", ".");
        }

        private void SetCompanyColors()
        {
            pnAside.BackColor = DataOperator.Instance.ColorPrimary;
            dgvProductos.ColumnHeadersDefaultCellStyle.BackColor = DataOperator.Instance.ColorPrimary;
            btnGuardar.BackColor = DataOperator.Instance.ColorSecondary;
            btnLimpiar.BackColor = DataOperator.Instance.ColorSecondary;
        }

        private void frmCompras_Activated(object sender, EventArgs e)
        {
            txtNumComprobante.Focus();
        }
    }
}
