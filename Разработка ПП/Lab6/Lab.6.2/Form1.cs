using System.Text;

namespace Lab._6._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            /*������ ������������ �����
            textBox1.Multiline = true;
            //������ ������ � ������
            textBox1.Width = 180;
            textBox1.Height = 150;
            // ������� ������������ ������ ���������:
            textBox1.ScrollBars = ScrollBars.Vertical;
            textBox1.Visible = false;
            label2.Text = "";
            // ��������� �������� ������:
            comboBox1.Items.Add("������");
            comboBox1.Items.Add("�������");
            comboBox1.Items.Add("����");
            comboBox1.Items.Add("������");
            comboBox1.Items.Add("���");
            comboBox1.Items.Add("����");
            comboBox1.Items.Add("����");
            comboBox1.Items.Add("������");
            comboBox1.Items.Add("��������");
            comboBox1.Items.Add("�������");
            comboBox1.Items.Add("������");
            comboBox1.Items.Add("�������");*/
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // ������� ����� ��� ������:
            System.IO.StreamReader potok;
            /* �������� ������� ������ �� ����� meteo.txt
            (���� �� ����, ����������, ��������� ������ ����)*/
            try
            {
                potok = new System.IO.StreamReader(@"D:\�����\2 ����\���������� ��\������6\LabRab6-1\LabRab6-1\bin\Debug\meteo.txt", Encoding.GetEncoding(1251));
                //��������� ���� ����� �� �����
                textBox1.Text = potok.ReadToEnd();
                potok.Close();
                // ������ ���� �������
                textBox1.Visible = true;
            }
            catch
            {
                MessageBox.Show("���� �������� ������ �� ������", "��������!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            {//���������� ����� ���������� ������ � ���������� m:
                int m = comboBox1.SelectedIndex + 1;
                // (+1, �.�. ��������� ��������� ������ � ����)
                int n = 0;//���������� ������� �� ���������� ������
                int i;
                double sum = 0;
                // � ����� ������������� ��� ������:
                for (i = 0; i < textBox1.Lines.Length; i++)
                /* ���� ������ �� ������- ���������� ����� ������
                � ��� c m */
                {
                    if (textBox1.Lines[i].Length > 0)
                        if (Convert.ToInt16(textBox1.Lines[i].Substring(3, 2)) == m)
                        {
                            n++;
                            sum += Convert.ToDouble
                            (textBox1.Lines[i].Substring(textBox1.Lines[i].IndexOf
                            (" ")));
                            /* ���������� ������� ������� � ������, ��� �������
                            ����� ����� ������� ������������� � ������������
                            ����� � �������������� � ����� ������ */
                        }
                }
                if (n == 0)
                    label2.Text = "� ����� ��� ������ � ����������� �� " + comboBox1.Text;
                else label2.Text = "������� ����������� �� " + comboBox1.Text + ": " + (sum / n).ToString("N");
            }

        }
    }
}