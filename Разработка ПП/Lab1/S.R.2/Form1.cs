using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _2_rand_number
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int a, b;
            Random r = new Random();
            a = r.Next(-10, 10);
            b = r.Next(-10, 10);
            label2.Text = a.ToString();
            label3.Text = b.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1, num2, answ;
            try
            {
                num1 = Convert.ToInt32(label2.Text);
                num2 = Convert.ToInt32(label3.Text);
                answ = Convert.ToInt32(textBox1.Text);
                if (num1 * num2 == answ) label4.Text = "Верно";
                else label4.Text = "Не верно";
            }
            catch
            {
                MessageBox.Show("Проверьте правильность введенных данных", "Внимание!");
            }
        }
    }
}
