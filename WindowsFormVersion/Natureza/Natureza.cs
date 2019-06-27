using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormVersion.Natureza
{
    //implementando a grama como um singleton
    //por enquanto um bem simples porque ele nao eh thread safe
    public sealed class Grama
    {
        private float _altura;
        private float _umidade;
        public float altura
        {
            get
            {
                return _altura;
            }

            set
            {
                _altura = value;
                if (Simulador.Instance != null)
                {
                    Simulador.Instance.UpdateGramaSize(_altura);
                }
            }
        }
        public float umidade
        {
            get
            {
                return _umidade;
            }

            set
            {
                _umidade = value;
                if (Simulador.Instance != null)
                {
                    Simulador.Instance.UpdateUmidade(_umidade);
                }
            }
        }

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
            while (!Program.Terminated)
            {
                DateTime Temp = Now;
                Temp = Temp.AddHours(1);
                this.Now = Temp;
                if (Simulador.Instance != null)
                {
                    Simulador.Instance.UpdateTempo(Now.ToString());
                }
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
            this.chuvaAgora = false;
            this.chuvaFuturo = false;
        }

        private bool _chuvaAgora;

        private bool chuvaAgora
        {
            get
            {
                return _chuvaAgora;
            }

            set
            {
                _chuvaAgora = value;
                if (Simulador.Instance != null)
                {
                    Simulador.Instance.SetChovendo(value);
                }
            }
        }

        private bool chuvaFuturo;

        public static Clima Instance
        {
            get
            {
                return instance;
            }
        }

        public bool estaChovendo()
        {
            return this.chuvaAgora;
        }

        public bool vaiChover()
        {
            return this.chuvaAgora;
        }
    }

}
