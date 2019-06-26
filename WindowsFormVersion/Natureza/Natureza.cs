using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace WindowsFormVersion.Natureza
{
    //implementando a grama como um singleton
    //por enquanto um bem simples porque ele nao eh thread safe
    public sealed class Grama
    {
        public float altura { get; set; }
        public float umidade { get; set; }

        private static readonly Grama instance = new Grama();
        private Grama() { }

        public static Grama Instance
        {
            get
            {
                return instance;
            }
        }
    }

    public sealed class Tempo
    {
        private static readonly Tempo instance = new Tempo();
        public int velocidadeTempo { get; } //em segundos

        private Tempo()
        {
            this.Now = DateTime.Today;
            this.velocidadeTempo = 2;
        }

        public static Tempo Instance
        {
            get
            {
                return instance;
            }
        }

        public DateTime Now;

        public int HoraDoDia()
        {
            return this.Now.Hour;
        }

        public void passTime()
        {
            while (true)
            {
                DateTime Temp = Now;
                Temp = Temp.AddHours(1);
                this.Now = Temp;
                Thread.Sleep(1000 * this.velocidadeTempo);
                Console.WriteLine("tempo agora: " + Now.ToString());
            }
        }

        public void inserePequenoDelay()
        {
            Thread.Sleep(this.velocidadeTempo * 1000 / 5);
        }

        public void passaDuasHoras()
        {
            Thread.Sleep(this.velocidadeTempo * 1000 * 2);
        }

    }

    public sealed class Clima
    {
        private static readonly Clima instance = new Clima();
        private Clima()
        {
            this.chuva = false;
        }

        private bool chuva;

        public static Clima Instance
        {
            get
            {
                return instance;
            }
        }

        public bool vaiChover()
        {
            return this.chuva;
        }
    }

}
