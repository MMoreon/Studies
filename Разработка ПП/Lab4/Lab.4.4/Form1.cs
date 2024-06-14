using System.Windows.Forms;

namespace Lab._4._4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            /* ������� �������� ������ comboBox ��� ������
            �������:(�� ��������, ���������� ����� � ��������
            ���������� � ����) */
            ((DataGridViewComboBoxColumn)dataGridView1.Columns[1]
            ).Items.AddRange(new string[] { "��-31", "��-32" });
            // ������ ���� ���� ����������:
            dataGridView1.BackgroundColor = this.BackColor;
            // ������� �����:
            dataGridView1.BorderStyle = BorderStyle.None;
            // ������ ������� �������:
            dataGridView1.Width = 1000;
            dataGridView1.Height = 160;
            // ������� ������������ ������ ���������:
            dataGridView1.ScrollBars = ScrollBars.Vertical;
            // ������ ������������ ������ � ������� �� ������:
            dataGridView1.DefaultCellStyle.Alignment =
            DataGridViewContentAlignment.MiddleCenter;
            // ��� �������� ���������� ������ � �������������
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i;
            // ���� � ��� 5 ��������� �������, ��������� ��� ����
            if (dataGridView1.ColumnCount == 5)
                dataGridView1.Columns.Add("Column5",
                "������ � ��������");
            dataGridView1.Columns[5].Width = 140;
            /* ������� �� ���� ������� �� ���������� �����
            ������������: */
            for (i = 0; i < dataGridView1.RowCount; i++)
                if (dataGridView1.Rows[i].Cells[2].Value != null
                && dataGridView1.Rows[i].Cells[3].Value != null
                && dataGridView1.Rows[i].Cells[4].Value != null)
                { // ���� ��� �����- ����� �������� �
                  // ����������� ������:
                    dataGridView1.Rows[i].Cells[5].Value = "�������";
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.MistyRose;
                }
        }
    }
}