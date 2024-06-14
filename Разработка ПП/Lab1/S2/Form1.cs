namespace S2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double old_num, new_num, cost, bill, spend;
            try
            {
                old_num = Convert.ToDouble(textBox1.Text);
                new_num = Convert.ToDouble(textBox2.Text);
                cost = Convert.ToDouble(textBox3.Text);
                if (new_num - old_num > 0)
                {
                    spend = new_num - old_num;
                    bill = spend * cost;
                    label5.Text = "���� ���������� " + spend.ToString() + " ���" + "\n" +
                        "�� ����� " + bill.ToString("C");
                }
                else label5.Text = "����������� ������� ������";
            }
            catch
            {
                MessageBox.Show("��������� ������������ ��������� ������", "��������!");
            }
        }
    }
}