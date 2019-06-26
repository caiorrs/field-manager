using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.IO;

namespace WindowsFormVersion
{
    [CollectionDataContract]
    public class DataSaver<T> : List<T>
    {
        public void SaveToFile(string fName = "")
        {
            if (fName == "")
            {
                fName = typeof(T).Name + ".xml";
            }
            DataContractSerializer xmWriterl = new DataContractSerializer(typeof(DataSaver<T>));
            FileStream fWrite = new FileStream(fName, FileMode.Create);
            xmWriterl.WriteObject(fWrite, this);
            fWrite.Close();
        }

        public void LoadFromFile(string fName = "")
        {
            if (fName == "")
            {
                fName = typeof(T).Name + ".xml";
            }

            if (File.Exists(fName))
            {
                FileStream fRead = new FileStream(fName, FileMode.Open);
                DataContractSerializer xmlReader = new DataContractSerializer(typeof(DataSaver<T>));
                DataSaver<T> newInstance = (DataSaver<T>)xmlReader.ReadObject(fRead);
                fRead.Close();
                this.Clear();
                this.AddRange(newInstance);
                newInstance = null;
            }
            else
            {
                this.Clear();
            }
        }

    }
}
