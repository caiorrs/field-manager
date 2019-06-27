using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormVersion.Business;

namespace WindowsFormVersion.Servidor_Central
{

    class UIExposed : iUIExposed
    {
        public UIExposed()
        {

        }
        public void agendarCorte(DateTime data, float altura)
        {
            throw new NotImplementedException();
        }

        public bool configurarSistema(string cidade, int tipoGrama)
        {
            throw new NotImplementedException();
        }

        public void cortarAgora()
        {
            throw new NotImplementedException();
        }

        public string getRelatorioCorte(Periodo periodo)
        {
            throw new NotImplementedException();
        }

        public string getRelatorioUmidade(Periodo periodo)
        {
            throw new NotImplementedException();
        }

        public string getTiposDeGrama()
        {
            throw new NotImplementedException();
        }

        public bool setAltura(float altura)
        {
            throw new NotImplementedException();
        }
    }


    //essa classe que tem acesso aos outros sistemas
    class Gerenciador
    {
        Sistema_de_Irrigacao.iIrrigacao irrigacao;
        Sistema_de_Cobertura.iIncidencia sistemaIncidencia;
        Sistema_de_Corte.iCorte sistemaCorte;

        List<AgendamentoCorte> agendamentosCorte;

        public Gerenciador(Sistema_de_Irrigacao.iIrrigacao irrigacao, Sistema_de_Cobertura.iIncidencia sistemaIncidencia, Sistema_de_Corte.iCorte sistemaCorte)
        {
            this.irrigacao = irrigacao;
            this.sistemaIncidencia = sistemaIncidencia;
            this.sistemaCorte = sistemaCorte;

            this.agendamentosCorte = new List<AgendamentoCorte>();
        }

        private void startUI()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            UIExposed metodosUI = new UIExposed();

            TESTEUI ui = new TESTEUI(metodosUI);
            ui.ShowDialog();
        }

        public void setup()
        {

            Thread UIthrd = new Thread(new ThreadStart(this.startUI));
            UIthrd.Start();

            //inicializa com o primeiro cronograma
            int horaAgora = Natureza.Tempo.Instance.HoraDoDia();
            sistemaIncidencia.setCronograma(this.createCronogramaHorasSol(horaAgora));

            Thread thr = new Thread(new ThreadStart(this.configurarSubSistemas));
            thr.Start();
            Console.WriteLine("instanciou servidor central");

            irrigacao.setUmidadeThreshold(0, 100);
        }

        private void agendarCorte(AgendamentoCorte a)
        {
            this.agendamentosCorte.Add(a);
        }

        private void configurarSubSistemas()
        {
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
                this.configurarSistemaCortes();

                Natureza.Tempo.Instance.passaDuasHoras();
            }
        }

        private void configurarSistemaCortes()
        {
            /*
             * 
             * se ha um corte agendado para amanha, o sistema agenda o corte
             * 
             */

            return;
            DateTime tomorrow = Natureza.Tempo.Instance.Now.AddDays(1);
            this.agendamentosCorte.Sort();
            foreach (AgendamentoCorte agendamentoCorte in this.agendamentosCorte)
            {
                //TO-DO verificar se                 agendamentoCorte.getDate() é para amanha
                // se for, entao criamos um novo agendamento
                Business.Agendamento a = new Business.Agendamento(agendamentoCorte.getDate().Hour, agendamentoCorte.getAltura());
                sistemaCorte.agendarCorte(a);

                //remove esse agendamento da lista

                //quando nao for mais amanha, ai break.
            }
        }
        private void configurarSistemaIrrigacao()
        {
            //TO-DO nao consegui pensar em que tipos de configuracao esse sistema precisa
            return;
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
