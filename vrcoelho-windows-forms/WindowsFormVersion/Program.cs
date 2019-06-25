using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using WindowsFormVersion;

namespace WindowsFormVersion
{
    static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {

        // aqui estariamos instanciando cada subsistema

            Sistema_de_Corte.Controle.Controlador corte = new Sistema_de_Corte.Controle.Controlador();
            corte.setup();
            Console.WriteLine("instanciou corte");

            Sistema_de_Irrigacao.Controle.Controlador irrigacao = new Sistema_de_Irrigacao.Controle.Controlador();
            irrigacao.setup();
            Console.WriteLine("instanciou irrigacao");


            // isso seria o simulador v
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Simulador());
        }


    }
}
