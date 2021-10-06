using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using VinylShop.Entity;

namespace VinylShop.Command
{
    class SearchByParameters : ICommand
    {
        private string searchName;
        private string searchArtistName;
        private string searchLable;

        private float fromPrice;
        private float toPrice;

        public SearchByParameters(string searchName, float fromPrice, float toPrice, string searchArtistName, string searchLable) 
        {
            this.searchName = searchName;
            this.fromPrice = fromPrice;
            this.toPrice = toPrice;
            this.searchArtistName = searchArtistName;
            this.searchLable = searchLable;
        }

        public void Execute()
        {
            CollectionStorage storage = CollectionStorage.GetInstance();
            IEnumerable<VinylRecord> result = storage.GetCollection().ToList<VinylRecord>();

            if(searchName != "")
            {
                result = result.Where(item => item.Name.Contains(searchName)).Select(item => item);
            }
            if(fromPrice >= 0 && toPrice != 0)
            {
                result = result.Where(item => item.Price >= fromPrice && item.Price <= toPrice).Select(item => item);
            }
            if(searchArtistName != "")
            {
                result = result.Where(item => item.Artist.Contains(searchArtistName)).Select(item => item);
            }
            if(searchLable != "")
            {
                result = result.Where(item => item.Lable.Contains(searchLable)).Select(item => item);
            }

            storage.GetCollection().Clear();
            foreach(var item in result)
            {
                storage.GetCollection().Add(item);
            }
        }
    }
}
