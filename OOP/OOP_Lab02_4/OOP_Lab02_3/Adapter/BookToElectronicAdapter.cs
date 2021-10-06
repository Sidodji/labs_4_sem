using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab02_3.Adapter
{
    class BookToElectronicAdapter : IBook
    {
        public event AdapterEvents Event;

        ElectronicBook electronicBook;
        public BookToElectronicAdapter(ElectronicBook electronicBook)
        {
            this.electronicBook = electronicBook;
        }

        public void setTitleBook(string title)
        {
            Event.Invoke("Адаптируем название книги в название электронной книги");
            electronicBook.SetTitleElectronic(title);
        }
    }
}
