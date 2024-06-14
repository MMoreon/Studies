namespace S1.L1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label2.Text = "";  // удаление ненужного текста
        }

        private void textBox1_TextChanged(object sender, EventArgs e)  // обработка нажати€ по кнопке
        {  // если поле не пустое Ц будет выведено приветствие
            if (textBox1.Text != "") label2.Text = "«драствуйте, " + textBox1.Text + "!";
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}