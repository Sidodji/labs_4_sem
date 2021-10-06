using System;
using System.Windows;
using System.Data.SqlClient;
using System.Configuration;
using System.IO;


namespace Lab10.DataBase
{
    public class DatabaseConnection
    {
        public SqlConnection connection;

        public DatabaseConnection()
        {
            StartConnection();
        }


        public void StartConnection()
        {

            connection = new SqlConnection();
            connection.ConnectionString = "Data Source=;Initial Catalog=Lab10;" +
                    "Integrated Security=True;Connect Timeout=30;Encrypt=False;" +
                    "TrustServerCertificate=False;ApplicationIntent=ReadWrite;" +
                    "MultiSubnetFailover=False";

            //if (!CheckConnection(connection))
            //{
            //    CreateDatabase();
            //}
        }



    }
}