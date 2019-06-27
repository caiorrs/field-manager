using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormVersion.Persistencia_de_Dados;

namespace WindowsFormVersion.Sistema_de_Irrigacao.Controle
{


    class Irrigador
    {
        public float UmidadeIdeal { get; set; }
        public void Irrigar()
        {
            //irriga ate o negocio ficar com a umidade minima? ou uma media... ver isso
            float umi = Natureza.Grama.Instance.umidade;
            Natureza.Grama.Instance.umidade = UmidadeIdeal;

            //aqui tem a parte de persistir os logs?
            RelatorioUmidade.Instance.AddLog(Natureza.Tempo.Instance.Now, "Gramado irrigado cortada com umidade: " + UmidadeIdeal.ToString() + ". Umidade anterior: " + umi.ToString());
        }

    }
}
