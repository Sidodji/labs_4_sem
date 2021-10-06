using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Custom
{
    public class Custom
    {
        public class MyCustomControl : Button
        {

            static MyCustomControl()
            {
                DefaultStyleKeyProperty.OverrideMetadata(typeof(MyCustomControl), new
                   FrameworkPropertyMetadata(typeof(MyCustomControl)));
            }

        }
    }
}
