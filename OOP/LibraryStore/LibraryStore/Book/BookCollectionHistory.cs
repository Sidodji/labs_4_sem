using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryStore.Book
{
    class BookCollectionHistory
    {
        public Stack<BookCollectionMemento> History { get; private set; }

        public BookCollectionHistory()
        {
            this.History = new Stack<BookCollectionMemento>();
        }
    }
}
