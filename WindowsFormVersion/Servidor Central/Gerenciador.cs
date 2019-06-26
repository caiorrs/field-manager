using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormVersion.Servidor_Central
{




    //essa classe que tem acesso aos outros sistemas
    class Gerenciador
    {
        //acredit oque seria setCronograma de iIncidencia
        // ponto de acesso para o 
        Sistema_de_Cobertura.iIncidencia sistemaIncidencia;
        Sistema_de_Corte.iCorte sistemaCorte;

        public Gerenciador(Sistema_de_Cobertura.iIncidencia sistemaIncidencia, Sistema_de_Corte.iCorte sistemaCorte)
        {
            this.sistemaIncidencia = sistemaIncidencia;
            this.sistemaCorte = sistemaCorte;
        }

        private void startUI()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            TESTEUI ui = new TESTEUI();
            ui.ShowDialog();
        }

        public void setup()
        {

            Thread UIthrd = new Thread(new ThreadStart(this.startUI));
            UIthrd.Start();            

            int horaAgora = Natureza.Tempo.Instance.HoraDoDia();
            sistemaIncidencia.setCronograma(this.createCronogramaHorasSol(horaAgora));

            Thread thr = new Thread(new ThreadStart(this.configurarSubSistemas));
            thr.Start();
            Console.WriteLine("instanciou servidor central");

            //TO-DO nao vai ser assim mas tenho q ver como vou receber os agendamentos
            // no caso tenho q receber da ui...
            float alturaGrama = 11; //mm
            Business.Agendamento a = new Business.Agendamento(7, alturaGrama);
            sistemaCorte.agendarCorte(a);
        }

        private void configurarSubSistemas()
        {

            /*
  * 
  * tem q ter uma thread 
  * que fica olhando o horario
  * 
  * e todo dia as 23h ela cria os cronogramas 
  * e passa para os subsistemas
  * */
            while (!Program.Terminated)
            {
                int horaAgora = -1;
                while ((!Program.Terminated) && (horaAgora != 23))
                {
                    horaAgora = Natureza.Tempo.Instance.HoraDoDia();
                    Natureza.Tempo.Instance.inserePequenoDelay();
                }
                //ja sao 23 agora
                this.configurarSistemaCobertura();

                Natureza.Tempo.Instance.passaDuasHoras();
            }
        }

        private void configurarSistemaIrrigacao()
        {

        }

        private void configurarSistemaCobertura()
        {
            this.sistemaIncidencia.setCronograma(this.createCronogramaHorasSol(0));
        }

        private Queue<Business.Agendamento> createCronogramaHorasSol(int horaInicial)
        {
            if (horaInicial > 24 || horaInicial < 0)
                throw new Exception("hora invalida");

            DateTime today = Natureza.Tempo.Instance.Now;
            Sistema_de_Previsão_do_Tempo.Previsao prev = new Sistema_de_Previsão_do_Tempo.Previsao(today);
            Queue<Business.Agendamento> q = new Queue<Business.Agendamento>();
            if (prev.iraChover())
            {
                for (int i = horaInicial; i < 24; i++)
                {
                    //fake total
                    float p = 30; //como vai chover matenho a abertura em 30% para nao molhar demais a grama
                    Business.Agendamento a = new Business.Agendamento(i, p);
                    q.Enqueue(a);
                }
            }
            else
            {
                for (int i = horaInicial; i < 24; i++)
                {
                    //fake total
                    float p;
                    //50% eh o padrao, mas entre as 14 e as 18, abro em 100 pra pegar sol%
                    if (i >= 14 && i <= 18)
                        p = 100;
                    else
                        p = 50;
                    Business.Agendamento a = new Business.Agendamento(i, p);
                    q.Enqueue(a);
                }
            }
            return q;
        }
    }
}
