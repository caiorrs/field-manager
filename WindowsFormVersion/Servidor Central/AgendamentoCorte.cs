using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormVersion.Servidor_Central
{
    public class AgendamentoCorte : IComparable
    {
        private DateTime dataHora;
        private float altura;
        public AgendamentoCorte(DateTime dataHora, float altura)
        {
            this.dataHora = dataHora;
            this.altura = altura;
        }
        public DateTime getDate()
        {
            return this.dataHora;
        }
        public float getAltura()
        {
            return this.altura;
        }

        public int CompareTo(object obj)
        {
            AgendamentoCorte a2 = obj as AgendamentoCorte;

            if (this.dataHora == a2.dataHora)
                return 0;
            else if (this.dataHora < a2.dataHora)
                return -1;
            else
                return 1;// this.dataHora > a2.dataHora
        }
    }
}
