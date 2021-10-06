using System;
using System.Windows;
using System.Windows.Controls;
using System.Collections.ObjectModel;

using Microsoft.Win32;
using System.Windows.Media;
using System.Windows.Media.Imaging;

using VinylShop.Entity;
using VinylShop.SecondaryWindows;
using VinylShop.Command;
using System.Globalization;

namespace VinylShop
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        CollectionStorage storage;
        Invoker invoker;
        VinylRecord NewVinylRecord { get; set; }

        public MainWindow()
        {
            InitializeComponent();

            this.invoker = new Invoker();
            storage = CollectionStorage.GetInstance();
            NewVinylRecord = new VinylRecord();

            AddRecord_grid.DataContext = NewVinylRecord;
            recordsDataGrid.ItemsSource = storage.GetCollection();

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
        }

        private void AddRecordInCollection_Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                this.invoker.SetOnStart(new AddInCollection(storage, NewVinylRecord));
                this.invoker.Do();

                //TODO: Maybe replace this part in another function
                foreach(var ctl in AddRecord_grid.Children)
                {
                    if (ctl.GetType() == typeof(TextBox))
                        ((TextBox)ctl).Text = String.Empty;
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }

        }

        private void ShowRecordData(object sender, RoutedEventArgs e)
        {
            this.invoker.SetOnStart(new ShowItemData(sender));
            this.invoker.Do();
        }

        #region Useless function
        //private DateTime? ConvertDurationToDateTime(string duration)
        //{
        //    if(duration == "")
        //    {
        //        return null;
        //    }

        //    string[] recordDuration = new string[2];
        //    int i = 0;
        //    foreach (var item in duration.Split(new char[] { ':' }))
        //    {
        //        recordDuration[i++] = item;
        //    }
        //    return new DateTime(0, 0, 0, 0, Convert.ToInt32(recordDuration[0]), Convert.ToInt32(recordDuration[1]));
        //}
        #endregion

        private void SaveToJson_button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (storage.GetCollection().Count != 0)
                {
                    storage.SerializeToJSON("data/json/RecordsData.json");
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
                storage.DeserializeJSON("data/json/RecordsData.json");
            } 
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void LoadImage_button_Click(object sender, RoutedEventArgs e)
        {
            this.invoker.SetOnStart(new LoadImage(NewVinylRecord));
            this.invoker.Do();
            ImagePath_textBox.Text = NewVinylRecord.ImagePath;
        }

        private void Search_button_Click(object sender, RoutedEventArgs e)
        {
            this.invoker.SetOnStart(new SearchByParameters(NameSearch_textBox.Text, float.Parse(FromPriceSearch_textBox.Text), float.Parse(ToPriceSearch_textBox.Text), ArtistNameSearch_textBox.Text, LableSearch_textBox.Text));
            this.invoker.Do();
        }

        private void AboutProgram_menuItem_Click(object sender, RoutedEventArgs e)
        {
            string info = 
                $@"Program: Vinyl Shop
Developed by: Guz Yaroslav
Version: alpha 0.1";
            MessageBox.Show(info, "About");
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
    }
}
