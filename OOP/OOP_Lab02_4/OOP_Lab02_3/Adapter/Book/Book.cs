using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab02_3.Adapter
{
    class Book :IBook
    {
        public event AdapterEvents Event;

        public void setTitleBook(string bookTitle)
        {
            Event.Invoke($"Название печатной книги: {bookTitle}");
        }
    }
}
