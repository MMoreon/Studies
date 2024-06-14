using System.Windows.Forms;

namespace S.R._7._1
{
    public partial class Form1 : Form
    {
        public Point[] Points = new Point[10];
        public Form1()
        {
            InitializeComponent();
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            this.BackColor = Color.White;
            this.Text = "��������� ����� � ������";
            this.ClientSize = new
            Size(470, 400);
            // ���� ���� ������� ������ ����� ��, ��� � �����:
            dataGridView1.BackgroundColor = this.BackColor;
            // ������� ������� ������� ����������:
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.ColumnCount = 11;
            dataGridView1.RowCount = 2;
            // ������� ����� �������:
            dataGridView1.ColumnHeadersVisible = false;
            dataGridView1.RowHeadersVisible = false;
            // ������� ������ ���������:
            dataGridView1.ScrollBars = ScrollBars.None;
            // ������ ������ �������
            dataGridView1.Width = 350;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Pen P = new Pen(Color.Blue, 2);
            e.Graphics.DrawCurve(P, Points);
            Pen p = new Pen(Color.Red, 2);
            e.Graphics.DrawLines(p, Points);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = 20, y = 20;
            Random r = new Random();
            dataGridView1.Rows[0].Cells[0].Value = "x";
            dataGridView1.Rows[1].Cells[0].Value = "y";
            for (int i = 0; i < 10; i++)
            {
                Points[i] = new Point(x, y);
                x += 50;
                y = r.Next(300);
                dataGridView1.Rows[0].Cells[i + 1].Value =
                x.ToString();
                dataGridView1.Rows[1].Cells[i + 1].Value =
                y.ToString();
            }
            this.Refresh();
        }
    }
}