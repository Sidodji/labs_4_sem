using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Lab02_3.Protorype
{
    class Admin : IPrototype
    {
        public string Name { get; set; }
        public string Job { get; set; }
        
        public Admin(string name, string job)
        {
            Name = name;
            Job = job;
        }

        public IPrototype Clone()
        {
            return new Admin(this.Name, this.Job);
        }

        public void GetInfo()
        {
            MessageBox.Show($"имя: {Name}, работа: {Job}");
        }
    }
}
