using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WindowsFormVersion.Sistema_de_Cobertura.Controle
{
    class Controlador : iIrrigacaoToCobertura, iIncidencia//, iSistema
    {
        Cobertura cobertura;

        int TESTE_REF = 0; //minha ideia era passar isso pra um boleano e mudar aqui e a thread la dentro ver

        private Queue<Business.Agendamento> cronogramaHoje;
        public void setCronograma(Queue<Business.Agendamento> q)
        {
            //Natureza.Tempo.Instance.inserePequenoDelay();
            this.cronogramaHoje = q;
            Console.WriteLine("Sistema de cobertura recebeu novo agendamento");

            Monitorameto.TimeMonitor m = new Monitorameto.TimeMonitor(cobertura.setOpening, this.cronogramaHoje, ref TESTE_REF);
            Thread thr = new Thread(new ThreadStart(m.loop));
            thr.Start();

        }
        public void setup()
        {
            //crio classe q fica monitorando a natureza
            // float alturaPreDefinida = 10; //digamos que tu receba isso do usuario
            cobertura = new Cobertura();




            Console.WriteLine("instanciou cobertura");
        }

        // vou ter o agendamento... sou eu que fi
        public void umidadeAcimaLimite()
        {
            /*
             * TO-DO 
             * 
             * preciso matar a thread que esta fazendo o cronograma             * 
             * isso tem q ser atraves de alguma flag global etc.      
             * * 
             * a acao depende se esta chovendo ou nao                   * * 
             * se estiver chovendo, fecha             * 
             * se nao estiver chovendo, abre
             * 
             */

            if (cobertura.estaChovendo())
                cobertura.close();
            else
                cobertura.open();

        }
    }
}
