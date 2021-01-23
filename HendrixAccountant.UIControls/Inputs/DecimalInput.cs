using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace HendrixAccountant.UIControls.Inputs
{
    [ToolboxBitmap(typeof(TextBox))]
    public partial class DecimalInput : TextBox
    {
        public DecimalInput()
        {
            InitializeComponent();
        }

        private short decimales = 2; //por default permitira 2 decimales
                                     //Implementar la propiedad que permita al usuario establecer el numero de decimales a mostrar
                                     //Agregamos una descripcion a la propiedad que pueda leer el usuario
        [Description("Define el número de decimales que desea obtener.")]
        public short NumberDecimals
        {
            get { return this.decimales; }
            set { this.decimales = value; }
        }

        private bool punto = false; //auxiliar para limitar el numero de puntos en el textbox
                                    //sobrescribir el metodo OnKeyPress
        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            //verificar si el textbox contiene el caracter punto y actualizar nuestra variable a true si ya se tiene un punto
            punto = this.Text.Contains(".") ? true : false;

            //permitir solo los caractedes de digitos y punto
            // e.KeyChar == (char)Keys.Home
            if (char.IsDigit(e.KeyChar) || e.KeyChar == '.')
            {
                //validar si el usuario esta ingresando el caracter (punto)
                if (e.KeyChar == '.')
                {
                    //limitar el numero de puntos en el textbox
                    if (punto == false)
                    {
                        //si no existe ningun punto en el textbox, permitir el caracter
                        e.Handled = false;
                        punto = true;
                    }
                    else
                        e.Handled = true; // si ya existe un punto, bloquear el caracter

                    return;
                }

                //si el caracter es un digito
                //comprobar que el cuadro de texto cumpla con la expresion regular:
                //0 a n digitos(punto)n numero de decimales
                //si cumple con la expresion, permitir el digito ingresado
                if (Regex.IsMatch(this.Text, "^\\d*\\.\\d{" + decimales + "}$")) e.Handled = true;
            }
            else
            {
                //si es tecla de control especial, permitirla
                if (Char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else
                    e.Handled = true;
            }
            //e.Handled = e.KeyChar != (char)Keys.Back;
        }

        private decimal valor; //campo para almacenar el valor

        [Description("Obtiene o establece el valor decimal para el DecimalTextBox.")]
        public decimal Value
        {
            get
            {
                if (this.Text != "")
                    valor = Convert.ToDecimal(this.Text);

                return valor;
            }
            set
            {
                valor = value;

                if (valor != 0)
                    this.Text = valor.ToString();
            }
        }
    }
}
