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

using VinylShop.Entity;
using VinylShop.Command;

namespace VinylShop.SecondaryWindows
{
    /// <summary>
    /// Interaction logic for EditCurrentRecord.xaml
    /// </summary>
    public partial class EditCurrentRecord : Window
    {
        Invoker invoker;
        VinylRecord CurrentVinylRecord { get; set; }

        public EditCurrentRecord()
        {
            InitializeComponent();
        }

        public EditCurrentRecord(VinylRecord vinylRecord)
        {
            InitializeComponent();

            this.CurrentVinylRecord = vinylRecord;
            this.invoker = new Invoker();

            AddRecord_stackPanel.DataContext = this.CurrentVinylRecord;
        }

        private void SaveChanges_Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void LoadImage_button_Click(object sender, RoutedEventArgs e)
        {
            this.invoker.SetOnStart(new LoadImage(this.CurrentVinylRecord));
            this.invoker.Do();
        }
    }
}
