using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Json;
using System.ComponentModel;

namespace VinylShop.Entity
{
    [Serializable]
    class CollectionStorage
    {
        private static CollectionStorage instance;
        private ObservableCollection<VinylRecord> Records { get; set; }
        
        private CollectionStorage() 
        {
            Records = new ObservableCollection<VinylRecord>();
        }

        public static CollectionStorage GetInstance()
        {
            if(instance == null)
            {
                instance = new CollectionStorage();
            }
            return instance;
        }

        public void Add(VinylRecord vinylRecord)
        {
            Records.Add(vinylRecord);
        }

        public ObservableCollection<VinylRecord> GetCollection()
        {
            return Records;
        }

        public void SerializeToJSON(string filePath)
        {
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }

            DataContractJsonSerializer json = new DataContractJsonSerializer(typeof(ObservableCollection<VinylRecord>));
            using(FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate))
            {
                json.WriteObject(fs, Records);
            }
        }

        public void DeserializeJSON(string filePath)
        {
            Records.Clear();
            DataContractJsonSerializer json = new DataContractJsonSerializer(typeof(ObservableCollection<VinylRecord>));
            using (FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate))
            {
                var temp = (ObservableCollection<VinylRecord>)json.ReadObject(fs);
                foreach(var item in temp)
                {
                    Records.Add(item);
                }
                
            }

        }
    }
}
