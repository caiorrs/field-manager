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
    class Controlador : iIrrigacao
    {
        Irrigador irrigador;

        iIrrigacaoToCobertura iIrriToCob;

        private float minUmidade = -1;
        private float maxUmidade = -1;

        iSensorUmidade sensor;

        public Controlador(iIrrigacaoToCobertura iIrriToCob)
        {
            this.iIrriToCob = iIrriToCob;
            this.sensor = new SensorUmidade();
        }

        public float getValorUmidade()
        {
            return this.sensor.getLeitura();
        }

        public bool setUmidadeThreshold(float umidadeMin, float umidadeMax)
        {
            this.maxUmidade = umidadeMax;
            this.minUmidade = umidadeMin;
            return true; //sucesso
        }

        public void setup()
        {
            //crio classe q fica monitorando a natureza
            //digamos que tu receba isso do usuario

            if (minUmidade < 0 || maxUmidade < 0)
            {
                throw new Exception("Sistema de irrigaçao nao configurado");
            }

            float idealUmidade = (minUmidade + maxUmidade) / 2;

            irrigador = new Irrigador();
            irrigador.UmidadeIdeal = idealUmidade;
            irrigador.UmidadeMinima = idealUmidade / 2;

            Action callbackLOW = irrigador.Irrigar;
            Action callbackHIGH = iIrriToCob.umidadeAcimaLimite;

            Monitorador m = new Monitorador(this.sensor,callbackLOW, callbackHIGH, irrigador.UmidadeMinima, maxUmidade);

            Thread thr = new Thread(new ThreadStart(m.loop));
            thr.Start();
            Console.WriteLine("instanciou irrigacao");
        }
    }
}
