using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HendrixAccountant.Data;

namespace HendrixAccountant
{
    public partial class frmProductos : Form
    {
        private readonly ProductoRepository _rpsProducto;
        public frmProductos()
        {
            InitializeComponent();
            _rpsProducto = new ProductoRepository();
        }

        private void frmProductos_Load(object sender, EventArgs e)
        {
            
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                var dsResult = this._rpsProducto.GetAll();

                if (dsResult == null)
                {
                    MessageBox.Show("No se obtuvieron datos.", "Notificación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                dgvProductos.AutoGenerateColumns = true;
                dgvProductos.DataSource = dsResult;
                //dgvProductos.DataMember = "PRODUCTOS";
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
