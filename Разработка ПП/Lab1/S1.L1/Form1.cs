namespace S1.L1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label2.Text = "";  // �������� ��������� ������
        }

        private void textBox1_TextChanged(object sender, EventArgs e)  // ��������� ������� �� ������
        {  // ���� ���� �� ������ � ����� �������� �����������
            if (textBox1.Text != "") label2.Text = "�����������, " + textBox1.Text + "!";
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}