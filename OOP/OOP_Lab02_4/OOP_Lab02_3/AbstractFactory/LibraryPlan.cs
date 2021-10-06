using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab02_3.AbstractFactory
{
    class LibraryPlan : IAbstractFactory
    {
        public event ClientEventHandler Event;

        public IBook CreateBookClassic()
        {
            var bookClassic = new BookClassic();
            bookClassic.Event += new ClientEventHandler(EventProcessor);
            return bookClassic;
        }

        public IBook CreateBookFantasy()
        {
            var bookFantasy = new BookFantasy();
            bookFantasy.Event += new ClientEventHandler(EventProcessor);
            return bookFantasy;
        }

        private void EventProcessor(string message)
        {
            Event.Invoke(message);
        }
    }
}
