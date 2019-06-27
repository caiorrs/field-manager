using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormVersion.Sistema_de_Corte
{
    class LogCorte
    {
        DateTime dataCorte { get; }
        float alturaCorte { get; }

        public LogCorte(DateTime dataCorte, float alturaCorte)
        {
            this.dataCorte = dataCorte;
            this.alturaCorte = alturaCorte;
        }

        public override string ToString() {

            return dataCorte.ToString("MM/dd/yyyy h:mm tt") + "| Altura:" + alturaCorte.ToString() + "mm";

        }
    }
}
