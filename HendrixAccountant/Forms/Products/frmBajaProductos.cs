using HendrixAccountant.ApplicationCore.DTOs;
using HendrixAccountant.ApplicationCore.Interfaces.Forms;
using HendrixAccountant.ApplicationCore.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HendrixAccountant.Forms.Products
{
    public partial class frmBajaProductos : Form, IFindElement
    {
        private ProductIdentityDto _product;

        public frmBajaProductos()
        {
            InitializeComponent();
            _product = null;
        }

        public void Selected(ISaleElement entity)
        {
            if (entity == null) return;

            switch (entity.GetType().Name)
            {
                case "ProductIdentityDto":
                    _product = entity as ProductIdentityDto;
                    break;
                default:
                    break;
            }
        }

        private void btnDarBaja_Click(object sender, EventArgs e)
        {

        }

        private void btnDarBaja_Click_1(object sender, EventArgs e)
        {
            var product = new ProductWithdrawal
            {
                IdProducto = _product.IdProducto,
                Cantidad = int.Parse(txtCantidad.Text.Trim()),
                IdMotivo = cboMotivo.SelectedIndex +1,
                OtroMotivo = txtOtroMotivo.Text
            };

        }

        private void frmBajaProductos_Load(object sender, EventArgs e)
        {

        }
    }
}
