using lab_13.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Data.Entity;
using lab_13.Commands;

namespace lab_13.ViewModel
{
    class ApplicationViewModel : INotifyPropertyChanged
    {
        private Сourses selectedCourse;
        public ObservableCollection<Сourses> Courses { get; set; }
        //public ObservableCollection<Lecturer2> Lecturers { get; set; }

        // команда добавления нового объекта
        private RelayCommand recordingCommand;
        private RelayCommand cancelCommand;

        private static int maxStudNum = 0;



        public RelayCommand RecordingCommand
        {
            get
            {   
                return recordingCommand ??
                  (recordingCommand = new RelayCommand(obj =>
                  {
                      using (Lab13_Context db = new Lab13_Context())
                      {
                          Сourses course = db.Courses.Where(cour => cour.NameCourse == SelectedCourse.NameCourse).FirstOrDefault();
                          if (course != null)
                          {
                              course.StudNum -= 1;
                              db.SaveChanges();

                              db.Courses.Load();
                              Courses.Clear();
                              foreach (var item in db.Courses.Local)
                              {
                                  Courses.Add(item);
                              }
                              SelectedCourse = db.Courses.FirstOrDefault();
                          }
                          else
                              MessageBox.Show("Проблема");
                      }
                  },
                  (obj) => SelectedCourse.StudNum > 0));
            }
        }

        public RelayCommand CancelCommand
        {
            get
            {
                return cancelCommand ??
                  (cancelCommand = new RelayCommand(obj =>
                  {
                      using (Lab13_Context db = new Lab13_Context())
                      {
                          Сourses course = db.Courses.Where(cour => cour.NameCourse== SelectedCourse.NameCourse).FirstOrDefault();
                          if (course != null)
                          {
                              maxStudNum = course.MaxStudNum;

                              course.StudNum += 1;
                              db.SaveChanges();


                              db.Courses.Load();
                              Courses.Clear();
                              foreach (var item in db.Courses.Local)
                              {
                                  Courses.Add(item);
                              }
                              SelectedCourse = db.Courses.FirstOrDefault();
                          }
                      }
                  },
                  obj =>
                  {
                      using (Lab13_Context db = new Lab13_Context())
                      {
                          Сourses course = db.Courses.Where(cour => cour.NameCourse == SelectedCourse.NameCourse).FirstOrDefault();
                          if (course != null)
                          {
                              maxStudNum = course.MaxStudNum;
                          }

                      }
                      return SelectedCourse.StudNum < maxStudNum;
                  }));
            }
        }

        public Сourses SelectedCourse
        {
            get { return selectedCourse; }
            set
            {
                selectedCourse = value;
                OnPropertyChanged("SelectedCourse");
            }
        }

        public ApplicationViewModel()
        {
            using (Lab13_Context db = new Lab13_Context())
            {
                
                db.Courses.Load();
                
                Courses = new ObservableCollection<Сourses>();
                foreach (var item in db.Courses.Local)
                {
                    Courses.Add(item);
                }
                SelectedCourse = db.Courses.FirstOrDefault();
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
