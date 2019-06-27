using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormVersion.Persistencia_de_Dados;
using WindowsFormVersion.Sistema_de_Irrigacao;

namespace WindowsFormVersion.Sistema_de_Irrigacao.Controle
{
    class Irrigador : iIrrigador
    {
        public float UmidadeIdeal { get; set; }       

        public void Irrigar()
        {
            float umi = Natureza.Grama.Instance.umidade;

            this.ligar();
            //irrigaria por um tempo ate chegar em um valor ideal de umidade
            Natureza.Grama.Instance.umidade = UmidadeIdeal;
            this.desligar();

            //aqui tem a parte de persistir os logs?
            RelatorioUmidade.Instance.AddLog(Natureza.Tempo.Instance.Now, "Gramado irrigado cortada com umidade: " + UmidadeIdeal.ToString() + ". Umidade anterior: " + umi.ToString());
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
