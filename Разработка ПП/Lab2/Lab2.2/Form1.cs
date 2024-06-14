using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Lab2._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sum = 0;
            if (checkBox1.Checked) sum += 35;
            if (checkBox2.Checked) sum += 15;
            if (checkBox3.Checked) sum += 9;
            if (checkBox4.Checked) sum += 15;
            if (checkBox5.Checked) sum += 25;
            if (checkBox6.Checked) sum += 20;
            if (checkBox7.Checked) sum *= 0.85;
            label2.Text = "Ваш заказ на сумму " + sum.ToString("C");
        }
    }
}