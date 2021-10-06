using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using LibraryStore.Book;
using LibraryStore.Details;

namespace LibraryStore.Command
{
    class ShowBookData : ICommand
    {
        DataGridRow row;
        public ShowBookData(object button)
        {
            var buttonTemp = (FrameworkElement)button;
            this.row = (DataGridRow)buttonTemp.Tag;
        }
        public void Execute()
        {
            var window = new Info((BookStore)row.Item);
            window.Show();
        }
    }
}
