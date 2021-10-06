using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab02_3.Builder
{
    class BuilderDirector
    {
        private IBuilder iBuilder;

        public IBuilder Builder
        {
            set
            {
                iBuilder = value;
            }
        }

        public void BuildForm()
        {
            iBuilder.SetWindow(new System.Drawing.Size(700, 250));
        }

        public void BuildButton()
        {
            iBuilder.SetWindow(new System.Drawing.Size(700, 250));
            iBuilder.SetButton(new System.Drawing.Point(20,20), new System.Drawing.Size(100, 25), "New button");
        }
    }

    

}
