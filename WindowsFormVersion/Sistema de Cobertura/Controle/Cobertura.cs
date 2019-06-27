using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormVersion.Sistema_de_Cobertura.Controle
{
    class Cobertura
    {

        private float porcentagemAberturaAtual;

        /*
         * 
         * 
         * 
         * 
         * 
         * 
         */



        /* public interface iCobertura
         {
             /// Seta a porcentagem de abertura da cobertura. 0% para a cobertura completamente fechada e 100% para cobertura completamente aberta.
             boolean setOpening(float percentage);

         }
         */

            public bool estaChovendo()
        {
            return Natureza.Clima.Instance.estaChovendo();
        }

        public void setOpening(float percentage)
        {
            this.porcentagemAberturaAtual = percentage;
            this.printStatus();
          //  return true;
        }


        public void open()
        {
            this.setOpening(100);
            Console.WriteLine("abrindo...");
        }
        public void close()
        {
            this.setOpening(0);
            Console.WriteLine("fechando...");
        }

        private void printStatus()
        {
            string s = "Cobertura | Abertura atual: " + porcentagemAberturaAtual.ToString();
            Console.WriteLine(s);
        }
    }
}
