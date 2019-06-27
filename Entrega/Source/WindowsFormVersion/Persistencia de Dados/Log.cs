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
        [DataContractAttribute]
        public enum LogType
        {
            [EnumMember]
            ltCorte,
            [EnumMember]
            ltUmidade
        }

        [DataMember]
        public DateTime dataEvento;
        [DataMember]
        public LogType tipoEvento;
        [DataMember]
        public string descricaoEvento;
    }
}
