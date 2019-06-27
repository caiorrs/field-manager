using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Threading;

namespace WindowsFormVersion.Sistema_de_Irrigacao.Monitoramento
{
    class Monitorador
    {
        Action callbackLOW;
        Action callbackHIGH;
        float umidadeMinima;
        float umidadeMaxima;
        iSensorUmidade sensor;

        public Monitorador(iSensorUmidade sensor, Action callbackLOW, Action callbackHIGH, float umidadeMinima, float umidadeMaxima)
        {
            this.sensor = sensor;
            this.callbackLOW = callbackLOW;
            this.callbackHIGH = callbackHIGH;
            this.umidadeMinima = umidadeMinima;
            this.umidadeMaxima = umidadeMaxima;
        }
        public void loop()
        {
            while (!Program.Terminated)
            {
                float umidadeAtual = sensor.getLeitura();
                if (umidadeAtual < umidadeMinima)
                {
                    Console.WriteLine("a umidade estava abaixo do minimo");
                    callbackLOW();
                }

                if (umidadeAtual > umidadeMaxima)
                {
                    Console.WriteLine("a umidade estava acima do maximo");
                    callbackHIGH();
                }


                string s = "Umidade atual da grama:" + umidadeAtual.ToString();
                Console.WriteLine(s);

                Natureza.Tempo.Instance.inserePequenoDelay();
            }
        }
    }
}
