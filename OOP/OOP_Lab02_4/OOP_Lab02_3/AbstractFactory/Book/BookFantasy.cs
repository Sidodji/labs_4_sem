using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab02_3.AbstractFactory
{
    class BookFantasy : IBook
    {
        public event ClientEventHandler Event;

        public void CountOfBook(int number)
        {
            Event.Invoke($"Number of book fantasy: {number}");
        }

        public void TitleOfBook(string name)
        {
            Event.Invoke($"title of fantasy book:  {name}");
        }
    }
}
