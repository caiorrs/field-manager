using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormVersion.Sistema_de_Corte.Monitoramento
{


    class TimeMonitor
    {
        Action callback; // funcao do corte que corta a grama
        int horaAgendada;

        public TimeMonitor(Action callback, int horaAgendada)
        {
            this.callback = callback;
            this.horaAgendada = horaAgendada;
        }

        public void loop()
        {
            int horaAgora = -1;
            while (true)
            {
                horaAgora = Natureza.Tempo.Instance.HoraDoDia();
                
                if (horaAgora == horaAgendada)
                {
                    //se saiu do loop eh pq ta na hora de cortar a grama
                    callback();
                    break; //sai da thread
                }

                Natureza.Tempo.Instance.inserePequenoDelay();
            }
        }
    }

}
