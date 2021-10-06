using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Lab02_3.Protorype
{
    public interface IPrototype
    {
        IPrototype Clone();
    }
}
