using System.Windows.Forms;

namespace Lab._6._3
{
    public partial class Form1 : Form
    {
        string fname = "";
        public Form1()
        {
            InitializeComponent();
            textBox1.Multiline = true;
            textBox1.Height = 180;
            textBox1.Width = 220;
            textBox1.ScrollBars = ScrollBars.Vertical;
            textBox1.Visible = false;
            openFileDialog1.DefaultExt = "txt";
            openFileDialog1.Filter = "��������� �������� | *.txt";
            saveFileDialog1.DefaultExt = "txt";
            saveFileDialog1.Filter = "��������� �������� | *.txt";
        }

        private void �������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fname = "";
            textBox1.Text = "";
            textBox1.Visible = true;
        }

        private void ���������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
                fname = openFileDialog1.FileName;
            try
            {
                System.IO.StreamReader potok = new
                System.IO.StreamReader(fname);
                textBox1.Text = potok.ReadToEnd();
                textBox1.Visible = true;
                potok.Close();
            }
            catch
            {
                MessageBox.Show("������ ������ �����");
            }
        }

        private void �����ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ���������ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                fname = saveFileDialog1.FileName;
            try
            {
                System.IO.FileInfo fi = new System.IO.FileInfo(fname);
                System.IO.StreamWriter potok = fi.CreateText();
                potok.Write(textBox1.Text);
                potok.Close();
            }
            catch
            {
                MessageBox.Show("������ ���������� �����");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i;
            double max, min;
            string m1 = ""; //��� �������������� ���������� ���
            string m2 = "";
            try
            {
                // �� min � max ��������� ������ �������� �����������:
                max = min = Convert.ToDouble(textBox1.Lines[0].Substring(11));
                for (i = 0; i < textBox1.Lines.Length; i++)
                {
                    if (textBox1.Lines[i].Length > 0)
                    {
                        if (Convert.ToDouble(textBox1.Lines[i].Substring(11)) > max)
                        {
                            max = Convert.ToDouble(textBox1.Lines[i].Substring(11));
                            m1 = textBox1.Lines[i].Substring(0, 8);
                        }
                        if (Convert.ToDouble(textBox1.Lines[i].Substring(11)) < min)
                        {
                            min = Convert.ToDouble(textBox1.Lines[i].Substring(11));
                            m2 = textBox1.Lines[i].Substring(0, 8);
                        }
                    }
                }
                textBox1.Text = "������������ �����������: " + Convert.ToString(max) + Environment.NewLine + "����������� " + m1 + Environment.NewLine + "����������� �����������: " + Convert.ToString(min) + Environment.NewLine + "����������� " + m2;
            } // try
            catch
            {
                MessageBox.Show("������������ ������", "��������!");
            }
        }
    }
}

