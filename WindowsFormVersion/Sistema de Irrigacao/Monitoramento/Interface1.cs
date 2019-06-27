using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormVersion.Sistema_de_Irrigacao.Monitoramento
{

    class SensorUmidade : iSensorUmidade
    {
        public float getLeitura()
        {
            return Natureza.Grama.Instance.umidade;
        }
    }

    interface iSensorUmidade
    {
        float getLeitura();
    }
}
