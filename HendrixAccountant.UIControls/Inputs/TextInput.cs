using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HendrixAccountant.UIControls
{
    [ToolboxBitmap(typeof(TextBox))]
    public partial class TextInput : TextBox
    {
        public TextInput()
        {
            InitializeComponent();
        }

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            if (Char.IsLetter(e.KeyChar) || Char.IsControl(e.KeyChar) 
               || ((Keys)e.KeyChar == Keys.Space))
                e.Handled = false;
            else
                e.Handled = true;
        }
    }
}
