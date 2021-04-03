using HendrixAccountant.ApplicationCore.DTOs;
using HendrixAccountant.ApplicationCore.Entities;
using HendrixAccountant.ApplicationCore.Interfaces.Repositories;
using HendrixAccountant.ApplicationCore.Interfaces.Services;
using HendrixAccountant.Data;
using HendrixAccountant.Data.Repositories;
using System.Collections.Generic;
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
