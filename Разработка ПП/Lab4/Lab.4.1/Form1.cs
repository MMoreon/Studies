namespace Lab._4._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // ��������� � ������������� �����
            textBox1.Multiline = true;
            textBox2.Multiline = true;
            textBox2.Visible = false;
            label1.Text = "";
            label2.Text = "";
            label3.Text = "";
            label4.Text = "";
            label5.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //������� ������ ���������
            textBox2.ScrollBars = ScrollBars.Vertical;
            // ������ ������ ���� ������
            textBox2.Height = 150;
            textBox2.Text = textBox1.Text;
            textBox2.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double sum = 0;
            double max, min;
            int i, n;
            try
            {
                // ���������� ���������:
                n = textBox1.Lines.Length - 1;
                //����� ����, �.�. ��������� Enter ������� ������ ������ ������
                label1.Text = "���������� ���������:" + Convert.ToString(n);
                // ������� �����:
                for (i = 0; i < n; i++)
                    sum = sum + Convert.ToDouble(textBox1.Lines[i]);
                label2.Text = "�����: " + Convert.ToString(sum);
                // ������� ������� ��������:
                label3.Text = "������� ��������: " +
                Convert.ToString(sum / n);
                //������� �������� � ������� �� ������������ ���������:
                max = min = Convert.ToDouble(textBox1.Lines[0]);
                for (i = 0; i < n; i++)
                {
                    if (Convert.ToDouble(textBox1.Lines[i]) > max)
                        max = Convert.ToDouble(textBox1.Lines[i]);
                    if (Convert.ToDouble(textBox1.Lines[i]) < min)
                        min = Convert.ToDouble(textBox1.Lines[i]);
                }
                label4.Text = "���������� ��������: " +
                Convert.ToString(max);
                label5.Text = "���������� ��������: " +
                Convert.ToString(min);
            }
            catch
            {
                label1.Text = "��������� ����������� ������� ������";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox1.Focus();
            textBox2.Visible = false;
            label1.Text = label2.Text = label3.Text =
            label4.Text = label5.Text = "";
        }
    }
}