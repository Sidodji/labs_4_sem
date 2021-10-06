using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab02_3.Memento
{
    public delegate void MementoEvent(string message);
    class Car
    {
        public event MementoEvent Event;

        private string name;
        private string color;
        private int speed;

        public string Name { get { return name; } }
        public string Color { get { return color; } }
        public int Speed { get { return speed; } }

        public void SetName(string name)
        {
            this.name = name;
            Event.Invoke($"Set Car name: {name}");
        }

        public void SetColor(string color)
        {
            this.color = color;
            Event.Invoke($"Set Car name: {color}");
        }

        public void SetSpeed(int speed)
        {
            this.speed = speed;
            Event.Invoke($"Set Car name: {speed}");
        }

        public Snapshot CreateSnapshot()
        {
            Event.Invoke($"Snapshot was made");
            return new Snapshot(this, name, color, speed);
        }
    }
}
