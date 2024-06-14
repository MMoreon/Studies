namespace S.R._6._1
{
    public partial class Form1 : Form
    {
        string filePath = @"C:\Users\MM0r3\source\repos\Lab6\S.R.6.1\Оценки.txt",
            studName;
        string[] file;
        int gradeOne, gradeTwo;

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 2; i < file.Length; i++)
            {
                studName = file[i].Substring(0, 10).Trim();
                gradeOne = Convert.ToInt32(file[i].Substring(20, 10).Trim());
                gradeTwo = Convert.ToInt32(file[i].Substring(30).Trim());
                textBox1.Text += $"Студент: {studName} Средний балл: {Convert.ToDecimal((gradeOne + gradeTwo) / 2):0.00}" + Environment.NewLine;
            }
        }

        public Form1()
        {
            InitializeComponent();
            using (StreamReader reader = new StreamReader(filePath))
            {
                file = reader.ReadToEnd().Split('\n');
            }
        }
    }
}