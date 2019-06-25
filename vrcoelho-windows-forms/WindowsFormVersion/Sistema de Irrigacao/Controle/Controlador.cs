using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Threading;

using WindowsFormVersion.Sistema_de_Irrigacao.Monitoramento;

using WindowsFormVersion.Sistema_de_Cobertura;

namespace WindowsFormVersion.Sistema_de_Irrigacao.Controle
{
    class Controlador
    {
        Irrigador irrigador;

        iIrrigacaoToCobertura iIrriToCob;

        public Controlador(iIrrigacaoToCobertura iIrriToCob)
        {
            //precisa receber a referencia no startup
            this.iIrriToCob = iIrriToCob;
        }
        public void setup()
        {
            //crio classe q fica monitorando a natureza
            //digamos que tu receba isso do usuario

            float minUmidade, maxUmidade;
            minUmidade = 200;
            maxUmidade = 450;

            float idealUmidade = (minUmidade + maxUmidade) / 2;

            irrigador = new Irrigador();
            irrigador.UmidadeIdeal = idealUmidade;

            Action callbackLOW = irrigador.Irrigar;
            Action callbackHIGH = iIrriToCob.umidadeAcimaLimite;

            Monitorador m = new Monitorador(callbackLOW, callbackHIGH, minUmidade, maxUmidade);

            Thread thr = new Thread(new ThreadStart(m.loop));
            thr.Start();
        }
    }
}
