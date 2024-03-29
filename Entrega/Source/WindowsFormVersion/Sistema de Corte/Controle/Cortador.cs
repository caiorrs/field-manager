﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormVersion.Persistencia_de_Dados;

namespace WindowsFormVersion.Sistema_de_Corte.Controle
{
    class Cortador
    {
        private float alturaLamina;

        public void setAlturaLamina(float altura)
        {
            this.alturaLamina = altura;
        }

        public void Cortar()
        {
            //corta a altura da grama na altura da lamina predefinida...
            float alt = Natureza.Grama.Instance.altura;
            Natureza.Grama.Instance.altura = alturaLamina;
            Console.WriteLine("|||| GRAMA CORTADA");

            //aqui além de cortar a grama, deve fazer a parte de persistir os logs?
            RelatorioCorte.Instance.AddLog(Natureza.Tempo.Instance.Now, "Grama cortada com altura: " + alturaLamina.ToString() + ". Altura anterior: " + alt.ToString());
        }
    }
}
