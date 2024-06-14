namespace S.R._5._3
{
    public partial class Form1 : Form
    {
        DateTime curDate;
        int p = 0;
        public Form1()
        {
            InitializeComponent();
            textBox1.HideSelection = false;
            curDate = DateTime.Now;
            textBox1.Text += $"{curDate.AddDays(-2).ToShortDateString()} ������� � �������\n";
            textBox1.Text += $"{curDate.AddDays(-1).ToShortDateString()} ������ ��������\n";
            textBox1.Text += $"{curDate.ToShortDateString()} ������� ������\n";
            textBox1.Text += $"{curDate.AddDays(1).ToShortDateString()} ������ �����\n";
            textBox1.Text += $"{curDate.AddDays(2).ToShortDateString()} �������� ���������\n";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.IndexOf(Convert.ToString(curDate.ToShortDateString()), p) >= 0)
            {
                if (p <= textBox1.Text.Length)
                {
                    textBox1.SelectionStart = textBox1.Text.IndexOf(Convert.ToString(curDate.ToShortDateString()), p);
                    textBox1.SelectionLength = Convert.ToString(curDate.ToShortDateString()).Length;
                    p = textBox1.SelectionStart + 1;
                }
            }
            else
            {
                MessageBox.Show("����� �� ��� �����������");
                p = 0;
            }
            p = 0;
        }
    }
}