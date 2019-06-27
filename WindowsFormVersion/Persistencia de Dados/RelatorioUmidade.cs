using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormVersion.Persistencia_de_Dados
{
    class RelatorioUmidade
    {
        private DataSaver<Log> Dados = null;

        private static RelatorioUmidade _Instance = null;

        private RelatorioUmidade()
        {
            Dados = new DataSaver<Log>();
            Dados.LoadFromFile("RelatorioUmidade.xml");
        }

        ~RelatorioUmidade()
        {
            Dados.SaveToFile("RelatorioUmidade.xml");
        }

        public static RelatorioUmidade Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new RelatorioUmidade();
                }
                return _Instance;
            }
        }

        public bool AddLog(DateTime date, string texto)
        {
            Log newItem = new Log();
            newItem.tipoEvento = Log.LogType.ltUmidade;
            newItem.dataEvento = date;
            newItem.descricaoEvento = texto;
            this.Dados.Add(newItem);
            return true;
        }

        public string GerarRelatorio(DateTime inicio, DateTime fim)
        {
            string result = "";
            List<Log> SortedList = Dados.OrderBy(o => o.dataEvento).ToList();
            foreach (Log Item in SortedList)
            {
                if ((Item.dataEvento >= inicio) && (Item.dataEvento <= fim) && (Item.tipoEvento == Log.LogType.ltUmidade))
                {
                    result += "[" + Item.dataEvento.ToString() + "] " + Item.descricaoEvento + "\r\n";
                }
            }
            return result;
        }
    }
}
