using HendrixAccountant.ApplicationCore.Interfaces.Forms;
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
    public partial class frmBuscarCategorias : Form
    {
        private IFindElement _caller;
        public frmBuscarCategorias()
        {
            InitializeComponent();
            _caller = new CategoriesRepository();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {

        }

        private void frmBuscarCategorias_Load(object sender, EventArgs e)
        {

        }
    }
}
