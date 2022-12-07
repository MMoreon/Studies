using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace L.R._3._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            byte k = 0;
            // Делаем набор закладок невидимым
            tabControl1.Visible = false;
            /* Впишите свои номера кнопок, соответствуюших
           правильным ответам. В моем примере это кнопки 1,5 и
           7*/
            if (radioButton1.Checked) k++;
            if (radioButton4.Checked) k++;
            if (radioButton8.Checked) k++;
            if (k == 3) MessageBox.Show("Вы верно ответилина все вопросы!","Результат: ");
            else MessageBox.Show("Вы ответили верно на " +
            Convert.ToString(k) + " из трех вопросов", "Результат:");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabControl1.Visible = true;
        }

    }
}
