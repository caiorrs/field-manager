using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Threading;

namespace WindowsFormVersion.Sistema_de_Corte.Monitoramento
{
    class Monitorador
    {
        Action callback;
        float valorLimite;

        public Monitorador(Action callback, float valorLimite)
        {
            this.callback = callback;
            this.valorLimite = valorLimite;
        }

        public void loop()
        {
            while (!Program.Terminated)
            {
                float alturaAtual = Natureza.Grama.Instance.altura;
                if (alturaAtual > valorLimite)
                {
                    Console.WriteLine("altura da grama ultrapassou o limite");
                    callback();
                }
                string s = "Altura atual da grama:" + alturaAtual.ToString();
                Console.WriteLine(s);

                Natureza.Tempo.Instance.inserePequenoDelay();
            }
        }
    }
}
