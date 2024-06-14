using System.Windows.Forms;

namespace S.R._4._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ((DataGridViewComboBoxColumn)dataGridView1.Columns[1]).Items.AddRange(new string[] { "��-31", "��-32" });
            // ������ ���� ���� ����������:
            dataGridView1.BackgroundColor = this.BackColor;
            // ������� �����:
            dataGridView1.BorderStyle = BorderStyle.None;
            // ������ ������� �������:
            dataGridView1.Width = 760;
            dataGridView1.Height = 160;
            // ������� ������������ ������ ���������:
            dataGridView1.ScrollBars = ScrollBars.Vertical;
            // ������ ������������ ������ � ������� �� ������:
            dataGridView1.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i, countOne = 0, countTwo = 0;
            // ���� � ��� 5 ��������� �������, ��������� ��� ����
            if (dataGridView1.ColumnCount == 5)
                dataGridView1.Columns.Add("Column5",
                "������ � ��������");
            dataGridView1.Columns[5].Width = 155;
            /* ������� �� ���� ������� �� ���������� �����
            ������������: */
            for (i = 0; i < dataGridView1.RowCount; i++)
            {
                /* dataGridView1.Rows[i].Cells[2].Value ��������� �������� "�����",
                 � ������: true, ���� ������������ ������ ������ � false, ���� ���.
                ��� "dataGridView1.Rows[i].Cells[2].Value != null" ���������� ��� � �������*/
                if (Convert.ToBoolean(dataGridView1.Rows[i].Cells[2].Value) == true
                    && Convert.ToBoolean(dataGridView1.Rows[i].Cells[3].Value) == true
                    && Convert.ToBoolean(dataGridView1.Rows[i].Cells[4].Value) == true)
                {
                    dataGridView1.Rows[i].Cells[5].Value = "�������";
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.MistyRose;
                    if (Convert.ToString(dataGridView1.Rows[i].Cells[1].Value) == "��-31")
                    {
                        countOne += 1;
                    }
                    if (Convert.ToString(dataGridView1.Rows[i].Cells[1].Value) == "��-32")
                    {
                        countTwo += 1;
                    }
                }
                else
                {
                    dataGridView1.Rows[i].Cells[5].Value = "";
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.White;
                }
            }
            label2.Text = "� ������ ��-31 ��������: " + Convert.ToString(countOne);
            label3.Text = "� ������ ��-32 ��������: " + Convert.ToString(countTwo);
        }
    }
}