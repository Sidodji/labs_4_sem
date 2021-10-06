using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;

namespace VinylShop.Entity
{
    [Serializable]
    public class VinylRecord : INotifyPropertyChanged
    {
        [field:NonSerialized]
        public event PropertyChangedEventHandler PropertyChanged;

        private string name;
        private string artist;
        private string jenre;
        private string lable;
        private string country;
        private DateTime? duration;
        private int? rating;
        private string description;
        private float? price;
        private DateTime? releaseDate;
        private int? quantity;
        private string imagePath;

        #region Properties
        public string Name 
        { 
            get
            {
                return name;
            }
            set
            {
                this.name = value;
                OnPropertyChanged("Name");
            }
        }

        public string Artist 
        { 
            get
            {
                return artist;
            }
            set
            {
                this.artist = value;
                OnPropertyChanged("Artist");
            }
        }

        public string Jenre 
        { 
            get
            {
                return jenre;
            }
            set
            {
                this.jenre = value;
                OnPropertyChanged("Jenre");
            }
        }

        public string Lable 
        { 
            get
            {
                return lable;
            }
            set
            {
                this.lable = value;
                OnPropertyChanged("Lable");
            }
        }

        public string Country 
        { 
            get
            {
                return country;
            }
            set
            {
                this.country = value;
                OnPropertyChanged("Country");
            }
        }

        public DateTime? Duration
        {
            get
            {
                return duration;
            }
            set
            {
                this.duration = value;
                OnPropertyChanged("Duration");
            }
        }

        public int? Rating 
        {
            get
            {
                return rating;
            }
            set
            {
                this.rating = value;
                OnPropertyChanged("Rating");
            }
        }

        public string Description 
        { 
            get
            {
                return description;
            }
            set
            {
                this.description = value;
                OnPropertyChanged("Description");
            }
        }

        public float? Price 
        { 
            get
            {
                return price;
            }
            set
            {
                this.price = value;
                OnPropertyChanged("Price");
            }
        }

        public DateTime? ReleaseDate 
        { 
            get
            {
                return releaseDate;
            }
            set
            {
                this.releaseDate = value;
                OnPropertyChanged("ReleaseDate");
            }
        }

        public int? Quantity 
        { 
            get
            {
                return quantity;
            }
            set
            {
                this.quantity = value;
                OnPropertyChanged("Quantity");
            }
        }

        public string ImagePath 
        {
            get { return imagePath; } 
            set
            {
                imagePath = value;
                OnPropertyChanged("ImagePath");
            }
        }
        #endregion

        public VinylRecord DeepCopy()
        {
            VinylRecord clone = (VinylRecord)this.MemberwiseClone();
            
            clone.Name = this.Name;
            clone.Artist = this.Artist;
            clone.Jenre = this.Jenre;
            clone.Lable = this.Lable;
            clone.Country = this.Country;
            clone.Duration = this?.Duration;
            clone.Rating = this.Rating;
            clone.Description = this.Description;
            clone.Price = this.Price;
            clone.ReleaseDate = this?.ReleaseDate;
            clone.Quantity = this.Quantity;
            clone.ImagePath = this.ImagePath;

            return clone;
        }

        public VinylRecord ShallowCopy()
        {
            return (VinylRecord)this.MemberwiseClone();
        }

        public void OnPropertyChanged([CallerMemberName]string prop = "")
        {
            if(PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
            }
        }
    }
}
