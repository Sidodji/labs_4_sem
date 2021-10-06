using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    public class BOOK
    {
        public static ObservableCollection<BOOK> Books = new ObservableCollection<BOOK>();
        public PUBLISHER publisher { get; set; }
        public AUTHOR author { get; set; }
        public int id { get; set; }
        int publisher_key { get; set; }
        int author_key { get; set; }
        public string title { get; set; }
        public string photo { get; set; }
        public BOOK() 
        {
            id = 0;
            publisher = new PUBLISHER(0,"");
            author = new AUTHOR(0,"","");
        }

        public BOOK(object id, object publisher_key, object author_key, object title, object photo)
        {

            this.id = Convert.ToInt32(id);
            this.publisher_key = Convert.ToInt32(publisher_key);
            this.author_key = Convert.ToInt32(author_key);
            this.title = Convert.ToString(title);
            this.photo = Convert.ToString(photo);

            foreach (AUTHOR author in AUTHOR.Authors)
                if (this.author_key == author.id)
                    this.author = author;

            foreach (PUBLISHER publisher in PUBLISHER.Publishers)
                if (this.publisher_key == publisher.id)
                    this.publisher = publisher;

            Books.Add(this);
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public static string ShowInfo()
        {
            string result = "";
            foreach (BOOK book in BOOK.Books)
                result += book.ToString() + "\n";

            return result;
        }


        public void CommitWholeOBJ()
        {
            using (SqlConnection connection = DB_Control.GetConnection())
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();

                SqlCommand command = connection.CreateCommand();
                command.Transaction = transaction;

                string SQL_AUTH = $"update AUTHOR set first_name = '{author.firstName}', last_name = '{author.lastName}' where id = {author.id}";
                string SQL_PB = $"update PUBLISHER set name = '{publisher.name}' where id = {publisher.id}";
                string SQL_BOOK = $" update BOOK set title = '{title}', photo = '{photo}' where id = {id}";

                try
                {
                    // выполняем две отдельные команды
                    command.CommandText = SQL_AUTH;
                    command.ExecuteNonQuery();
                    command.CommandText = SQL_PB;
                    command.ExecuteNonQuery();
                    command.CommandText = SQL_BOOK;
                    command.ExecuteNonQuery();
                   
                    // подтверждаем транзакцию
                    transaction.Commit();
                    MessageBox.Show("Изменения зафиксированы в БД");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    transaction.Rollback();
                }
            }
        }

        //транзакция
        public void AddBook(int CurrentStateIndex)
        {
            using (SqlConnection connection = DB_Control.GetConnection())
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();

                SqlCommand command = connection.CreateCommand();
                command.Transaction = transaction;

                try
                {
                    string SQL_BOOK = $"insert BOOK(id, author_key, publisher_key, title, photo) values ({BOOK.Books[CurrentStateIndex].id}, {AUTHOR.Authors.Count + 1}, {PUBLISHER.Publishers.Count + 1},'{title}', '{photo}')";
                    string SQL_AUTH = $"insert AUTHOR(id, first_name, last_name) values ({AUTHOR.Authors.Count + 1}, '{author.firstName}', '{author.lastName}');";
                    string SQL_PB = $"insert PUBLISHER(id, name) values ({PUBLISHER.Publishers.Count + 1}, '{publisher.name}')";
                    //if (BOOK.Books.Count == 1 && BOOK.Books[0].id==0)
                    //{
                    //    SQL_BOOK = $"insert BOOK(id, author_key, publisher_key, title, photo) values ({1}, {AUTHOR.Authors.Count + 1}, {PUBLISHER.Publishers.Count + 1},'{title}', '{photo}')";
                    //}
                    //else
                    //{
                        
                    //}
                    

                    // выполняем три отдельные команды
                    command.CommandText = SQL_AUTH;
                    command.ExecuteNonQuery();
                    command.CommandText = SQL_PB;
                    command.ExecuteNonQuery();
                    command.CommandText = SQL_BOOK;
                    command.ExecuteNonQuery();

                    // подтверждаем транзакцию
                    transaction.Commit();
                    MessageBox.Show("Новый объект добавлен в БД");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    transaction.Rollback();
                }
            }

        }

        
        public void DeleteFromDB()
        {
            using (SqlConnection connection = DB_Control.GetConnection())
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();

                SqlCommand command = connection.CreateCommand();
                command.Transaction = transaction;

                //string SQL_AUTH = $"delete from AUTHOR where AUTHOR.id = {author_key}";
                //string SQL_PB = $"delete from PUBLISHER where PUBLISHER.id = {publisher_key}";
                string SQL_BOOK = $"delete from BOOK where BOOK.id = {id};";
                string SQL_CHO = $"select count(*) from BOOK";
                

                try
                {
                    // выполняем две отдельные команды
                    //command.CommandText = SQL_AUTH;
                    //command.ExecuteNonQuery();
                    //command.CommandText = SQL_PB;
                    //command.ExecuteNonQuery();
                   
                    command.CommandText = SQL_BOOK;
                    command.ExecuteNonQuery();
                    transaction.Commit();
                    MessageBox.Show("Объект удален из бд");
                  
                                        
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    transaction.Rollback();
                }
            }
        }

        public void CommitChanges()
        {            
            string sql = $" update BOOK set title= '{this.title}', photo = '{this.photo}' where id = {this.id}";
            DB_Control.ExecuteCommand(sql);
        }
       
    }
}
