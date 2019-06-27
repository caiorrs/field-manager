using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormVersion.Business
{
    class Agendamento
    {
        public Agendamento(int hora, float perc)
        {
            this.horaDoDia = hora;
            this.value = perc;
        }
        public int horaDoDia { get; }
        public float value { get; }

        public override string ToString()
        {
            return "Hora: " + horaDoDia.ToString() + "; %: " + value.ToString();
        }
    }
}
