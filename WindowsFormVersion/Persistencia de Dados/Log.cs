using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormVersion.Persistencia_de_Dados
{
    [DataContractAttribute]
    class Log
    {
        public enum LogType
        {
            ltCorte,
            ltUmidade
        }

        public DateTime dataEvento;
        public LogType tipoEvento;
        public string descricaoEvento;
    }
}
