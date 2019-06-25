using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

}
