using System;

using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

using System.Runtime.Serialization.Json;
using System.ComponentModel;

namespace LibraryStore.Book
{
    //класс для работы с коллекцией книг
    [Serializable]
    class CollectionBook
    {
        private static CollectionBook instance;
        private ObservableCollection<BookStore> Book { get; set; }

        private CollectionBook()
        {
            Book = new ObservableCollection<BookStore>();
        }

        public static CollectionBook GetInstance()
        {
            if (instance == null)
            {
                instance = new CollectionBook();
            }
            return instance;
        }

        public void Add(BookStore bookStore)
        {
            Book.Add(bookStore);
        }

        public ObservableCollection<BookStore> GetCollection()
        {
            return Book;
        }

        //Сериализация
        public void SerializeToJSON(string filePath)
        {
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }

            DataContractJsonSerializer json = new DataContractJsonSerializer(typeof(ObservableCollection<BookStore>));
            using (FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate))
            {
                json.WriteObject(fs, Book);
            }
        }

        public void DeserializeJSON(string filePath)
        {
            Book.Clear();
            DataContractJsonSerializer json = new DataContractJsonSerializer(typeof(ObservableCollection<BookStore>));
            using (FileStream fs = new FileStream(filePath, FileMode.OpenOrCreate))
            {
                var temp = (ObservableCollection<BookStore>)json.ReadObject(fs);
                foreach (var item in temp)
                {
                    Book.Add(item);
                }

            }
        }

        public BookCollectionMemento SaveState()
        {
            ObservableCollection<BookStore> newCollection = new ObservableCollection<BookStore>();

            foreach (var item in this.Book)
            {
                newCollection.Add(item);
            }

            return new BookCollectionMemento(newCollection);
        }

        public void ResotreState(BookCollectionMemento memento)
        {
            this.Book.Clear();
            foreach (var item in memento.Book)
            {
                this.Book.Add(item);
            }
        }
    }
}
