using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace OOP_Lab02_3.Singleton
{
    class FormConfiguration
    {
        private FormConfiguration() { }

        private static FormConfiguration example;

        public static FormConfiguration GetInstance()
        {
            if (example == null)
            {
                example = new FormConfiguration();
            }

            return example;
        }

        public Size ClientSize { get; set; }
        public string Name { get; set; }
        
    }
}
