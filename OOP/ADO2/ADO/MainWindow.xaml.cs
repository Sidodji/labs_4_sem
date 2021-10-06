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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data.SqlClient;
using System.Configuration;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Data;
using System.IO;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;

namespace ADO
{
    public class CurrentContext
    {
        public int CurrentStateIndex = 0;

        public void AlertCurrent()
        {
            MessageBox.Show(Convert.ToString(BOOK.Books[CurrentStateIndex].title));
        }
        public void SetContext(Grid grid)
        {
            //
            if (BOOK.Books.Count == 0)
            {
                BOOK.Books.Add(new BOOK());
            }
            grid.DataContext = BOOK.Books[CurrentStateIndex];

            //if (BOOK.Books.Count != 0)
            //{
            //    grid.DataContext = BOOK.Books[CurrentStateIndex];
            //}
            //else
            //{
            //    grid.DataContext = new BOOK();
            //}          

        }
        public void MinusIndex()
        {   
             CurrentStateIndex--;     
        }
        public void MakeCurrentIndexNull()
        {
            CurrentStateIndex = 0;
        }
        public void MakeCurrentIndexMax()
        {
            CurrentStateIndex = BOOK.Books.Count-1;
        }
        public void PlusIndex()
        {
            CurrentStateIndex++;
        }
        public bool ifCanPrev()
        {
            if (CurrentStateIndex != 0)
                return true;
            else return false;
        }
        public bool ifCanNext()
        {
            if (CurrentStateIndex < BOOK.Books.Count-1)
                return true;
            else return false;
        }
        public void ClearPage()
        {
            BOOK.Books.Clear();
            AUTHOR.Authors.Clear();
            PUBLISHER.Publishers.Clear();
        }
    }


    public partial class MainWindow : Window
    {
        public CurrentContext CurrentOBJ;

        void ParseDataBase()
        {
            using (SqlConnection connection = DB_Control.GetConnection())
            {
                try
                {
                    string sql = "select * from AUTHOR; select * from PUBLISHER; select * from BOOK;";
                    SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                    DataSet ds = new DataSet();
                    adapter.Fill(ds);
                    List<object> list = new List<object>();

                 
                    foreach (DataRow row in ds.Tables[0].Rows)
                    {
                        foreach (object col in row.ItemArray)
                            list.Add(col);
                        new AUTHOR(list[0], list[1], list[2]);
                        list.Clear();
                    }

                    foreach (DataRow row in ds.Tables[1].Rows)
                    {
                        foreach (object col in row.ItemArray)
                            list.Add(col);
                        new PUBLISHER(list[0], list[1]);
                        list.Clear();
                    }
                    
                    //if(ds.Tables[2].Rows.Count!=0)
                    //{
                    foreach (DataRow row in ds.Tables[2].Rows)
                    {

                        foreach (object col in row.ItemArray)
                            list.Add(col);
                        new BOOK(list[0], list[2], list[1], list[3], list[4]);
                        list.Clear();
                    }
                    //}
                    //else
                    //{
                    //    new BOOK();
                    //}

                    CurrentOBJ.SetContext(ComputerViewer);
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message + "\n" + e.StackTrace);
                }
            }
        }

        public MainWindow()
        {
            InitializeComponent();
            //для работы процедуры после создания БД требуется создать процедуру в БД 
            try
            {
                MyProcedure();
            }
            catch
            {
                MessageBox.Show("Добавьте процедуру вручную в БД");
            }
            CurrentOBJ = new CurrentContext();

            ParseDataBase();
        }

        private void PrevButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (CurrentOBJ.ifCanPrev())
                {
                    CurrentOBJ.MinusIndex();
                    CurrentOBJ.SetContext(ComputerViewer);
                }
                else
                {
                    CurrentOBJ.MakeCurrentIndexMax();
                    CurrentOBJ.SetContext(ComputerViewer);
                }
            }
            catch { }
           
        }

        private void NextButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (CurrentOBJ.ifCanNext())
                {
                    CurrentOBJ.PlusIndex();
                    CurrentOBJ.SetContext(ComputerViewer);
                }
                else
                {
                    CurrentOBJ.MakeCurrentIndexNull();
                    CurrentOBJ.SetContext(ComputerViewer);
                }
            }
            catch { }
           
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            
            if (BOOK.Books.ElementAtOrDefault(0) == null)
            {
                MessageBox.Show("Книг нет");
            }
            else
                BOOK.Books[CurrentOBJ.CurrentStateIndex].CommitWholeOBJ(); //Транзакция

        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            BOOK.Books[CurrentOBJ.CurrentStateIndex].AddBook(CurrentOBJ.CurrentStateIndex);
            CurrentOBJ.ClearPage();
            CurrentOBJ.MakeCurrentIndexNull();
            ParseDataBase();
        }

      
        

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            if(BOOK.Books.ElementAtOrDefault(0) == null)
            {
                MessageBox.Show("0 книг");
            }
            else
            {
                BOOK.Books[CurrentOBJ.CurrentStateIndex].DeleteFromDB();
                CurrentOBJ.ClearPage();
                CurrentOBJ.MakeCurrentIndexNull();
                ParseDataBase();
            }
        }

        public void MyProcedure()
        {
            using (SqlConnection connection = DB_Control.GetConnection())
            {
                string Procedure = "ShowBook";
                
                connection.Open();
                SqlCommand command = new SqlCommand(Procedure, connection);
                // указываем, что команда представляет хранимую процедуру
                command.CommandType = System.Data.CommandType.StoredProcedure;
                var reader = command.ExecuteReader();

                string result = "";

                result += reader.GetName(0) + "\t\t" + reader.GetName(1) + "\n";

                while (reader.Read())
                {
                    result += reader.GetString(1) + "\t\t";
                    result += reader.GetString(0) + "\n";
                }

                MessageBox.Show(result);
                reader.Close();
            }
        }
    }
}
