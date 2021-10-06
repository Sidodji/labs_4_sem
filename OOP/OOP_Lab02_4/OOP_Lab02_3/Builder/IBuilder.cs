using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Imaging;

namespace OOP_Lab02_3.Builder
{
    public interface IBuilder
    {
        void SetWindow(System.Drawing.Size sizeWindow);
        void SetButton(System.Drawing.Point locationButton, System.Drawing.Size sizeButton, string name);
    }
}
