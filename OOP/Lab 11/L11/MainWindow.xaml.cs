using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Numerics;
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
using L11;
using L11.Context;
using L11.Models;
using System.Threading.Tasks;

namespace L11
{
    public partial class MainWindow : Window
    {
        MyDb mdb;
        public MainWindow()
        {
            InitializeComponent();

            //Асихронная работа
            mdb = new MyDb();
            Plane plane  = new Plane { id = 1, model = "Airbus" };
            mdb.Plane.Add(plane);
            mdb.SaveChanges();
            //mdb.SaveChangesAsync();


            Worker worker = new Worker { id = 1, name = "Alex", planeId = 2 };
            ////Worker.addWorker(worker);
            Task t = SaveObjectsAsync(worker);
            
            //workerGrid.ItemsSource = mdb.Worker.Local.ToBindingList();

            this.Closing += MainWindow_Closing;
        }

       

        public  static async Task SaveObjectsAsync(Worker worker)
        {
            using (MyDb mdb = new MyDb())
            {
                mdb.Worker.Add(worker);
                
                await mdb.SaveChangesAsync();
                
            }
        }

        private void MainWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            mdb.Dispose();
        }

        private void updateButton_Click(object sender, RoutedEventArgs e)
        {
            mdb.SaveChanges();
            mdb.Worker.Load();
            workerGrid.ItemsSource = mdb.Worker.Local.ToBindingList();
        }

        private void  deleteButton_Click(object sender, RoutedEventArgs e)
        {
            if (workerGrid.SelectedItems.Count > 0)
            {
                for (int i = 0; i < workerGrid.SelectedItems.Count; i++)
                {
                    Worker worker = workerGrid.SelectedItems[i] as Worker;
                    if (worker != null)
                    {
                        mdb.Worker.Remove(worker);
                    }
                }
            }
            mdb.SaveChanges();
        }

        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            AddWorkerWindow win = new AddWorkerWindow();
            win.ShowDialog();
        }

        //транзакция
        private void  queryButton_Click(object sender, RoutedEventArgs e)
        {
            //Worker.GetNameById(3);

            MyDb wc = new MyDb();
            using (var transaction = wc.Database.BeginTransaction())
            {
                try
                {
                    wc.Database.ExecuteSqlCommand(@"UPDATE Workers SET name = 'TEST TRANSACTION'  WHERE id =1");
                    wc.Plane.Add(new Models.Plane { id = 34, model = "Test Airline" });
                    wc.SaveChangesAsync();
                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                }
            }
        }

        private void updateItemButton_Click(object sender, RoutedEventArgs e)
        {
            if (workerGrid.SelectedItems.Count > 0)
            {
                var worker = workerGrid.SelectedItem as Worker;
                var change = mdb.Worker.Where(c => c.name == worker.name).FirstOrDefault();
                change.name = TextBox_Name.Text;
                mdb.SaveChanges();
            }
            mdb.Worker.Load();
            workerGrid.ItemsSource = mdb.Worker.ToList();
        }

        private void searchButton_Click(object sender, RoutedEventArgs e)
        {
            MyDb wc = new MyDb();

            if (TextBox_Name.Text != "" && TextBox_PlaneId.Text != "")
            {
                int num = Convert.ToInt32(TextBox_PlaneId.Text);
                var result = wc.Worker.Where(p => p.name == TextBox_Name.Text && p.planeId == num);
                StringBuilder str = new StringBuilder();
                foreach (Worker i in result)
                {
                    str.Append(i.id + " " + i.name + "\r\n");
                }
                if (str.ToString().Equals(""))
                {
                    MessageBox.Show("Ничего не найдено");
                }
                else
                {
                    MessageBox.Show(str.ToString());
                }
            }
            else if (TextBox_Name.Text != "")
            {
                var result = wc.Worker.Where(p => p.name == TextBox_Name.Text);
                StringBuilder str = new StringBuilder();
                foreach (Worker i in result)
                {
                    str.Append(i.id + " " + i.name + "\r\n");
                }
                if (str.ToString().Equals(""))
                {
                    MessageBox.Show("Ничего не найдено");
                }
                else
                {
                    MessageBox.Show(str.ToString());
                }
            }
            else if (TextBox_PlaneId.Text != "")
            {
                int num = Convert.ToInt32(TextBox_PlaneId.Text);
                var result = wc.Worker.Where(p => p.planeId == num);
                StringBuilder str = new StringBuilder();
                foreach (Worker i in result)
                {
                    str.Append(i.id + " " + i.name + "\r\n");
                }
                if (str.ToString().Equals(""))
                {
                    MessageBox.Show("Ничего не найдено");
                }
                else
                {
                    MessageBox.Show(str.ToString());
                }
            }
            else
            {
                MessageBox.Show("Ничего не найдено.");
            }
        }

        

        private void planeSortingButton_Click(object sender, RoutedEventArgs e)
        {
            var workers = mdb.Worker.OrderBy(p => p.planeId);
            List<Worker> wlist = new List<Worker>();
            foreach (Worker w in workers)
                wlist.Add(w);
            workerGrid.ItemsSource = wlist;
        }

        private void nameSortingButton_Click(object sender, RoutedEventArgs e)
        {
            var workers = mdb.Worker.OrderBy(p => p.name);
            List<Worker> wlist = new List<Worker>();
            foreach (Worker w in workers)
                wlist.Add(w);
            workerGrid.ItemsSource = wlist;
            
        }
    }
}
