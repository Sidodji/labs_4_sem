using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OOP_Lab02_3.AbstractFactory
{
    public interface IAbstractFactory
    {
        IBook CreateBookClassic();
        IBook CreateBookFantasy();
    }
}
