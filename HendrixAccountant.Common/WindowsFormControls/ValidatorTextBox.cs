using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HendrixAccountant.Common.WindowsFormControls
{
    public class ValidatorTextBox
    {
        private TextBox _caja;

        public ValidatorTextBox(TextBox caja)
        {
            this._caja = caja;
        }

        public void ValidadorFormatoMoneda(object sender, EventArgs e)
        {
            string value = _caja.Text.Replace(",", "").Replace("$", "").Replace(".", "").TrimStart('0');
            decimal ul;
            //Check we are indeed handling a number
            if (decimal.TryParse(value, out ul))
            {
                ul /= 100;
                //Unsub the event so we don't enter a loop
                _caja.TextChanged -= ValidadorFormatoMoneda;
                //Format the text as currency
                _caja.Text = string.Format(CultureInfo.CreateSpecificCulture("en-US"), "{0:C2}", ul);
                _caja.TextChanged += ValidadorFormatoMoneda;
                _caja.Select(_caja.Text.Length, 0);
            }
            bool goodToGo = TextisValid(_caja.Text);

            if (!goodToGo)
            {
                _caja.Text = "$0.00";
                _caja.Select(_caja.Text.Length, 0);
            }
        }
        private bool TextisValid(string text)
        {
            Regex money = new Regex(@"^\$(\d{1,3}(\,\d{3})*|(\d+))(\.\d{2})?$");
            return money.IsMatch(text);
        }
    }
}
