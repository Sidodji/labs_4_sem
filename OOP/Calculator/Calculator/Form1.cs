using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button15_Click(object sender, EventArgs e)// вводим число
        {
            textBox1.BackColor = Color.White;
            textBox1.Text += (sender as Button).Text;
        }
        private void button14_Click(object sender, EventArgs e)//запятая
        {
            textBox1.Text += (sender as Button).Text;
            (sender as Button).Enabled = false;
        }

        double a = 0, b = 0, c = 0;
        char znak;

        private void button1_Click(object sender, EventArgs e)//нажатие на знак
        {
            if(textBox1.Text == "")
            {
                textBox1.BackColor = Color.Red;
            }
            else
            {
                a = Convert.ToDouble(textBox1.Text);
                textBox1.Clear();
                znak = (sender as Button).Text[0];
                button16.Enabled = true;
            }
        }

        //равно
        private void button5_Click(object sender, EventArgs e)
        {
            b = Convert.ToDouble(textBox1.Text);
            switch (znak)
            {
                case '+': c = a + b;
                    break;
                case '-': c = a - b;
                    break;
                case '*': c = a * b;
                    break;
                case '/': c = a / b;
                    if (b == 0)
                        MessageBox.Show("Деление на ноль");
                    break;
                case '%': c = a % b;
                    break;
                case 'X': c = Convert.ToInt32(a / b); //целое от деления
                    
                    break;
            }
            textBox1.Text = c.ToString();
            button16.Enabled = true;

        }

        //очистить
        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            button16.Enabled = true;


        }

        //сменить знак числа
        private void button18_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
                if (textBox1.Text[0] == '-')
                    textBox1.Text = textBox1.Text.Remove(0, 1); //удаляем первый символ - знака
                else textBox1.Text = '-' + textBox1.Text;
            button16.Enabled = true;

        }
        //удаление последних знаков
        private void button19_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                if (textBox1.Text[textBox1.Text.Length - 1] == ',')
                {
                    button16.Enabled = true;
                }
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1, 1);
                
            }
            
        }

    }
}
