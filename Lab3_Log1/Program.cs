using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3_Log1
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
            Application.Run(new Form1());

            Console.Write("Ingrese su nombre");
            String nombre = Console.ReadLine();
            Console.Write("Ingrese su direccion de correo electronico");
            String correo = Console.ReadLine();
            Console.Write("Ingrese lo que desea de endulzada");
            String endulzadaIdeal = Console.ReadLine();
            Console.Write("Ingrese lo que desea de regalo");
            String regaloIdeal = Console.ReadLine();

        }
    }
}
