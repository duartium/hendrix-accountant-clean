using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HendrixAccountant.ApplicationCore.DTOs;
using HendrixAccountant.ApplicationCore.Interfaces.Repositories;
using HendrixAccountant.ApplicationCore.Interfaces.Services;
using HendrixAccountant.ApplicationCore.Services;
using HendrixAccountant.Common.Cast;
using HendrixAccountant.Data;
using HendrixAccountant.Data.Repositories;

namespace HendrixAccountant
{
    public partial class frmProductos : Form
    {
        private IUnitOfWork _unitOfWork;
        private IProductService _productService;
        private readonly ProductoRepository _rpsProducto;
        public frmProductos()
        {
            InitializeComponent();
            this._unitOfWork = new UnitOfWork(new AppDbContext());

        }

        private void frmProductos_Load(object sender, EventArgs e)
        {

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {

                this._productService = new ProductService(this._unitOfWork);
                var data = this._productService.GetProducts();


                var dsResult = ConvertToDataSet.FromList<ProductDTO>(data, "productos");

                if (dsResult == null)
                {
                    MessageBox.Show("No se obtuvieron datos.", "Notificación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                dgvProductos.AutoGenerateColumns = true;
                dgvProductos.DataSource = dsResult.Tables[0];
                dgvProductos.Refresh();
                //dgvProductos.DataMember = "PRODUCTOS";
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
