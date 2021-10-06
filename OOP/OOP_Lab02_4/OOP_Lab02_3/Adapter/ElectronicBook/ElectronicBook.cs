using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab02_3.Adapter
{
    class ElectronicBook : IElectronicBook
    {
        public event AdapterEvents Event;

        public void SetTitleElectronic(string electronicTitle)
        {
            Event.Invoke($"Название электронной книги: {electronicTitle}");
        }
    }
}
