using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HendrixAccountant.UIControls.Buttons
{
    public partial class ItemAsideSmall : Button
    {
        public ItemAsideSmall()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(253, 184, 39);
            this.ClientSize = new Size(127, 40);
            this.Font = new Font("Arial", 9);
            this.ForeColor = Color.FromArgb(27, 46, 140);
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
            this.FlatAppearance.MouseOverBackColor = Color.FromArgb(253, 184, 45);
            this.FlatAppearance.MouseDownBackColor = Color.FromArgb(253, 184, 39);
            this.Cursor = Cursors.Hand;
        }
    }
}
