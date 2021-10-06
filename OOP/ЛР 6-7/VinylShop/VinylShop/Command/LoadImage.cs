using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

using VinylShop.Entity;

namespace VinylShop.Command
{
    class LoadImage : ICommand
    {
        VinylRecord vinylRecord;

        public LoadImage(VinylRecord vinylRecord)
        {
            this.vinylRecord = vinylRecord;
        }

        public void Execute()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            vinylRecord.ImagePath = ofd.FileName;
        }
    }
}
