using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diplom2018_
{
    public partial class Form1 : Form
    {
       
        static public string Pass { get; set; }
        public Form1()
        {
            InitializeComponent();  
            Pass = "admin";
           
        }
        private Form2 passreload = new Form2();
        private void button2_Click(object sender, EventArgs e)
        {
            passreload = new Form2();
            passreload.Show();
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == String.Empty)//Проверка на пустоту текстбокса
            {
                MessageBox.Show("Введите пароль");
            }
            else if (textBox1.Text == Pass)    //Проверка на правильность пароля
            {
                MessageBox.Show("Доступ разрешен");
                this.Hide();
                Form3 f3 = new Form3();
                f3.Show();
            }
            else if (textBox1.Text != Pass)
                MessageBox.Show("Доступ закрыт");


        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.Show();
        }
    }
    }
