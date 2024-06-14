namespace Lab._3._1
{
    public partial class Form1 : Form
    {
        double chislo1 = 0, chislo2 = 0;
        bool flag;
        char operator_;

        // ��� ������ "1"
        private void button1_Click(object sender, EventArgs e)
        {
            if (flag == true) textBox1.Text = "0";
            flag = false;
            if (textBox1.Text != "0") textBox1.Text = textBox1.Text + "1";
            else textBox1.Text = "1";
        }

        // ��� ������ "2"
        private void button2_Click(object sender, EventArgs e)
        {
            if (flag == true) textBox1.Text = "0";
            flag = false;
            if (textBox1.Text != "0") textBox1.Text = textBox1.Text + "2";
            else textBox1.Text = "2";
        }

        // ��� ������ "3"
        private void button3_Click(object sender, EventArgs e)
        {
            if (flag == true) textBox1.Text = "0";
            flag = false;
            if (textBox1.Text != "0") textBox1.Text = textBox1.Text + "3";
            else textBox1.Text = "3";
        }

        // ��� ������ "4"
        private void button4_Click(object sender, EventArgs e)
        {
            if (flag == true) textBox1.Text = "0";
            flag = false;
            if (textBox1.Text != "0") textBox1.Text = textBox1.Text + "4";
            else textBox1.Text = "4";
        }

        // ��� ������ "5"
        private void button5_Click(object sender, EventArgs e)
        {
            if (flag == true) textBox1.Text = "0";
            flag = false;
            if (textBox1.Text != "0") textBox1.Text = textBox1.Text + "5";
            else textBox1.Text = "5";
        }

        // ��� ������ "6"
        private void button6_Click(object sender, EventArgs e)
        {
            if (flag == true) textBox1.Text = "0";
            flag = false;
            if (textBox1.Text != "0") textBox1.Text = textBox1.Text + "6";
            else textBox1.Text = "6";
        }

        // ��� ������ "7"
        private void button7_Click(object sender, EventArgs e)
        {
            if (flag == true) textBox1.Text = "0";
            flag = false;
            if (textBox1.Text != "0") textBox1.Text = textBox1.Text + "7";
            else textBox1.Text = "7";
        }

        // ��� ������ "8"
        private void button8_Click(object sender, EventArgs e)
        {
            if (flag == true) textBox1.Text = "0";
            flag = false;
            if (textBox1.Text != "0") textBox1.Text = textBox1.Text + "8";
            else textBox1.Text = "8";
        }

        // ��� ������ "9"
        private void button9_Click(object sender, EventArgs e)
        {
            if (flag == true) textBox1.Text = "0";
            flag = false;
            if (textBox1.Text != "0") textBox1.Text = textBox1.Text + "9";
            else textBox1.Text = "9";
        }

        // ��� ������ "0"
        private void button10_Click(object sender, EventArgs e)
        {
            if (flag == true) textBox1.Text = "0";
            flag = false;
            if (textBox1.Text != "0") textBox1.Text = textBox1.Text + "0";
            else textBox1.Text = "0";
        }

        // ��� ������ "="
        private void button21_Click(object sender, EventArgs e)
        {
            if (flag == false) chislo2 = Convert.ToDouble(textBox1.Text);
            else chislo2 = chislo1;
            switch (operator_)
            {
                case '+': textBox1.Text = Convert.ToString(chislo1 + chislo2); break;
                case '-': textBox1.Text = Convert.ToString(chislo1 - chislo2); break;
                case '*': textBox1.Text = Convert.ToString(chislo1 * chislo2); break;
                case '/':
                    if (chislo2 != 0) textBox1.Text = Convert.ToString(chislo1 / chislo2);
                    else textBox1.Text = "�� ���� ������ ������!"; break;
            }
            flag = true;
        }

        // ��� ������ "+"
        private void button13_Click(object sender, EventArgs e)
        {
            chislo1 = Convert.ToDouble(textBox1.Text);
            flag = true;
            operator_ = '+';
        }

        // ��� ������ "-"
        private void button14_Click(object sender, EventArgs e)
        {
            chislo1 = Convert.ToDouble(textBox1.Text);
            flag = true;
            operator_ = '-';
        }

        // ��� ������ "*"
        private void button15_Click(object sender, EventArgs e)
        {
            chislo1 = Convert.ToDouble(textBox1.Text);
            flag = true;
            operator_ = '*';
        }

        // ��� ������ "/"
        private void button16_Click(object sender, EventArgs e)
        {
            chislo1 = Convert.ToDouble(textBox1.Text);
            flag = true;
            operator_ = '/';
        }

        // ��� ������ "C"
        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            flag = false;
            chislo1 = 0;
            chislo2 = 0;
        }

        // ��� ������ "+/-"
        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(Convert.ToDouble(textBox1.Text) * (-1));
        }

        // ��� ������ ","
        private void button11_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.IndexOf(",") == -1) textBox1.Text = textBox1.Text + ",";
        }

        // ��� ������ "Off"
        private void button17_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // ��� ������ "Sqr"
        private void button19_Click(object sender, EventArgs e)
        {
            chislo1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = Convert.ToString(Math.Pow(chislo1, 2));
        }

        // ��� ������ "Sqrt"
        private void button20_Click(object sender, EventArgs e)
        {
            chislo1 = Convert.ToDouble(textBox1.Text);
            textBox1.Text = Convert.ToString(Math.Sqrt(chislo1));
        }

        public Form1()
        {
            InitializeComponent();
        }
    }
}