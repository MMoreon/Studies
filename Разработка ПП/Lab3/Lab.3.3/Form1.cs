namespace Lab._3._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // ������� ������ f2, ������� ��� Form2
            Form2 f2 = new Form2();
            f2.ShowDialog(); // ���������� ����� 2
            label1.Text = "����� ����� " + Convert.ToString(f2.a + f2.b);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.ShowDialog(); // ���������� ����� 3
        }
    }
}