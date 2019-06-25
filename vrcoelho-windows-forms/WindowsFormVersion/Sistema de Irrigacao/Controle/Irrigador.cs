using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormVersion.Sistema_de_Irrigacao.Controle
{
    class Irrigador
    {
        public float UmidadeIdeal { get; set; }
        public void Irrigar()
        {
            //irriga ate o negocio ficar com a umidade minima? ou uma media... ver isso
            Natureza.Grama.Instance.umidade = UmidadeIdeal;

            //TO-DO
            //aqui tem a parte de persistir os logs?
        }

    }
}
