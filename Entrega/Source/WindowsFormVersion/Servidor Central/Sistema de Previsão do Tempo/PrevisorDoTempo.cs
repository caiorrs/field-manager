using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormVersion.Servidor_Central.Sistema_de_Previsão_do_Tempo
{

    /*
     * 
     * obtem de alguma forma a previsao do tempo
     * 
     * com base nisso, precisa gerar o cronograma para os sistemas
     * 
     * quais sistemas?
     * 
     *      > cobertura > horas de sol
     *      
     *      > outros????
     * 
     * 
     * */
    class PrevisorDoTempo
    {

        /*
         * cronograma de horas de sol. precisa saber se vai chover
        
        */
        

        private Queue<Business.Agendamento> createCronogramaHorasSol()
        {
            Queue<Business.Agendamento> q = new Queue<Business.Agendamento>();

            Previsao prev = new Previsao(Natureza.Tempo.Instance.Now);

            if (prev.iraChover())
            {
                for (int i = 0; i < 24; i++)
                {
                    float p  = 30; //como vai chover matenho a abertura em 30% para nao molhar demais a grama
                    Business.Agendamento a = new Business.Agendamento(i, p);
                    q.Enqueue(a);
                }
            }
            else
            {
                for (int i = 0; i < 24; i++)
                {
                    //fake total
                    float p;
                    //50% eh o padrao, mas entre as 14 e as 18, abro em 100 pra pegar sol%
                    if (i >= 14 && i <= 18)
                        p = 100;
                    else
                        p = 50;
                    Business.Agendamento a = new Business.Agendamento(i, p);
                    q.Enqueue(a);
                }
            }
            return q;
        }

    }

    class Previsao
    {
        private bool vaiChover;
        public Previsao(DateTime dia)
        {
            //logica para obter a previsao aqui
            //colocar aqui modo manual etc de simulacao? TO-DO

            //fazer uma logica em cima da data?
            this.vaiChover = Natureza.Clima.Instance.vaiChover();
        }

        public bool iraChover()
        {
            return this.vaiChover;
        }

       
    }

}
