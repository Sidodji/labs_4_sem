using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Lab02_3.Protorype
{
    class User : IPrototype
    {
        string Name;
        int Age;

        public User(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public IPrototype Clone()
        {
            
            return new User(this.Name, this.Age);
        }

        public void GetInfo()
        {
             MessageBox.Show($"имя: {Name}, возраст: {Age}");
        }
    }
}
