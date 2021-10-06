using System;
using System.Windows;
using System.Data.SqlClient;
using System.Configuration;
using System.IO;


namespace Lab10
{
    public static class DBConnect
    {
        public static SqlConnection GetConnection()
        {
            SqlConnection connection;
            try
            {
                connection = SetConnection();
                if (connection != null)
                    return connection;
                else
                {
                    connection = CreateConnection();
                    return connection;
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public static SqlConnection CreateConnection()
        {
            SqlConnection connection;
            try
            {
                //Создать и открыть соединение
                string connectionString = ConfigurationManager.ConnectionStrings["SqlCreate"].ConnectionString;
                connection = new SqlConnection(connectionString);
                connection.Open();

                //Создать БД
                string sql = "use master;create DataBase ADO10;";
                SqlCommand command = new SqlCommand(sql, connection);
                command.ExecuteNonQuery();

                //Сформировать скрипт для заполнения БД
                sql = "";
                StreamReader reader = new StreamReader("D:/Labs/OOP/Lab10/Lab10/script.sql");
                while (!reader.EndOfStream)
                    sql += reader.ReadLine();

                //Выполнить скрипт
                command = new SqlCommand(sql, connection);
                command.ExecuteNonQuery();

                MessageBox.Show("Создана новая база данных");

                return connection;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }

        }

        public static SqlConnection SetConnection()
        {
            SqlConnection connection;
            try
            {
                string connectionString = ConfigurationManager.ConnectionStrings["SqlConnection"].ConnectionString;
                connection = new SqlConnection(connectionString);
                connection.Open();
                connection.Close();
                return connection;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                connection = CreateConnection();
                return connection;
            }
        }



        public static void ExecuteCommand(string SqlQuerry)
        {
            using (SqlConnection connection = GetConnection())
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(SqlQuerry, connection);
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                catch (SqlException exception)
                {
                    MessageBox.Show(exception.Message);
                }

            }
        }
    }
}
