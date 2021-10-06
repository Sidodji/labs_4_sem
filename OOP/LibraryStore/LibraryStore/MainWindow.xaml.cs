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
using System.Windows.Navigation;
using System.Windows.Shapes;

using LibraryStore.Book;
using LibraryStore.Command;
using System.Globalization;




namespace LibraryStore
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        CollectionBook collectionBook;
        BookStore NewBookStore { get; set; }
        Invoker invoker;
        UndoRedo undoRedo;
        BookCollectionHistory bookCollectionHistory;



        public MainWindow()
        {
            InitializeComponent();
            this.invoker = new Invoker();
            collectionBook = CollectionBook.GetInstance();
            NewBookStore = new BookStore();
            undoRedo = UndoRedo.GetInstance();
            bookCollectionHistory = new BookCollectionHistory();
            bookCollectionHistory.History.Push(collectionBook.SaveState());


            AddBook_Grid.DataContext = NewBookStore;
            bookDataGrid.ItemsSource = collectionBook.GetCollection();

            App.LanguageChanged += LanguageChanged;
            CultureInfo currLang = App.Language;

            foreach (var lang in App.Languages)
            {
                MenuItem menuLang = new MenuItem();
                menuLang.Header = lang.DisplayName;
                menuLang.Tag = lang;
                menuLang.IsChecked = lang.Equals(currLang);
                menuLang.Click += ChangeLanguageClick;
                Main_menu.Items.Add(menuLang);
            }

            List<string> styles = new List<string> { "light", "dark" };
            styleBox.SelectionChanged += ThemeChange;
            styleBox.ItemsSource = styles;
            styleBox.SelectedItem = "dark";
        }

        private void AddRecordInCollection_Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                this.bookCollectionHistory.History.Push(collectionBook.SaveState());
                var addInCollection = new AddInCollection(collectionBook, NewBookStore);
                this.undoRedo.SaveLastCommand(addInCollection);
                this.invoker.SetOnStart(addInCollection);
                this.invoker.Do();

                //TODO: Maybe replace this part in another function
                //foreach(var ctl in AddRecord_grid.Children)
                //{
                //    if (ctl.GetType() == typeof(TextBox))
                //        ((TextBox)ctl).Text = String.Empty;
                //}
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }

        }

        private void ThemeChange(object sender, SelectionChangedEventArgs e)
        {
            string style = styleBox.SelectedItem as string;
            // определяем путь к файлу ресурсов
            var uri = new Uri(style + ".xaml", UriKind.Relative);
            // загружаем словарь ресурсов
            ResourceDictionary resourceDict = Application.LoadComponent(uri) as ResourceDictionary;
            // очищаем коллекцию ресурсов приложения
            Application.Current.Resources.Clear();
            // добавляем загруженный словарь ресурсов
            Application.Current.Resources.MergedDictionaries.Add(resourceDict);
        }

        private void AboutProgram_menuItem_Click(object sender, RoutedEventArgs e)
        {
            string info =
            $@"Program: Library shops
            Developed by: Alisevich Daniil
            Version: alpha 0.1";
            MessageBox.Show(info, "About");
        }

        private void LoadImage_button_Click(object sender, RoutedEventArgs e)
        {
            this.invoker.SetOnStart(new LoadImage(NewBookStore));
            this.invoker.Do();
            ImagePath_textBox.Text = NewBookStore.ImagePath;
        }

        private void AddBookInCollection_Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                //this.invoker.SetOnStart(new AddInCollection(collectionBook, NewBookStore));
                //this.invoker.Do();
                this.bookCollectionHistory.History.Push(collectionBook.SaveState());
                var addInCollection = new AddInCollection(collectionBook, NewBookStore);
                this.undoRedo.SaveLastCommand(addInCollection);
                this.invoker.SetOnStart(addInCollection);
                this.invoker.Do();

            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
            finally
            {
                TitleInput_textBox.Text = "";
                AuthorInput_textBox.Text = "";
                PagesInput_textBox.Text = "";
                JenreInput_textBox.Text = "";
                PublisherInput_textBox.Text = "";
                PriceInput_textBox.Text = "";
                DescriptionInput_textBox.Text = "";
            }
        }

        private void ShowBookData(object sender, RoutedEventArgs e)
        {
            this.invoker.SetOnStart(new ShowBookData(sender));
            this.invoker.Do();
        }

        private void SaveToJson_button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (collectionBook.GetCollection().Count != 0)
                {
                    collectionBook.SerializeToJSON("D:/Лабы/ООП/LibraryStore/JSON/Json.json");
                    MessageBox.Show("Serialization Complete!");
                }
                else
                {
                    MessageBox.Show("Collection must be filled by data");
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }

        }

        private void LoadFromJson_button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                collectionBook.DeserializeJSON("D:/Лабы/ООП/LibraryStore/JSON/Json.json");
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void LanguageChanged(Object sender, EventArgs e)
        {
            CultureInfo currLang = App.Language;

            //Отмечаем нужный пункт смены языка как выбранный язык
            foreach (MenuItem i in Main_menu.Items)
            {
                CultureInfo ci = i.Tag as CultureInfo;
                i.IsChecked = ci != null && ci.Equals(currLang);
            }
        }

        private void ChangeLanguageClick(Object sender, EventArgs e)
        {
            MenuItem mi = sender as MenuItem;
            if (mi != null)
            {
                CultureInfo lang = mi.Tag as CultureInfo;
                if (lang != null)
                {
                    App.Language = lang;
                }
            }
        }

        private void Search_button_Click(object sender, RoutedEventArgs e)
        {
            this.invoker.SetOnStart(new Search(TitleSearch_textBox.Text, JenreNameSearch_textBox.Text));
            this.invoker.Do();
        }

        private void RedoLastCommand_menuItem_Click(object sender, RoutedEventArgs e)
        {
            this.undoRedo.RedoLastCommand();
        }

        private void UndoLastCommand_button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                collectionBook.ResotreState(bookCollectionHistory.History.Pop());
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void Lab_9_click(object sender, RoutedEventArgs e)
        {
            var window = new Lab_9_Window();
            window.Show();
        }

        private void customControl_Click(object sender, RoutedEventArgs e)
        {
            txtBlock.Text = "You have just click your custom control";
        }
    }
}
