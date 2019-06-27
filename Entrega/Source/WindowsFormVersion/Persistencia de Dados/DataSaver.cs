using System.Collections.Generic;
using System.Runtime.Serialization;
using System.IO;

namespace WindowsFormVersion.Persistencia_de_Dados
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
                DataSaver<T> newInstance = null;
                this.Clear();

                try
                {
                    FileStream fRead = new FileStream(fName, FileMode.Open);
                    DataContractSerializer xmlReader = new DataContractSerializer(typeof(DataSaver<T>));
                    newInstance = (DataSaver<T>)xmlReader.ReadObject(fRead);
                    fRead.Close();
                }
                catch
                {
                    newInstance = null;
                }

                if (newInstance != null)
                {
                    this.AddRange(newInstance);
                    newInstance = null;
                }
            }
            else
            {
                this.Clear();
            }
        }

    }
}
