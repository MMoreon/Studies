using System.Windows.Forms;

namespace Lab._6._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // ������������� ����������� ���� �� monthCalendar:
            monthCalendar1.TodayDate = DateTime.Now;
        }
        // �������� �������� �������� � ���� textBox1:
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || (e.KeyChar.ToString() == "-" && textBox1.Text == "")
                || (e.KeyChar.ToString() == "," && textBox1.Text.IndexOf(",") == -1)) e.Handled = false;
            else e.Handled = true;
        }
        /* �� ����: �������� ������ ����� ���� ������, ���
        ������ �-� (���� ������ ������), ��� �������(����
        ������� �� ����� �� ����)*/
        // ��� ������ � ������ ������ � ���� � :
        private void button1_Click(object sender, EventArgs e)
        {
            DateTime d;
            // ������� ���������� � ����� meteo.txt :
            // C������ ������ fi ���� FileInfo:
            System.IO.FileInfo fi = new System.IO.FileInfo(Application.StartupPath + "\\meteo.txt");
            // ������� ����� ��� ������:
            System.IO.StreamWriter potok;
            /* ���� ���� meteo.txt ������, ����� ��������� �
            ���� ������, ����� ������� ����: */
            if (fi.Exists) potok = fi.AppendText();
            else potok = fi.CreateText();
            /* ���������� d ������ ��������, ������ ���������
            � ��������� ����: */
            d = monthCalendar1.SelectionStart;
            /* ��������� �������� ���������� d � ������ �
            ������� �������� ������ ����: d.ToShortDateString(),
            ������� ��� ������, ���� ������� � ��������
            ����������� � �����:*/
            potok.WriteLine(d.ToShortDateString() + " " + textBox1.Text);
            potok.Close();
            textBox1.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}