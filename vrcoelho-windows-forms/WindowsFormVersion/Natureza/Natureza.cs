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
        private Tempo()
        {
            this.Now = DateTime.Today;
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
                Thread.Sleep(2000); //a cada 3 segundos passa uma hora...
                Console.WriteLine("tempo agora: " + Now.ToString());
            }
        }

    }

}
