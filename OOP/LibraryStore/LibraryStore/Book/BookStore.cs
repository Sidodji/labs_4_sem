using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;


namespace LibraryStore.Book
{
    [Serializable]
    public class BookStore : INotifyPropertyChanged
    {
        [field: NonSerialized]
        public event PropertyChangedEventHandler PropertyChanged;

        private string title;
        private string jenre;
        private int  pages;
        private string publisher;
        private string author;
        private string description;
        private string imagePath;
        private int price;
        //private int? rating;


        #region Prorepties
        public string Title
        {
            get
            { 
                return title;
            }
            set { 
                this.title = value;
                OnPropertyChanged("Title"); 
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

        

        public string Publisher
        {
            get
            {
                return publisher;
            }
            set
            {
                this.publisher= value;
                OnPropertyChanged("publisher");
            }
        }

        public string Author
        {
            get
            {
                return author;
            }
            set
            {
                this.author = value;
                OnPropertyChanged("Author");
            }
        }

        public string ImagePath
        {
            get
            {
                return imagePath;
            }
            set
            {
                this.imagePath = value;
                OnPropertyChanged("ImagePath");
            }
        }

        public int Price
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

        public int Pages
        {
            get
            {
                return pages;
            }
            set
            {
                this.pages = value;
                OnPropertyChanged("Pages");
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

        /*public int? Rating
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
        }*/

        #endregion

        public BookStore DeepCopy()
        {
            BookStore clone = (BookStore)this.MemberwiseClone();

            clone.Title = this.Title;
            clone.Publisher = this.Publisher;
            clone.Price = this.Price;
            clone.Pages = this.Pages;
            clone.Author = this.Author;
            clone.Description = this.Description;
            clone.Jenre = this.Jenre;
            clone.ImagePath = this.ImagePath;
            //clone.Rating = this.Rating;


            return clone;
        }

        public BookStore ShallowCopy()
        {
            return (BookStore)this.MemberwiseClone();
        }

        
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
            }
        }
    }
}
