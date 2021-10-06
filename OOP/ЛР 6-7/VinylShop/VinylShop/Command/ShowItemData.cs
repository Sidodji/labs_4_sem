using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows;
using System.Windows.Controls;

using VinylShop.SecondaryWindows;
using VinylShop.Entity;

namespace VinylShop.Command
{
    class ShowItemData : ICommand
    {
        DataGridRow row;
        public ShowItemData(object button)
        {
            var buttonTemp = (FrameworkElement)button;
            this.row = (DataGridRow)buttonTemp.Tag;
        }
        public void Execute()
        {
            var window = new RecordInfo((VinylRecord)row.Item);
            window.Show();
        }
    }
}
