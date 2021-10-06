using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab02_3.AbstractFactory
{
    public delegate void ClientEventHandler(string message);
    class Client 
    {
        public event ClientEventHandler Event;
        public void Main()
        {
            Event.Invoke("Начало работы Фабрики: ");
            var factory = new LibraryPlan();
            factory.Event += new ClientEventHandler(EventProcessing);
            Build(factory);
        }

        public void Build(IAbstractFactory factory)
        {
            var classicBookBuilding = factory.CreateBookClassic();
            var fantasyBookBuilding= factory.CreateBookFantasy();

            classicBookBuilding.CountOfBook(5);
            fantasyBookBuilding.TitleOfBook("1988"); 
        }

        private void EventProcessing(string message)
        {
            Event.Invoke(message);
        }
    }
}
