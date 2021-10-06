using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace LibraryStore.Book
{
    class BookCollectionMemento
    {
        public ObservableCollection<BookStore> Book { get; private set; }

        public BookCollectionMemento(ObservableCollection<BookStore> book)
        {
            this.Book = book;
        }
    }
}
