using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_1
{
    public partial class каль : Form
    {
        public каль()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        //очистить
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            comboBox1.Text = "";
        }
        //посчитать
        public void button1_Click(object sender, EventArgs e)
        {

            try
            {
                double a = double.Parse(textBox1.Text, System.Globalization.NumberStyles.Number);
                label1.Text = a.ToString();
                double b = double.Parse(textBox2.Text, System.Globalization.NumberStyles.Number);
                label2.Text = b.ToString();
            
            

            switch (comboBox1.Text)//принимаем арифм. операцию
            {
                case "+":
                    textBox3.Text = Convert.ToString(a + b);
                    break;
                case "-":
                    textBox3.Text = Convert.ToString(a - b);
                    break;
                case "*":
                    textBox3.Text = Convert.ToString(a * b);
                    break;
                case "/":
                    if (b == 0)
                        MessageBox.Show("Деление на ноль");
                    textBox3.Text = Convert.ToString(a / b);
                    break;
                case "%":
                    textBox3.Text = Convert.ToString(a % b);
                    break;
                case "X":
                    textBox3.Text = Convert.ToString(Convert.ToInt32(a / b));
                    break;
            }
            }
            catch
            {
                MessageBox.Show("Ошибка ввода");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
