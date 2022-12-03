using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stoimost_pokritiya
{
    public partial class Form1 : Form
    {
        double lenght = 0, widht = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                widht = Convert.ToDouble(textBox1.Text);
                lenght = Convert.ToDouble(textBox2.Text);
                switch (comboBox1.SelectedIndex)
                {
                    case 0:
                        {
                            if (checkBox1.Checked)
                            {
                                label3.Text = "К оплате " + (widht * lenght * 225 + 500).ToString("C");
                            }
                            else label3.Text = "К оплате " + (widht * lenght * 225).ToString("C");
                        }
                        break;
                    case 1:
                        {
                            if (checkBox1.Checked)
                            {
                                label3.Text = "К оплате " + (widht * lenght * 424 + 500).ToString("C");
                            }
                            else label3.Text = "К оплате " + (widht * lenght * 424).ToString("C");
                        }
                        break;
                    case 2:
                        {
                            if (checkBox1.Checked)
                            {
                                label3.Text = "К оплате " + (widht * lenght * 2025 + 500).ToString("C");
                            }
                            else label3.Text = "К оплате " + (widht * lenght * 2025).ToString("C");
                        }
                        break;
                }
            }
            catch
            {
                MessageBox.Show("Проверьте правильность входных данных!", "Внимание!");
            }
        }
    }
}

