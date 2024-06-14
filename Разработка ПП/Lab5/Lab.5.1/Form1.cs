using System.Windows.Forms;

namespace Lab._5._1
{
    public partial class Form1 : Form
    {
        const int t = 60;
        int zadumano = 0;
        int ostalos = 60;
        int nomer_popitki = 0;
        public Form1()
        {
            InitializeComponent();
            textBox1.Focus();
            label2.Text = "";
            toolStripStatusLabel1.Text = "� ��� �������� " +
            Convert.ToString(t) + " ���";
            toolStripStatusLabel2.Text = " �������: 0 ";
            timer1.Enabled = true;
            timer1.Interval = 1000;
            // (��� ������������� �������������)
            progressBar1.Maximum = t;
            progressBar1.Value = t;
            progressBar1.Step = 1;
            Random n = new Random();
            zadumano = n.Next(1000); // �� 1 �� 999
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ostalos--;
            progressBar1.Value--;
            toolStripStatusLabel1.Text = "� ��� ��������" +
            Convert.ToString(ostalos) + " ��� ";
            if (ostalos == 0)
            {
                timer1.Enabled = false;
                textBox1.Enabled = false;
                progressBar1.Enabled = false;
                label2.Text = "���, ����� �������...";
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            // ���� � ���� ����� Enter
            if (e.KeyChar.Equals((char)13))
            {
                try
                {
                    if (Convert.ToInt16(textBox1.Text) == zadumano)
                    {
                        timer1.Enabled = false;
                        textBox1.Enabled = false;
                        label2.Text = "�� �������! ������������ ����� " + Convert.ToString(zadumano);
                    }
                    if (Convert.ToInt16(textBox1.Text) > zadumano)
                        label2.Text = "���������� ����� ������";
                    if (Convert.ToInt16(textBox1.Text) < zadumano)
                        label2.Text = "���������� ����� ������";
                }
                catch
                {
                    label2.Text = "������������ ������� ������!";
                }
                nomer_popitki++;
                toolStripStatusLabel2.Text = " �������:" + Convert.ToString(nomer_popitki);
                textBox1.Clear();
                textBox1.Focus();
            }
        }
    }
}