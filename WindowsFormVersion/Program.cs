using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

using WindowsFormVersion;

namespace WindowsFormVersion
{
    static class Program
    {

        public static bool Terminated = false;
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]

        static void Main()
        {
            //testStuff();
            //return;
            // aqui estariamos instanciando cada subsistema

            Sistema_de_Cobertura.Controle.Controlador cobertura = new Sistema_de_Cobertura.Controle.Controlador();

            Sistema_de_Corte.Controle.Controlador corte = new Sistema_de_Corte.Controle.Controlador();

            Sistema_de_Irrigacao.Controle.Controlador irrigacao = new Sistema_de_Irrigacao.Controle.Controlador(cobertura);


            Servidor_Central.Gerenciador gerenciador = new Servidor_Central.Gerenciador(irrigacao, cobertura, corte );
           
            gerenciador.setup();
            corte.setup();
            irrigacao.setup();
            cobertura.setup();

            Thread thr = new Thread(new ThreadStart(Natureza.Tempo.Instance.passTime));
            thr.Start();
            //mando o tempo rodar

            // isso seria o simulador v
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Simulador());
            Program.Terminated = true;
        }
    }
}
