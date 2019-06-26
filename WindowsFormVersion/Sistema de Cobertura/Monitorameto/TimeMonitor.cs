using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WindowsFormVersion.Sistema_de_Cobertura.Monitorameto
{ 
    class TimeMonitor
    {
        Action<float> setAbertura; // funcao da cobertura que seta a abertura
        Queue<Business.Agendamento> q;
        int CONTINUE;

        public TimeMonitor(Action<float> callback, Queue<Business.Agendamento> q, ref int CONTINUE)
        {
            this.setAbertura = callback;
            this.q = q;
            this.CONTINUE = CONTINUE;
        }

        public void loop()
        {
            while (!Program.Terminated)
            {
                if (q.Count == 0)
                {
                    Console.WriteLine("fim do agendamento");
                        break;
                }

                Business.Agendamento nextAgendamento = q.Dequeue();
                int nexHour = nextAgendamento.horaDoDia;
                float abertura = nextAgendamento.value;

                int horaAgora = -1;

                Console.WriteLine("///////////////////////continue agora vale {0}", CONTINUE);

                while((!Program.Terminated) && (horaAgora != nexHour))
                {
                    horaAgora = Natureza.Tempo.Instance.HoraDoDia();
                    Natureza.Tempo.Instance.inserePequenoDelay();
                }

                //  to-do POSSIVEL BUG

                //se saiu do loop eh pq ta na hora de fazer o negocio
                setAbertura(abertura);              

            }
        }
    }
}
