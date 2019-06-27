using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormVersion.Sistema_de_Irrigacao
{
    class LogUmidade
    {
        DateTime dataIrrigacao { get; }
        float valorUmidade { get; }

        public LogUmidade(DateTime dataIrrigacao, float valorUmidade)
        {
            this.dataIrrigacao = dataIrrigacao;
            this.valorUmidade = valorUmidade;
        }

        public override string ToString()
        {
            return dataIrrigacao.ToString("MM/dd/yyyy h:mm tt") + "| Altura:" + valorUmidade.ToString() + "mm";
        }
    }
}
