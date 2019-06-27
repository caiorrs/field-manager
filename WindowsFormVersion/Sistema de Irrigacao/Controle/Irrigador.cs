using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormVersion.Sistema_de_Irrigacao;

namespace WindowsFormVersion.Sistema_de_Irrigacao.Controle
{
    class Irrigador : iIrrigador
    {
        public float UmidadeIdeal { get; set; }       

        public void Irrigar()
        {
            this.ligar();
            //irrigaria por um tempo ate chegar em um valor ideal de umidade
            Natureza.Grama.Instance.umidade = UmidadeIdeal;
            this.desligar();
            //TO-DO
            //aqui tem a parte de persistir os logs de umidade
            //NATANAEL

            LogUmidade log = new LogUmidade(Natureza.Tempo.Instance.Now, UmidadeIdeal);
        }

        public void ligar()
        {
            Console.WriteLine("Irrigadores | Ligar");
        }

        public void desligar()
        {
            Console.WriteLine("Irrigadores | Desligar");
        }


    }
}
