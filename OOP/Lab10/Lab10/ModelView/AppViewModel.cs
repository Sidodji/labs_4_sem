using System;

using Lab10.Model;


namespace Lab10.ViewModel
{
    public class AppViewModel : BaseViewModel
    {
        public AppViewModel()
        {
            Book = new Book();
        }


        #region Fields/Properties
        private Book _book;
        
        public Book Book{ get; set; }
        #endregion



    }
}