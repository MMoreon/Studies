namespace Lab._7._2
{
    public partial class Form1 : Form
    {
        // ������ Kurs ����� ��������� ����� �������:
        private double[] Kurs;
        // ��������� ����� ��� ������:
        public StreamReader potok;
        string path = @"C:\Users\MM0r3\source\repos\Lab7\Lab.7.2\������.txt";
        public Form1()
        {
            InitializeComponent();
            this.BackColor = System.Drawing.Color.White;
            try
            { //������� ������ stream ���� FileStream:
                FileStream stream = new FileStream(path, FileMode.Open, FileAccess.Read);
                /*(�����������, ���� ��� ������ ���� ������ �� ����� ������) */
                // ������� ����� ��� ������ � ��������� ������;
                potok = new System.IO.StreamReader(stream);
                /* ������������ � ���������� n ���������� ������� �
                �����: */
                int n = 0;
                string t = potok.ReadLine();
                while (t != null)
                {
                    t = potok.ReadLine();
                    n++;
                }
                /* ������������� ��������� �� ������ ������(�.�.
                ������ ReadLine() �������� ��� � ����� �����): */
                stream.Seek(0, SeekOrigin.Begin);
                // �������������� ������
                Kurs = new double[n];
                /* ��������� ������ � ������ ������� � ��������� t,
                ����� ������������ � �������� ������ � ��������� �
                ������ Kurs: */
                int i = 0;
                t = potok.ReadLine();
                while (t != null)
                {
                    // ���������� ��������� ����� � ������
                    Kurs[i] = Convert.ToDouble(t);
                    t = potok.ReadLine();
                    i++;
                }
                // ��������� �����
                potok.Close();
                // ���� ������� ���
                if (Kurs.Length == 0)
                    MessageBox.Show("���� �������� ������ ����", "������",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                else this.Paint += new
                PaintEventHandler(drawDiagram);
                /* ��������� ���������� ��������� drawDiagram �����
                ���������� ������ ���, ����� ����� �����������
                ����������� ����� */
            } // (������� ���� try)
              // ��������� ����������:
              // ���� �������� ������ �� ������:
            catch (FileNotFoundException exc)
            {
                MessageBox.Show("���� �������� ������ �� ������" + "\n" + exc.Message);
            }
            // ������ ������� �������� ������
            catch (FormatException exc)
            {
                MessageBox.Show("������ ������� �������� ������" + "\n" + exc.Message);
            }
            // ������ ���������� (������� ����� ������):
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        private void drawDiagram(object sender, PaintEventArgs e)
        { // ����������� �����������:
            Graphics g = e.Graphics;
            // ������ ����� ���������:
            Font font1 = new Font("Arial", 11, FontStyle.Bold);
            // ������ ����� ��� ������� ��������:
            Font font2 = new Font("Tahoma", 10, FontStyle.Regular);
            /*������� ��������� ������ ������, ������� �
            ��������� (20,10): */
            g.DrawString("��������� ����� �������", font1,
            Brushes.Black, 20, 10);
            /* ���������� ���������� ����� ������ ������� �� ���
            x: */
            int d = (int)((this.ClientSize.Width - 20) / (Kurs.Length - 1));
            /* ���� ������������ � ����������� �������� (�� ����
            �������� ����� ������������� ��� �����������
            ������������ ��������� �����) */
            double maxKurs = Kurs[0];
            double minKurs = Kurs[0];
            for (int i = 0; i < Kurs.Length; i++)
            {
                if (Kurs[i] > maxKurs) maxKurs = Kurs[i];
                if (Kurs[i] < minKurs) minKurs = Kurs[i];
            }
            // ������ ������:
            int x1, y1, x2, y2;
            // ������ ���������� ������ �����:
            x1 = 8;
            y1 = this.ClientSize.Height - 20 - (int)((this.ClientSize.Height - 70) * (Kurs[0] - minKurs) / (maxKurs - minKurs));
            // ������ �������������- ����� ������� ����:
            g.DrawRectangle(Pens.Black, x1 - 2, y1 - 2, 4, 4);
            // ���������� ���������� ��������� �����:
            for (int i = 1; i < Kurs.Length; i++)
            {
                x2 = 8 + i * d;
                y2 = this.ClientSize.Height - 20 - (int)((this.ClientSize.Height - 70) * (Kurs[i] - minKurs) / (maxKurs - minKurs));
                // ������ �������������- ����� ���������� ����:
                g.DrawRectangle(Pens.Black, x2 - 2, y2 - 2, 4, 4);
                // ��������� ���� ������:
                g.DrawLine(Pens.Black, x1, y1, x2, y2);
                // ����������� ��������:
                g.DrawString(Convert.ToString(Kurs[i - 1]),
                font2, Brushes.Black, x1 - 5, y1 - 20);
                x1 = x2;
                y1 = y2;
            } // ��� for
              // ����������� ��������� ���� �������:
            g.DrawString(Convert.ToString(Kurs[Kurs.Length - 1]), font2, Brushes.Black, x1 - 20, y1 - 20);
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            this.Refresh();
        }
    }
}