using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab02_3.Memento
{
    class Command
    {
        public event MementoEvent Event;

        private Snapshot backup;

        public void MakeBackup(Car car)
        {
            backup = car.CreateSnapshot();
            Event.Invoke("Backup was made");
        }

        public void Undo(ref Car car)
        {
            if (backup != null)
            {
                Event.Invoke("Undo object");
                car = backup.Restore();
            }
        }
    }
}
