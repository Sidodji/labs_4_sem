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
    public class PUBLISHER
    {
        public static ObservableCollection<PUBLISHER> Publishers = new ObservableCollection<PUBLISHER>();
        public int id { get; set; }
        public string name { get; set; }
     

        public PUBLISHER(object id, object name)
        {
            if(Convert.ToInt32(id)!=0)
            {
                this.id = Convert.ToInt32(id);
                this.name = Convert.ToString(name);
                Publishers.Add(this);
            }
            else
            {
                this.id = Convert.ToInt32(id);
                this.name = Convert.ToString(name);
            }
           
        }

        public void CommitChanges()
        {
            string sql = $"update PUBLISHER set name = '{this.name}' where id = {this.id}";
            DB_Control.ExecuteCommand(sql);
        }

        public void AddNewPublisher()
        {
            string sql = $"insert PUBLISHER(id, name) values ({PUBLISHER.Publishers.Count + 1}, {name})";
            DB_Control.ExecuteCommand(sql);
        }
    }
}
