using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab02_3.Adapter
{
    public delegate void AdapterEvents(string message);
    class Client
    {
        public event AdapterEvents Event;
        public void Main()
        {
            Adapter builder = new Adapter();
            builder.Event += new AdapterEvents(EventProcessing);

            Book book = new Book();
            book.Event += new AdapterEvents(EventProcessing);

            builder.BuildPartA(book, "Тысяча чертей");

            ElectronicBook electronicBook = new ElectronicBook();
            electronicBook.Event += new AdapterEvents(EventProcessing);

            BookToElectronicAdapter bookToElectronic = new BookToElectronicAdapter(electronicBook);
            bookToElectronic.Event += new AdapterEvents(EventProcessing);

            IBook electronicBuild = bookToElectronic;

            builder.BuildPartA(electronicBuild, "Конь и воин");
        }

        public void EventProcessing(string message)
        {
            Event.Invoke(message);
        }
    }
}
