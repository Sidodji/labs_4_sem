using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using LibraryStore.Lab9;



namespace LibraryStore
{
    /// <summary>
    /// Логика взаимодействия для Lab_9_Window.xaml
    /// </summary>
    public partial class Lab_9_Window : Window
    {
        public Lab_9_Window()
        {
            InitializeComponent();

            Student = new Student();

            Student.Name = "Chel";
            Student.Year = 25;

            this.DataContext = Student;

            CommandBinding customCommandBinding = new CommandBinding(CustomRoutedCommand, ExecutedCustomCommand, CanExecuteCustomCommand);
            this.CommandBindings.Add(customCommandBinding);
        }

        public Student Student { get; set; }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Student student = this.Student;
            MessageBox.Show(student.Year.ToString());
        }

        public static RoutedUICommand CustomRoutedCommand = new RoutedUICommand();

        private void ExecutedCustomCommand(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBox.Show("Custom UI Command Executed");
        }

        private void CanExecuteCustomCommand(object sender, CanExecuteRoutedEventArgs e)
        {
            Control target = (Control)e.Source ;

            if (target != null)
            {
                e.CanExecute = true;
            }
            else
            {
                e.CanExecute = false;
            }
        }

        //поднимающееся
        private void Control_MouseDown(object sender, MouseButtonEventArgs e)
        {
            textBlock1.Text = textBlock1.Text + "sender: " + sender.ToString() + "\n";
            textBlock1.Text = textBlock1.Text + "source: " + e.Source.ToString() + "\n\n";
        }

        //тунельный
        private void Control_MouseDown_2(object sender, MouseButtonEventArgs e)
        {
            textBlock2.Text = textBlock2.Text + "sender: " + sender.ToString() + "\n";
            textBlock2.Text = textBlock2.Text + "source: " + e.Source.ToString() + "\n\n";
        }

        


    }

    
}
