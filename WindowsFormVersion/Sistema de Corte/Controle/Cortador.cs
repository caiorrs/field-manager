using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormVersion.Sistema_de_Corte.Controle
{
    class Cortador
    {
        public float alturaLamina { get; set;}

        public void Cortar()
        {
            //corta a altura da grama na altura da lamina predefinida...
            Natureza.Grama.Instance.altura = alturaLamina;
            Console.WriteLine("|||| GRAMA CORTADA");

            //TO-DO
            //aqui além de cortar a grama, deve fazer a parte de persistir os logs?
            LogCorte log = new LogCorte(Natureza.Tempo.Instance.Now, alturaLamina);

            //NATANAEL
        }
    }
}
