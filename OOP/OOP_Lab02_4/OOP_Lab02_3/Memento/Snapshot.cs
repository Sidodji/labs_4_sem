using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab02_3.Memento
{
    class Snapshot
    {
        private Car car;
        private string name, color;
        private int speed;

        public  Snapshot(Car car, string name, string color, int speed)
        {
            this.car = car;
            this.name = name;
            this.color = color;
            this.speed = speed;
        }

        public Car Restore()
        {
            car.SetName(name);
            car.SetColor(color);
            car.SetSpeed(speed);

            return car;
        }
    }
}
