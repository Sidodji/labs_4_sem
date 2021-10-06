using System;
using System.ComponentModel;

namespace Lab10.ViewModel
{
    public class BaseViewModel : INotifyPropertyChanged
    {

        public string ViewModelName { get; private set; }

        protected void SetViewModelName(string viewModelName)
        {
            ViewModelName = viewModelName;
        }

        #region INotifyPropertyChanged Members
        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        #endregion
    }
}