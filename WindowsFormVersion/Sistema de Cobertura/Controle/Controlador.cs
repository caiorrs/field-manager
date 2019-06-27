using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WindowsFormVersion.Sistema_de_Cobertura.Controle
{
    class Controlador : iIrrigacaoToCobertura, iIncidencia
    {
        Cobertura cobertura;

        int TESTE_REF = 0; //minha ideia era passar isso pra um boleano e mudar aqui e a thread la dentro ver

        private Queue<Business.Agendamento> cronogramaHoje;

        public Controlador()
        {
            cobertura = new Cobertura();
        }
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

            Console.WriteLine("instanciou cobertura");
        }

        public void umidadeAcimaLimite()
        {
            if (cobertura.estaChovendo())
                cobertura.close();
            else
                cobertura.open();
        }
    }
}
