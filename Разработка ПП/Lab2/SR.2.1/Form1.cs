namespace SR._2._1
{
    public partial class Form1 : Form
    {
        double lnght = 0, wdht = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                wdht = Convert.ToDouble(textBox1.Text);
                lnght = Convert.ToDouble(textBox2.Text);
                switch (comboBox1.SelectedIndex)
                {
                    case 0:
                        {
                            if (checkBox1.Checked)
                            {
                                label3.Text = "� ������ " + (wdht * lnght * 225 + 500).ToString("C");
                            }
                            else label3.Text = "� ������ " + (wdht * lnght * 225).ToString("C");
                        }
                        break;
                    case 1:
                        {
                            if (checkBox1.Checked)
                            {
                                label3.Text = "� ������ " + (wdht * lnght * 424 + 500).ToString("C");
                            }
                            else label3.Text = "� ������ " + (wdht * lnght * 424).ToString("C");
                        }
                        break;
                    case 2:
                        {
                            if (checkBox1.Checked)
                            {
                                label3.Text = "� ������ " + (wdht * lnght * 2025 + 500).ToString("C");
                            }
                            else label3.Text = "� ������ " + (wdht * lnght * 2025).ToString("C");
                        }
                        break;
                }
            }
            catch
            {
                MessageBox.Show("��������� ������������ ������� ������!", "��������!");
            }
        }
    }
}