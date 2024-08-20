using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menúes_y_Navegación_entre_Ventanas
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Aqui se inicializa la pantalla principal. la primera que aperece en pantalla
            Application.Run(new FrmPrincipal());
        }
    }
}
