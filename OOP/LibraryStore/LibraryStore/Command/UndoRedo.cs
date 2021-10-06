using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryStore.Command
{
    class UndoRedo
    {
        private static UndoRedo bookCollection;

        private Stack<ICommand> CommandsStorage { get; set; }

        private UndoRedo()
        {
            CommandsStorage = new Stack<ICommand>();
        }

        public static UndoRedo GetInstance()
        {
            if (bookCollection == null)
            {
                bookCollection = new UndoRedo();
            }
            return bookCollection;
        }


        public void SaveLastCommand(ICommand command)
        {
            if (CommandsStorage.Count > 0)
            {
                CommandsStorage.Pop();
            }
            CommandsStorage.Push(command);
        }

        public void RedoLastCommand()
        {
            var invoker = new Invoker();
            invoker.SetOnStart(CommandsStorage.Peek());
            invoker.Do();
        }
    }
}
