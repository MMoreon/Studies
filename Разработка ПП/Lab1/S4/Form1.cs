namespace S4
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
            label1.Text = "���� ���� ��� �����" + "\n" + "������� �� ������������";
            Random r = new Random();
            a = r.Next(-10, 10);
            b = r.Next(-10, 10);
            label3.Text = a.ToString();
            label4.Text = b.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num1, num2, answ;
            try
            {
                num1 = Convert.ToInt32(label3.Text);
                num2 = Convert.ToInt32(label4.Text);
                answ = Convert.ToInt32(textBox3.Text);
                if (num1 * num2 == answ) label2.Text = "�����";
                else label2.Text = "�� �����";
            }
            catch
            {
                MessageBox.Show("��������� ������������ ��������� ������", "��������!");
            }
        }
    }
}