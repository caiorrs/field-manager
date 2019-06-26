using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Threading;

using WindowsFormVersion.Sistema_de_Corte.Monitoramento;
using WindowsFormVersion.Business;

namespace WindowsFormVersion.Sistema_de_Corte.Controle
{
    class Controlador: iCorte
    {
        Cortador cortador;

        public void agendarCorte(Agendamento corteAgendado)
        {
            cortador.alturaLamina = corteAgendado.porcentagemAberturaCobertura; //nesse caso eh a altura

            Action callback = cortador.Cortar;
            TimeMonitor t = new TimeMonitor(callback, corteAgendado.horaDoDia);
            Thread thr = new Thread(new ThreadStart(t.loop));
            thr.Start();
            Console.WriteLine("iniciou thread para realizar o corte no horario agendado");
        }

        public  void setup()
        {

            //crio classe q fica monitorando a natureza
            float alturaPreDefinida = 10; //digamos que tu receba isso do usuario
            cortador = new Cortador();
            cortador.alturaLamina = alturaPreDefinida;

            Action callback = cortador.Cortar;

            float alturaMaxima = 40;
            Monitorador m = new Monitorador(callback, alturaMaxima);

            Thread thr = new Thread(new ThreadStart(m.loop));
            thr.Start();
            Console.WriteLine("instanciou corte");            
        }
    }
}
