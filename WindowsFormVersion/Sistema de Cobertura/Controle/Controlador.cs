using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WindowsFormVersion.Sistema_de_Cobertura.Controle
{
    class Controlador : iIrrigacaoToCobertura, iIncidencia, iSistema
    {
        Cobertura cobertura;

        private Queue<Business.Agendamento> cronogramaHoje;
         public void setCronograma(Queue<Business.Agendamento> q)
        {
            this.cronogramaHoje = q;
            Console.WriteLine("Sistema de cobertura recebeu novo agendamento");
        }
        public void setup()
        {
            //crio classe q fica monitorando a natureza
           // float alturaPreDefinida = 10; //digamos que tu receba isso do usuario
            cobertura = new Cobertura();

            if (this.cronogramaHoje == null)
                throw new Exception("cronograma de hoje era nulo");

            Monitorameto.TimeMonitor m = new Monitorameto.TimeMonitor(cobertura.setOpening,this.cronogramaHoje);

            Thread thr = new Thread(new ThreadStart(m.loop));
            thr.Start();
            Console.WriteLine("instanciou cobertura");
        }

        // vou ter o agendamento... sou eu que fi
        public void umidadeAcimaLimite()
        {
            cobertura.close();
        }
    }
}
