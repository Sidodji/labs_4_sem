using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab02_3.Adapter
{
    class Adapter
    {
        public event AdapterEvents Event;
        public void BuildPartA(IBook book, string name)
        {
            book.setTitleBook(name);
        }
    }
}
