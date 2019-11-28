using EJERCICIOS;
using LoginProyecto;
using Proyecto;
using PROYECTO.Menu;
using PROYECTO.Nivel5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using PROYECTO.Nivel1;

namespace PROYECTO
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
            Application.Run(new FrmLoginReg());
        }
    }
}
