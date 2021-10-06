using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace LibraryStore.Lab9
{
    public class Student : DependencyObject
    {
        public static readonly DependencyProperty NameProperty;
        public static readonly DependencyProperty YearProperty;

        static Student()
        {
            // Регистрация свойства
            NameProperty = DependencyProperty.Register("Title", typeof(string), typeof(Student));

            FrameworkPropertyMetadata metadata = new FrameworkPropertyMetadata();
            metadata.CoerceValueCallback = new CoerceValueCallback(CorrectValue);

            YearProperty = DependencyProperty.Register("Price", typeof(int), typeof(Student),
                metadata, new ValidateValueCallback(ValidateValue));
        }
        // Обертка
        public string Name
        {
            get { return (string)GetValue(NameProperty); }
            set { SetValue(NameProperty, value); }
        }

        public int Year
        {
            get { return (int)GetValue(YearProperty); }
            set { SetValue(YearProperty, value); }
        }
        //валидация свойств
        private static bool ValidateValue(object value)
        {
            int currentValue = (int)value;
            if (currentValue >= 0)
                return true;
            return false;
        }
        //проверяем на корректое значение свойств
        private static object CorrectValue(DependencyObject d, object baseValue)
        {
            int currentValue = (int)baseValue;
            if (currentValue > 100)
                return 100;
            return currentValue;
        }
    }
}
