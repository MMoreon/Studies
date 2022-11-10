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

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label3.Text = "0";
            label2.Text = "0";
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            double num;
            int count1, count2;
            try
            {
                count1 = Convert.ToInt32(label3.Text);
                count2 = Convert.ToInt32(label2.Text);
                if (e.KeyChar.Equals((char)13))
                {
                    num = Convert.ToDouble(textBox1.Text);
                    if (num > 0)
                    {
                        count1++;
                        label3.Text = Convert.ToString(count1);
                    }
                    else if (num < 0)
                    {
                        count2++;
                        label2.Text = Convert.ToString(count2);
                    }
                    else
                    {
                        this.Close();
                    }
                }
            }
            catch
            {
                MessageBox.Show("Проверьте правильность входных данных!", "Внимание!");
            }
        }
    }
}
