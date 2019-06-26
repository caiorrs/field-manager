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

        public Monitorador(Action callbackLOW, Action callbackHIGH, float umidadeMinima, float umidadeMaxima)
        {
            this.callbackLOW = callbackLOW;
            this.callbackHIGH = callbackHIGH;
            this.umidadeMinima = umidadeMinima;
            this.umidadeMaxima = umidadeMaxima;
        }
        public void loop()
        {
            while (true)
            {
                float umidadeAtual = Natureza.Grama.Instance.umidade;
                if (umidadeAtual < umidadeMinima)
                {
                    Console.WriteLine("a umidade estava abaixo do minimo");
                    callbackLOW();
                }


                //TO-DO como 

                if (umidadeAtual > umidadeMaxima)
                {
                    //ai tenho que mandar uma mensagem para o sistema de cobertura
                    //para que o bixo feche a cobertura
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
