using HendrixAccountant.Sessions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HendrixAccountant
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            if (!Boolean.Parse(Common.Utils.GetValueSetting("skipLogin")))
            {
                var frmLogin = new frmLogin();
                frmLogin.BringToFront();
                frmLogin.ShowDialog();

                if (frmLogin.DialogResult == DialogResult.OK)
                    Application.Run(new frmMain());
            }
            else Application.Run(new frmMain());//solo para efecto de pruebas
        }
    }
}
