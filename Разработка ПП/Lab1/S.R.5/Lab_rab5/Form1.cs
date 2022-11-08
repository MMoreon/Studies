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

namespace Lab_rab5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //sqrt(Double) - Bозвр. кв. корень из указанного числа.
            //pow(Double,Double) - Возвр. указанное число, возведенное в указанную степень.
            //Abs(Double) - Возвр. абсолютное значение числа.
            double x1, y1, x2, y2, x3, y3, s, p, st1, st2, st3;
            try
            {
                x1 = Convert.ToDouble(textBox1.Text);
                y1 = Convert.ToDouble(textBox2.Text);
                x2 = Convert.ToDouble(textBox3.Text);
                y2 = Convert.ToDouble(textBox4.Text);
                x3 = Convert.ToDouble(textBox5.Text);
                y3 = Convert.ToDouble(textBox6.Text);
                st1 = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
                st2 = Math.Sqrt(Math.Pow((x3 - x2), 2) + Math.Pow((y3 - y2), 2));
                st3 = Math.Sqrt(Math.Pow((x1 - x3), 2) + Math.Pow((y1 - y3), 2));
                if ((st1 + st2 > st3) & (st1 + st3 > st2) & (st2 + st3 > st1))
                {
                    p = st1 + st2 + st3;
                    s = Math.Abs(0.5 * (x1 * (y2 - y3) + x2 * (y3 - y1) + x3 * (y1 - y2)));
                    label6.Text = "Периметр: " + p.ToString("N") + "\n" + "Площадь: " + s.ToString("N");
                }
                else
                {
                    label6.Text = "Треугольник не существует";
                }
            }
            catch
            {
                MessageBox.Show("Проверьте правильность входных данных", "Внимание!");
            }
        }

    }
    }
