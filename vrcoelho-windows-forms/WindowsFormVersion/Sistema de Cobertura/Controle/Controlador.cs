using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WindowsFormVersion.Sistema_de_Cobertura.Controle
{
    class Controlador : iIrrigacaoToCobertura
    {
        Cobertura cobertura;
        public void setup()
        {
            //crio classe q fica monitorando a natureza
           // float alturaPreDefinida = 10; //digamos que tu receba isso do usuario
            cobertura = new Cobertura();

            //tenho q receber isso do controlador central mas por enquanto deixa assim
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

            Monitorameto.TimeMonitor m = new Monitorameto.TimeMonitor(cobertura.setOpening,q);

            Thread thr = new Thread(new ThreadStart(m.loop));
            thr.Start();

        }

        // vou ter o agendamento... sou eu que fi



        public void umidadeAcimaLimite()
        {
            cobertura.close();
        }
    }
}
