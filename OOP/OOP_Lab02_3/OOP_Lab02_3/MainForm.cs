using System;
using System.Windows.Forms;
using System.Runtime.Serialization.Json;
using System.IO;
using System.Collections.Generic;

namespace Library
{
    public partial class MainForm : Form
    {
        Library library = new Library("Мой курсач на WindowsForms");

        public MainForm()
        {
            InitializeComponent();
            
        }

        private void ClearListBox(object sender, EventArgs e)
        {
            listBox.Items.Clear();
        }

        private void Validate (object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar <=65 || e.KeyChar >=90 && e.KeyChar<=97 || e.KeyChar>= 122)
            {
                e.Handled = true;
            }
            else if (e.KeyChar == 8)
            {
                e.Handled = true;
            }
            
        }

        private void loadInFile_Click(object sender, EventArgs e) //загрузка в файл
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
            
                MessageBox.Show(exc.Message, "Ошибка сериализации", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void loadFromFile_Click(object sender, EventArgs e)//загрузка из файла
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
                listBox.Update(); //обновляем наш вывод каждый раз при нажитии кнопки

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
                string.IsNullOrEmpty(inputFileSizeField.Text))
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
                bookSizeTrackBar.Value, inputPublisherField.Text, format, int.Parse(inputFileSizeField.Text), System.DateTime.Now);
                library.AddBook(book);
                listBox.Items.Add("Название книги: " + book.Name + " | " + "Автор: " + book.Author + "|"+ "Год выхода"+book.Year);
                listBox.Update();
            }
        }

        

        private void bookSizeTrackBar_Scroll(object sender, EventArgs e)
        {
            bookSizeLabel.Text = "Размер книги - " + bookSizeTrackBar.Value.ToString();
        }
        //об авторе
        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Version: 2.0.1\nAlisevich Daniil.", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        

        private void inputNameField_TextChanged(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void bookSizeLabel_Click(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void myTextBox_KeyPress(object sender, EventArgs e)
        {
           
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
