﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Threading;

using WindowsFormVersion.Sistema_de_Corte.Monitoramento;
using WindowsFormVersion.Business;

namespace WindowsFormVersion.Sistema_de_Corte.Controle
{
    class Controlador: iCorte
    {
        Cortador cortador;

        public void UpdateAltura(float value)
        {
            cortador.setAlturaLamina(value);
        }

        public void Cortar()
        {
            cortador.Cortar();
        }
        public void agendarCorte(Agendamento corteAgendado)
        {                                            
            Action cortarGrama = cortador.Cortar;
            Action<float> setAlturaLamina = cortador.setAlturaLamina;
            TimeMonitor t = new TimeMonitor(cortarGrama, setAlturaLamina, corteAgendado);
            Thread thr = new Thread(new ThreadStart(t.loop));
            thr.Start();
            Console.WriteLine("iniciou thread para realizar o corte no horario agendado");
        }

        public  void setup()
        {
            //crio classe q fica monitorando a natureza
            float alturaPreDefinida = 10; //valor padrão
            cortador = new Cortador();
            cortador.setAlturaLamina(alturaPreDefinida);

            Action callback = cortador.Cortar;

            float alturaMaxima = 40;
            Monitorador m = new Monitorador(callback, alturaMaxima);

            Thread thr = new Thread(new ThreadStart(m.loop));
            thr.Start();
            Console.WriteLine("instanciou corte");            
        }
    }
}
