using lab_13.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace lab_13.ViewModel
{
    public class CourseViewModel : INotifyPropertyChanged
    {
        private Сourses course;

        public CourseViewModel(Сourses cour)
        {
            course = cour;
        }

        public string NameCourse
        {
            get { return course.NameCourse; }
            set
            {
                course.NameCourse = value;
                OnPropertyChanged("NameCourse");
            }
        }

        public int SCountHour
        {
            get { return course.CountHour; }
            set
            {
                course.CountHour = value;
                OnPropertyChanged("CountHour");
            }
        }


        public int StudNum
        {
            get { return course.StudNum; }
            set
            {
                course.StudNum = value;
                OnPropertyChanged("StudNum");
            }
        }

        public int MaxStudNum
        {
            get { return course.MaxStudNum; }
            set
            {
                course.MaxStudNum = value;
                OnPropertyChanged("MaxStudNum");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
