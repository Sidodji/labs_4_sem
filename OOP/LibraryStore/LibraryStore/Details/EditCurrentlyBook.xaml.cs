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
using LibraryStore.Command;

namespace LibraryStore.Details
{
    /// <summary>
    /// Логика взаимодействия для EditCuttentlyBook.xaml
    /// </summary>
    public partial class EditCurrentlyBook : Window
    {
        Invoker invoker;
        BookStore CurrentlyBookStore { get; set; }

        public EditCurrentlyBook()
        {
            InitializeComponent();
        }

        public EditCurrentlyBook(BookStore bookStore)
        {
            InitializeComponent();

            this.CurrentlyBookStore = bookStore;
            this.invoker = new Invoker();

            AddBook_stackPanel.DataContext = this.CurrentlyBookStore;
        }

        private void SaveChanges_Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void LoadImage_button_Click(object sender, RoutedEventArgs e)
        {
            this.invoker.SetOnStart(new LoadImage(this.CurrentlyBookStore));
            this.invoker.Do();
        }
    }
}
