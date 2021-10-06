using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

using LibraryStore.Book;

namespace LibraryStore.Details
{
    /// <summary>
    /// Логика взаимодействия для Info.xaml
    /// </summary>
    public partial class Info : Window
    {
        BookStore CurrentlyLibraryStore { get; set; }

        public Info()
        {
            InitializeComponent();
        }

        public Info(BookStore bookStore)
        {
            InitializeComponent();
            this.CurrentlyLibraryStore = bookStore;
            mainGrid.DataContext = CurrentlyLibraryStore;
        }

        private void EditCurrentlyBook_button(object sender, RoutedEventArgs e)
        {
            var window = new EditCurrentlyBook(CurrentlyLibraryStore);
            window.Show();
        }
    }
}
