using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace VinylShop.SecondaryWindows
{
    /// <summary>
    /// Interaction logic for RecordInfo.xaml
    /// </summary>
    public partial class RecordInfo : Window
    {
        VinylRecord CurrentVinylRecord { get; set; }

        public RecordInfo()
        {
            InitializeComponent();
        }

        public RecordInfo(VinylRecord vinylRecord)
        {
            InitializeComponent();

            this.CurrentVinylRecord = vinylRecord;
            mainGrid.DataContext = CurrentVinylRecord;
        }

        private void EditVinylRecord_button_Click(object sender, RoutedEventArgs e)
        {
            var window = new EditCurrentRecord(CurrentVinylRecord);
            window.Show();
        }
    }
}
