using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LibraryStore.Book;

namespace LibraryStore.Command
{
   class AddInCollection : ICommand
   {
        CollectionBook collectionBook;
        BookStore bookStore;

        public AddInCollection(CollectionBook collectionBook, BookStore bookStore)
        {
            this.collectionBook = collectionBook;
            this.bookStore = bookStore.ShallowCopy();  
        }

        public void Execute()
        {
            this.collectionBook.GetCollection().Add(this.bookStore);
        }
   }

}
