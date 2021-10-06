using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

using LibraryStore.Book;

namespace LibraryStore.Command
{
    class LoadImage : ICommand
    {
        BookStore bookStore;

        public LoadImage(BookStore bookStore)
        {
            this.bookStore = bookStore;
        }

        public void Execute()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.ShowDialog();
            bookStore.ImagePath = openFileDialog.FileName;
        }
    }
}
