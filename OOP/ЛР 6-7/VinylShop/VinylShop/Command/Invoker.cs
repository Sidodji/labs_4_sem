using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VinylShop.Command
{
    class Invoker
    {
        private ICommand _onStart;

        public void SetOnStart(ICommand command)
        {
            this._onStart = command;
        }

        public void Do()
        {
            if(this._onStart is ICommand)
            {
                this._onStart.Execute();
            }
        }
    }
}
