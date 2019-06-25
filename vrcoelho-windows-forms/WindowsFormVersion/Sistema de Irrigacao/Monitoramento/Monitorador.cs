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
        Action callback;
        float umidadeMinima;

        public Monitorador(Action callback, float umidadeMinima)
        {
            this.callback = callback;
            this.umidadeMinima = umidadeMinima;
        }

        public void loop()
        {
            while (true)
            {
                float umidadeAtual = Natureza.Grama.Instance.umidade;
                if (umidadeAtual < umidadeMinima)
                {
                    Console.WriteLine("a umidade estava abaixo do minimo");
                    callback();
                }


                //TO-DO como 
                /*
                if (umidadeAtual > umidadeMaxima)
                {
                //ai tenho que mandar uma mensagem para o sistema de cobertura
                //para que o bixo feche a cobertura
                }
                */

                    string s = "Umidade atual da grama:" + umidadeAtual.ToString();
                Console.WriteLine(s);                

                Thread.Sleep(1000);
            }
        }
    }
}
