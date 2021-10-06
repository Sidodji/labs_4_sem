using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryStore.Command
{
    class Invoker
    {
        private ICommand _onStart;

        //получаем команду
        public void SetOnStart(ICommand command)
        {
            this._onStart = command;
        }

        //вызываем
        public void Do()
        {
            if (this._onStart is ICommand)
                this._onStart.Execute();
        }
    }
}
