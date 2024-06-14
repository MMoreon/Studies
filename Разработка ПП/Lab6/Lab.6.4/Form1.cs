namespace Lab._6._4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            panel1.Visible = false;
            textBox3.Multiline = true;
            textBox3.Width = 270;
            textBox3.Height = 160;
            // (������� ��� ������������� ��������)
            textBox3.Visible = false;
            // ������ ��� �������� ��������
            textBox2.PasswordChar = '*';
            label3.Text = "";
            label4.Text = "";
            button4.Visible = false;
        }
        // ������ ������������ ��������� �����
        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            // ������� ����� ��� ������:
            System.IO.StreamReader potokR;
            /* �������� ������� ������ �� ����� ������� ��
            ��������.txt� ���� �� ���� ������������ ���������
            ����� �� �����, ������� ���������� ���� ��������
            ����� ������������ �� ����� (���� ��������
            ����������). ��� ���������� �������� � ���� textBox1
            */
            try
            { // ���� �� ����� ������� ������ ����
                potokR = new System.IO.StreamReader(@"D:\�����\2 ����\���������� ��\������6\LabRab6-4\LabRab6-4\bin\Debug\������ �� ��������.txt");
                textBox3.Text = potokR.ReadToEnd();
                potokR.Close();
            }
            catch
            {
                MessageBox.Show("������ ������ ������!", "��������!");
            }
        }
        // ������ �OK�
        private void button2_Click(object sender, EventArgs e)
        {
            /* ������� � ������ ������ �����-���������
            �������, �� �� ������� (������� ���� � ����).
            ���� � ������ ���� �����, ���������� ����� � ������ �
            ����� textBox2 textBox3 � ���������������� ������� �
            �����. ����� Trim() ����������� ��� ������� � ������
            � ����� ��������, � ������� ��������� ���, ������ �
            �����. ��������� ���� �� ������������ ���, ��� ���
            ������� ��������� ���-�� � ���������� � ������� �� 14
            �������, ������- � �������� ������ �� �������� ������
            �������, ����� - �������� � �������� ������ �������
            (������ �������� ����� � ������)*/
            int flag = 0;
            //(flag =1, ���� ����� ������� � ������, ����� flag = 0)
            try
            {
                for (int i = 2; i < textBox3.Lines.Length; i++)
                    if (textBox3.Lines[i].Length > 0)
                        if ((textBox3.Lines[i].Substring(0, 14).Trim() == textBox1.Text)
                            && (textBox3.Lines[i].Substring(20, 10).Trim() == textBox2.Text))
                        {
                            label3.Text = "��������� " + textBox1.Text + ", �� ����� ����� " + textBox3.Lines[i].Substring(35).Trim() + " ������";
                            flag = 1;
                        }
                /* ����� ����� �������������� �������-
                administrator, ������- master */
                if (textBox1.Text == "321" && textBox2.Text == "123")
                { /* ���������� �������� ��� ��������� ���
                        ������, ������ ���������� ��������� � ��������
                        �����, ������� ����������� �� ���� ������ */
                    label4.Text = "���������� �� ���� ������";
                    textBox3.Visible = true;
                    button4.Visible = true;
                    flag = 1;
                }
                // ���� ����� �� ������� � ������:
                if (flag == 0) label3.Text = "��������� ��� ������������ � ������!";
            }
            catch
            {
                MessageBox.Show("������ ��������� ������!", "��������!");
            }
        }
        // ������ ����������
        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            label3.Text = "";
            label4.Text = "";
            textBox3.Visible = false;
            button4.Visible = false;
            textBox1.Focus();
        }
        // ������ � ��������� ��������� � �������� ����� �
        private void button4_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("������������ ����?", "����������", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                System.IO.StreamWriter potokW;
                try
                {
                    potokW = new
                    System.IO.StreamWriter(@"D:\�����\2 ����\���������� ��\������6\LabRab6-4\LabRab6-4\bin\Debug\������ �� ��������.txt", false);
                    potokW.Write(textBox3.Text);
                    potokW.Close();
                    MessageBox.Show("������ ���� ���������", "��������!");
                }
                catch
                {
                    MessageBox.Show("������ ���������� �����", "��������!");
                }
            }
        }
    }
}