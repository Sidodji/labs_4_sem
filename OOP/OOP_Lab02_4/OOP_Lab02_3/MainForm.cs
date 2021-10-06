using System;
using System.Windows.Forms;
using System.Runtime.Serialization.Json;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OOP_Lab02_3
{
    public partial class MainForm : Form
    {
        Library library = new Library("Библиотека будущего курсача");

        public MainForm()
        {
            InitializeComponent();
        }

        private void Validate(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar <= 65 || e.KeyChar >= 90 && e.KeyChar <= 97 || e.KeyChar >= 122)
            {
                e.Handled = true;
            }
            else if (e.KeyChar == 8)
            {
                e.Handled = true;
            }
        }

        private void loadInFile_Click(object sender, EventArgs e)
        {
            try
            {
                DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(Library));

                using (FileStream fs = new FileStream("library.json", FileMode.OpenOrCreate))
                {
                    jsonFormatter.WriteObject(fs, library);
                }
            }
            catch(Exception exc)
            {
                MessageBox.Show(exc.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void loadFromFile_Click(object sender, EventArgs e)
        {
            Library jsonLibrary;

            try
            {
                DataContractJsonSerializer jsonFormatter = new DataContractJsonSerializer(typeof(Library));

                using (FileStream fs = new FileStream("library.json", FileMode.OpenOrCreate))
                {
                    jsonLibrary = (Library)jsonFormatter.ReadObject(fs);
                }
                List<BookFile> books = jsonLibrary.GetBookCollection();

                foreach (BookFile book in books)
                {
                    library.GetBookCollection().Add(book);
                    listBox.Items.Add("Название: " + book.Name + " | " + "Автор: " + book.Author);
                }
                listBox.Update();

            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

            MessageBox.Show("Успешно загружено!", "Загрузка из файла.", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            int year = 1000;
            float fileSize = 5000;
            // проверка вводимых данных
            if (string.IsNullOrEmpty(inputNameField.Text) || string.IsNullOrEmpty(inputAuthorField.Text) ||
                string.IsNullOrEmpty(inputYearField.Text) || string.IsNullOrEmpty(inputPublisherField.Text) ||
                string.IsNullOrEmpty(inputFileSizeField.Text) || string.IsNullOrEmpty(inputUdkField.Text))
            {
                MessageBox.Show("Не все поля заполнены!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (!int.TryParse(inputYearField.Text, out year) || !float.TryParse(inputFileSizeField.Text, out fileSize))
            {
                MessageBox.Show("Ожидалось числовое значение!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                FileFormat format = FileFormat.FB2;
                if (rbFormat1.Checked)
                    format = FileFormat.FB2;
                if (rbFormat2.Checked)
                    format = FileFormat.EPUB;
                if (rbFormat3.Checked)
                    format = FileFormat.TXT;

                BookFile book = new BookFile(inputNameField.Text, inputAuthorField.Text, int.Parse(inputYearField.Text),
                bookSizeTrackBar.Value, inputPublisherField.Text, format,  int.Parse(inputFileSizeField.Text), inputUdkField.Text, System.DateTime.Now);
                //валидация
                var results = new List<ValidationResult>();
                var context = new ValidationContext(book);
                if (!Validator.TryValidateObject(book, context, results, true))
                {
                    foreach (var error in results)
                    {
                        MessageBox.Show(error.ErrorMessage);
                    }
                }
                else 
                {
                    library.AddBook(book);
                    listBox.Items.Add("Название: " + book.Name + " | " + "Автор: " + book.Author /*+ "UDK"+book.UDK*/);
                    listBox.Update();
                }
            }
        }

        private void bookSizeTrackBar_Scroll(object sender, EventArgs e)
        {
            bookSizeLabel.Text = "Book size (" + bookSizeTrackBar.Value.ToString() + ")";
        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Version: 2.0\nAlisevich Daniil", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchForm searchForm = new SearchForm(library);
            searchForm.Activate();
            searchForm.Show();
        }

        

        private void myTextBox_KeyPress(object sender, EventArgs e)
        {

        }

        private void buttonClearArea(object sender, EventArgs e)
        {
            listBox.Items.Clear();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void formatBox_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void inputNameField_TextChanged(object sender, EventArgs e)
        {

        }

        private void patternMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            PatternForm patternForm = new PatternForm();
            patternForm.Show();
           
        }
    }
}
