﻿using HendrixAccountant.ApplicationCore.Constants;
using HendrixAccountant.ApplicationCore.DTOs;
using HendrixAccountant.ApplicationCore.Entities;
using HendrixAccountant.ApplicationCore.Interfaces.Forms;
using HendrixAccountant.ApplicationCore.Interfaces.Repositories;
using HendrixAccountant.Common;
using HendrixAccountant.Data.Dtos;
using HendrixAccountant.Data.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HendrixAccountant
{
    public partial class frmBuscarProductos : Form
    {
        private readonly IProductTempRepository _rpsProduct;
        private IFindElement _callerPOS;
        public frmBuscarProductos()
        {
            InitializeComponent();
            _rpsProduct = new ProductTempRepository();
        }

        public frmBuscarProductos(IFindElement caller)
        {
            InitializeComponent();
            _callerPOS = caller;
            _rpsProduct = new ProductTempRepository();
        }

        private void frmBuscarProductos_Load(object sender, EventArgs e)
        {
            
        }

        #region Private methods

        private void Search()
        {
            try
            {
                var products = _rpsProduct.GetAll();
                if (products == null)
                {
                    MessageBox.Show("No se obtuvieron datos.", CString.DEFAULT_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                FillGrid(products);
            }
            catch (Exception ex)
            {
                Utils.GrabarLog("Search", ex.ToString());
                MessageBox.Show("No se pudo obtener los productos.", CString.DEFAULT_TITLE, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FillGrid(IEnumerable<Object> data)
        {
            dgvProductos.DataSource = null;
            dgvProductos.Rows.Clear();
            dgvProductos.AutoGenerateColumns = false;
            foreach (var item in data.Cast<Product>().ToList())
                dgvProductos.Rows.Add(item.nombre, item.stock, item.precio_venta, item.marca, item.categoria_id, item.id_producto);
        }

        private ProductIdentityDto MapRowToProduct(DataGridViewRow row)
        {
            ProductIdentityDto product = null;
            try
            {
                product = new ProductIdentityDto
                {
                    IdProducto = Convert.ToInt32(row.Cells[colCodigo.Index].Value.ToString()),
                    Nombre = row.Cells[colNombreProd.Index].Value.ToString(),
                    Precio = Convert.ToDecimal(row.Cells[colPrecio.Index].Value.ToString().Replace(",", "."), Utils.GetCulture())
                };
            }
            catch (Exception ex)
            {
                Utils.GrabarLog("MapRowToProduct", ex.ToString());
            }
            return product;
        }
        #endregion

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void dgvProductos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            ProductIdentityDto product = MapRowToProduct(dgvProductos.Rows[e.RowIndex]);
            _callerPOS.Selected(product);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void frmBuscarProductos_Activated(object sender, EventArgs e)
        {
            txtNombreProd.Focus();
        }
    }
}