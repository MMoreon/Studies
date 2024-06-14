using System.Windows.Forms;

namespace Lab._5._2
{
    public partial class Form1 : Form
    {
        public int p = 0;  //� - ���������� ����������, ������������ ��� ������
        public Form1()
        {
            InitializeComponent();
            /* ����� ��� ��������� ���������� ������ � ���
�� ���� ����� �������� ������� ��� �����: */
            fontDialog1.ShowColor = true;
            label2.Text = "";
            label3.Text = "";
            label4.Text = "";
            label5.Text = "";
            //(��� �� ����� ��������� ��� ������):
            textBox1.HideSelection = false;
        }

        // ������ ����������� ���������� �������� ������:
        private void button3_Click(object sender, EventArgs e)
        {
            int k = 0, n = 0, t = 0, m = 0;
            for (int i = 0; i < textBox1.SelectedText.Length; i++)
            {
                if (Char.IsDigit(textBox1.SelectedText[i])) k++;
                if (Char.IsLetter(textBox1.SelectedText[i])) n++;
                if (Char.IsPunctuation(textBox1.SelectedText[i])) t++;
                if (Char.IsWhiteSpace(textBox1.SelectedText[i])) m++;
            }
            label2.Text = "���������� ����: " + Convert.ToString(k);
            label3.Text = "���������� ����: " + Convert.ToString(n);
            label4.Text = "������ ����������:" + Convert.ToString(t);
            label5.Text = "��������: " + Convert.ToString(m);
        }

        // ������ ��������� ���:
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked) textBox1.SelectAll();
            else textBox1.SelectionLength = 0;
        }

        // ������ ������:
        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.IndexOf(textBox2.Text, p) >= 0)
            { /* � ���������� p �������� ������� �������
            ��������� ���������, � ��������� ��� ����� �����
            ����� �� ������� ������, � � ������� p */
                if (p <= textBox1.Text.Length)
                {
                    textBox1.SelectionStart = textBox1.Text.IndexOf(textBox2.Text, p);
                    textBox1.SelectionLength = textBox2.Text.Length;
                    p = textBox1.SelectionStart + 1;
                }
            }
            else
            {
                MessageBox.Show("����� �� ��� �����������");
                //����� ��������� ��������� ����� ����� ������� ������:
                p = 0;
            }
        }

        // ������ ������:
        private void button5_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("�� ������������� ������ ����� ? ", "�����", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) this.Close();
        }

        // ������ ������� �����:
        private void button1_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Font = fontDialog1.Font;
                textBox1.ForeColor = fontDialog1.Color;
            }
        }

        // ������ ������� ���:
        private void button2_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                textBox1.BackColor = colorDialog1.Color;
        }
    }
}