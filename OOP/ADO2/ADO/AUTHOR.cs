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
    public class AUTHOR  {
        public static ObservableCollection<AUTHOR> Authors = new ObservableCollection<AUTHOR>();
        public int id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }

        public AUTHOR(object id, object fn, object ln)
        {
            if(Convert.ToInt32(id)!=0)
            {
                this.id = Convert.ToInt32(id);
                this.firstName = Convert.ToString(fn);
                this.lastName = Convert.ToString(ln);
                AUTHOR.Authors.Add(this);
            }
            else
            {
                this.id = Convert.ToInt32(id);
                this.firstName = Convert.ToString(fn);
                this.lastName = Convert.ToString(ln);
            }
            
        }

        public void CommitChanges()
        {
            using (SqlConnection connection = DB_Control.GetConnection())
            {

                try
                {
                    //запрос с параметрами
                    connection.Open();
                    SqlParameter firstNameParam = new SqlParameter("@first_name", firstName);
                    SqlParameter lastNameParam = new SqlParameter("@last_name", lastName);
                    string sql = $"update AUTHOR set first_name= @first_name, last_name =@last_name where id = {this.id}";
                    SqlCommand command = new SqlCommand(sql, connection);
                    command.Parameters.Add(firstNameParam);
                    command.Parameters.Add(lastNameParam);
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                catch (SqlException exception)
                {
                    MessageBox.Show(exception.Message);
                }

            }
        }

        public void AddNewAuthor()
        {
            string sql = $"insert AUTHOR(id, first_name, last_name) values ({AUTHOR.Authors.Count + 1}, {firstName}, '{lastName}');";
            DB_Control.ExecuteCommand(sql);
        }
    }

}
