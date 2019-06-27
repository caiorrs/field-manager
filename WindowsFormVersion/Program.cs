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

        static void testStuff()
        {
            /*
             * 
             * nao deu certo...
             * 
            //cria servidor web
            Runner r = new Runner();
            r.run();
            */
            DateTime thisDay = DateTime.Today;
            DateTime n = new DateTime();
            string s = n.Date.ToString();

            float acceleration = 500;
            thisDay = thisDay.AddDays(1);

            s = thisDay.ToString();

            Console.WriteLine(s);


            // negocio fake pra criar as queue

            Queue<Business.Agendamento> q = new Queue<Business.Agendamento>();

            for (int i = 0; i < 24; i++)
            {
                //fake total


                float p;
                //50% eh o padrao, mas entre as 14 e as 18, abro em 50%

                if (i >= 14 && i <= 18)
                    p = 100;
                else
                    p = 50;

                Business.Agendamento a = new Business.Agendamento(i, p);
                q.Enqueue(a);
            }

            foreach (Business.Agendamento a in q)
            {
                Console.WriteLine(a);
            }

            return;

            Thread thr = new Thread(new ThreadStart(Natureza.Tempo.Instance.passTime));
            thr.Start();


            DateTime simulatedNow; // = Natureza.Tempo.Instance.Now;
            simulatedNow = thisDay;
            while (!Program.Terminated)
            {
                //  simulatedNow = simulatedNow.AddHours(1);
                simulatedNow = Natureza.Tempo.Instance.Now;
                s = simulatedNow.ToString();
                Console.WriteLine(s);

                int hora = Natureza.Tempo.Instance.HoraDoDia();
                s = "hora o dia: " + hora.ToString();
                Console.WriteLine(s);

                //checa a cada 1s o tempo
                Thread.Sleep(500);
            }


            return;
        }

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
