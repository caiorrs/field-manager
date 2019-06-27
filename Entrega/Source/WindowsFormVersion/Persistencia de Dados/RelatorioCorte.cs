using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormVersion.Persistencia_de_Dados
{
    class RelatorioCorte
    {
        private DataSaver<Log> Dados = null;

        private static RelatorioCorte _Instance = null;

        private RelatorioCorte()
        {
            Dados = new DataSaver<Log>();
            Dados.LoadFromFile("RelatorioCorte.xml");
        }

        ~RelatorioCorte()
        {
            Dados.SaveToFile("RelatorioCorte.xml");
        }

        public static RelatorioCorte Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new RelatorioCorte();
                }
                return _Instance;
            }
        }

        public bool AddLog(DateTime date, string texto)
        {
            Log newItem = new Log();
            newItem.tipoEvento = Log.LogType.ltCorte;
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
                if ((Item.dataEvento >= inicio) && (Item.dataEvento <= fim) && (Item.tipoEvento == Log.LogType.ltCorte))
                {
                    result += "[" + Item.dataEvento.ToString() + "] " + Item.descricaoEvento + "\r\n";
                }
            }
            return result;
        }
    }
}
