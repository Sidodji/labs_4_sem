using System;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Runtime.Serialization.Json;
using System.IO;
using System.Collections.Generic;

namespace OOP_Lab02_3
{
    public enum SearchFormat
    {
        LINQ = 0,
        REGEX
    }

    public partial class SearchForm : Form
    {
        private SearchFormat searchFormat = SearchFormat.LINQ;

        public SearchForm()
        {
            InitializeComponent();
        }

        public SearchForm(Library library)
        {
            InitializeComponent();
            this.library = library;
        }

        private void inputBookTitle_TextChanged(object sender, EventArgs e)
        {
            if (searchFormat == SearchFormat.LINQ)
            {
                var search = library.GetBookCollection().Where(x => (x.Name == inputBookTitle.Text.ToString()) );// поиск по названию
       
                listBoxSearchResult.Items.Clear();
                foreach (BookFile item in search)
                {
                    listBoxSearchResult.Items.Add("Название: " + item.Name + " | " + "Автор: " + item.Author);
                }
                listBoxSearchResult.Update();

                labelFound.Text = "Found: " + listBoxSearchResult.Items.Count.ToString() + " | " + "Time: " + DateTime.Now;
            }
            else if(searchFormat == SearchFormat.REGEX)
            {
                var search = library.GetBookCollection().Where(x => regCheck(x.Name, inputBookTitle.Text.ToString()));

                listBoxSearchResult.Items.Clear();
                foreach (BookFile item in search)
                {
                    listBoxSearchResult.Items.Add("Название: " + item.Name + " | " + "Автор: " + item.Author);
                }
                listBoxSearchResult.Update();
                //сколько было найдено объектов
                labelFound.Text = "Found: " + listBoxSearchResult.Items.Count.ToString() + "|" + "Time: " + DateTime.Now;
            }
        }

        private bool regCheck(string sorce, string substr)
        {
            substr = substr.Trim();
            string[] words = Regex.Split(substr, @"\s+");

            string regex = "";
            foreach (string item in words)
            {
                regex += (item + "|");
            }

            regex = regex.Remove(regex.Length-1);
            Regex reg = new Regex(regex);
          
            return Regex.IsMatch(sorce, regex);//проверяем на соответствие рег.выр
        }

        private void btnYearSort_Click(object sender, EventArgs e)
        {
            listBoxSearchResult.Items.Clear();
            var sorted = library.GetBookCollection().OrderByDescending(u => u.Year);
            foreach (BookFile item in sorted)
            {
                listBoxSearchResult.Items.Add("Название: " + item.Name + " | " + "Автор: " +item.Author + " | " + "Год:" + item.Year);
            }
            listBoxSearchResult.Update();
        }

        private void btnPageSort_Click(object sender, EventArgs e)
        {
            listBoxSearchResult.Items.Clear();
            var sorted = library.GetBookCollection().OrderByDescending(u => u.BookSize);
            foreach (BookFile item in sorted)
            {
                listBoxSearchResult.Items.Add("Название: " + item.Name + " | " + "Автор: " + item.Author +" | "+ "Кол-во страниц:" + item.BookSize);
            }
            listBoxSearchResult.Update();
        }

        private void btnUploadSort_Click(object sender, EventArgs e)
        {
            listBoxSearchResult.Items.Clear();
            var sorted = library.GetBookCollection().OrderByDescending(u => u.UploadDate);
            foreach (BookFile item in sorted)
            {
                listBoxSearchResult.Items.Add("Название: " + item.Name + " | " + "Автор: " + item.Author + " | " + "Дата добавления:  " + item.UploadDate);
            }
            listBoxSearchResult.Update();
        }

        private void rbSearchFormat_CheckedChanged(object sender, EventArgs e)
        {
            if (rbLinq.Checked)
            {
                searchFormat = SearchFormat.LINQ;
            }
            else if (rbRegex.Checked)
            {
                searchFormat = SearchFormat.REGEX;
            }
        }

        

        private void loadInFile_Click2(object sender, EventArgs e)
        {
            try
            {
                DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(SearchForm));

                using (FileStream fs = new FileStream("librarySearch.json", FileMode.OpenOrCreate))
                {
                    jsonFormatter.WriteObject(fs, searchFormat);
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            MessageBox.Show("файл librarySearch", "Сохранение успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private void YearSort_Click(object sender, EventArgs e)
        {
            listBoxSearchResult.Items.Clear();
            var sorted = library.GetBookCollection().OrderByDescending(u => u.Year);
            foreach (BookFile item in sorted)
            {
                listBoxSearchResult.Items.Add("Название: " + item.Name + " | " + "Автор: " + item.Author + " | " + "Год:" + item.Year);
            }
            listBoxSearchResult.Update();
        }

        private void PageSort_Click(object sender, EventArgs e)
        {
            listBoxSearchResult.Items.Clear();
            var sorted = library.GetBookCollection().OrderByDescending(u => u.BookSize);
            foreach (BookFile item in sorted)
            {
                listBoxSearchResult.Items.Add("Название: " + item.Name + " | " + "Автор: " + item.Author + " | " + "Кол-во страниц:" + item.BookSize);
            }
            listBoxSearchResult.Update();
        }

        private void UploadSort_Click(object sender, EventArgs e)
        {
            listBoxSearchResult.Items.Clear();
            var sorted = library.GetBookCollection().OrderByDescending(u => u.UploadDate);
            foreach (BookFile item in sorted)
            {
                listBoxSearchResult.Items.Add("Название: " + item.Name + " | " + "Автор: " + item.Author + " | " + "Дата добавления:  " + item.UploadDate);
            }
            listBoxSearchResult.Update();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void buttonClearArea(object sender, EventArgs e)
        {
            listBoxSearchResult.Items.Clear();
        }

        

        private void buttonVisible(object sender, EventArgs e)
        {
            if(toolStrip.Visible == true)
            { 
                toolStrip.Visible = false; 
            }
            
            else
            {
                toolStrip.Visible = true;
            }
        }
    }


}
