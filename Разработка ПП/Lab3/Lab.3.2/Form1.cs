using System.Windows.Forms;

namespace Lab._3._2
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
            tabControl1.Visible = false;
            if (radioButton1.Checked) k++;
            if (radioButton5.Checked) k++;
            if (radioButton9.Checked) k++;
            if (k == 3) MessageBox.Show("Вы верно ответили на все вопросы!", "Результат.");
            else MessageBox.Show("Вы верно ответили на " + Convert.ToString(k) + " из трех вопросов.", "Результат.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabControl1.Visible = true;
        }
    }
}