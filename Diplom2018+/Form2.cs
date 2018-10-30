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
    public partial class Form2 : Form
    {
        string t1;
        string t2;
        static public string Pass { get; set; }
        public Form2()
        {
            Pass = Form1.Pass; 
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            t1 = textBox1.Text;
            t2 = textBox2.Text;
            if (t1 == Pass)  
            {
      
                Form1.Pass = t2;
                MessageBox.Show("Пароль изменен");
                this.Close();
            }
   else 
            {
                MessageBox.Show("Неправильные введенные данные");
                this.Close();
            }
            
        }
      


        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
