using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormVersion.Sistema_de_Corte.Monitoramento
{
    class TimeMonitor
    {
        Action cortarGrama; // funcao do corte que corta a grama
        Action<float> setarAlturaGrama;
       Business.Agendamento agendamento;

        public TimeMonitor(Action cortarGrama,  Action<float> setarAlturaGrama, Business.Agendamento agendamento)
        {
            this.cortarGrama = cortarGrama;
            this.setarAlturaGrama = setarAlturaGrama;
            this.agendamento = agendamento;
        }

        public void loop()
        {
            int horaAgora = -1;
            int horaAgendada = agendamento.horaDoDia;
            while (true)
            {
                horaAgora = Natureza.Tempo.Instance.HoraDoDia();

                if (horaAgora == horaAgendada)
                {
                    //se saiu do loop eh pq ta na hora de cortar a grama
                    setarAlturaGrama(agendamento.value);
                    cortarGrama();
                    break; //sai da thread
                }

                Natureza.Tempo.Instance.inserePequenoDelay();
            }
        }
    }

}
