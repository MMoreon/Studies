namespace S1.L2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double k1, k2, k3;  // �������� ����������
            try // ������� ���������
            {
                k1 = Convert.ToDouble(textBox1.Text);
                k2 = Convert.ToDouble(textBox2.Text);
                k3 = k1 + k2;
                textBox3.Text = k3.ToString("N");
            }
            catch  // ���� �� ���������
            {
                if ((textBox1.Text == "") || (textBox2.Text == ""))
                    MessageBox.Show("������� ������!", "��������",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                else MessageBox.Show("�������� ������ �������� ������!", "��������",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox1.Focus();  // ������ �� ���� ����� 1-�� ����������
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("�� ������������� ������ �����?", "�����",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}