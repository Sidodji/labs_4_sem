using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using LibraryStore.Book;

namespace LibraryStore.Command
{
    class Search : ICommand
    {
        private string searchTitle;
        private string searchJenre;


        public Search(string searchTitle, string searchJenre)
        {
            this.searchTitle = searchTitle;
            this.searchJenre = searchJenre;
        }

        public void Execute()
        {
            CollectionBook collectionBook = CollectionBook.GetInstance();
            IEnumerable<BookStore> result = collectionBook.GetCollection().ToList<BookStore>();

            if (searchTitle != "")
            {
                result = result.Where(item => item.Title.Contains(searchTitle)).Select(item => item);
            }
            if (searchJenre != "")
            {
                result = result.Where(item => item.Jenre.Contains(searchJenre)).Select(item => item);
            }

            collectionBook.GetCollection().Clear();
            foreach (var item in result)
            {
                collectionBook.GetCollection().Add(item);
            }
        }
    }
}
