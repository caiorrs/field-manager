using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Threading;

using WindowsFormVersion.Sistema_de_Corte.Monitoramento;

namespace WindowsFormVersion.Sistema_de_Corte.Controle
{
    class Controlador
    {
        Cortador cortador;
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

        }
    }
}
