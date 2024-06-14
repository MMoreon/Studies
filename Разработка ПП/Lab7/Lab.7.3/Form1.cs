namespace Lab._7._3
{
    public partial class Form1 : Form
    {
        // ��������� ������ �������� ��������:
        private double[] K;
        // ��������� ������ ��������:
        private string[] L;
        // ����� ��������� ������� �����:
        private double sum;
        // ���������� ��������� � �����:
        private int n = 0;
        private string path = @"C:\Users\MM0r3\source\repos\Lab7\Lab.7.3\������.txt";
        // ��������� ����� ��� ������:
        public StreamReader potok;
        public Form1()
        {
            InitializeComponent();
            // ������ ���� �����:
            this.BackColor = System.Drawing.Color.White;
            try
            { // ������� ������ stream ���� FileStream:
                FileStream stream = new FileStream(path, FileMode.Open, FileAccess.Read);
                //(�����������, ���� ��� ������ ���� ������)
                // ������� ����� ��� ������ � ��������� ������:
                potok = new
                StreamReader(stream);
                //������������ � ���������� n ���������� ������� � �����:
                string t = potok.ReadLine();
                while (t != null)
                {
                    t = potok.ReadLine();
                    n++;
                }
                /* ������������� ��������� �� ������ ������ (�.�.
                ������ ReadLine() �������� ��� � ����� �����) */
                stream.Seek(0, SeekOrigin.Begin);
                // �������������� �������
                K = new double[n];
                L = new string[n];
                int i = 0;
                t = potok.ReadLine();
                while (t != null)
                {
                    // ���������� ����� �� ������� � ������:
                    K[i] = Convert.ToDouble(t.Substring(0, t.IndexOf(" ")));
                    // ���������� � ����� �����:
                    sum += K[i];
                    //��������� ����� ����� �������, ������� � ������ L:
                    L[i] = t.Substring(t.IndexOf(" "));
                    // ��������� ��������� ������
                    t = potok.ReadLine();
                    i++;
                } // ��� while
                  // ��������� �����
                potok.Close();
                // ���� ������� ���
                if (K.Length == 0)
                    MessageBox.Show("���� �������� ������ ����");
                else this.Paint += new PaintEventHandler(drawDiagram);
            } // ��� try
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

        // ��������� ���������:
        private void drawDiagram(object sender, PaintEventArgs e)
        {
            // ����������� �����������:
            Graphics g = e.Graphics;
            // ������ ����� ���������:
            Font font1 = new Font("Arial", 11,
            FontStyle.Bold);
            // ������ ����� �������:
            Font font2 = new
            Font("Tahoma", 10, FontStyle.Regular);
            /* ������� ��������� ������ ������, ������� �
            ��������� (20,10): */
            g.DrawString("��������� ������������ �������� - ���������", font1, Brushes.Black, 20, 10);
            // ������� ������� �������� ���������
            int d = (int)(this.ClientSize.Height * 4 / 5 - 40);
            // ��������� �����:
            int x = 30;
            int y = (int)((this.ClientSize.Height - d) / 2 + 10);
            /* ���������� �������� ������ ���� ��������������
            ������� */
            int lx = 60 + d;
            int ly = y + (int)((d - n * 20 + 10) / 2);
            // ��������� ����� ���� �������
            int M = -90;
            // ���� ���� �������
            int alpha;
            // ����� ��� ������� ������� ���������
            Brush fBrush = Brushes.White;
            // ������ ���������
            for (int i = 0; i < K.Length; i++)
            { // ���������� ����:
                alpha = (int)(360 * (K[i] / sum)) + 1;
                /* ���������� ���� �������� (��������,
                �������������� �������� 10 ��������)*/
                switch (i)
                {
                    case 0: fBrush = Brushes.Azure; break;
                    case 1: fBrush = Brushes.LightGreen; break;
                    case 2: fBrush = Brushes.DeepPink; break;
                    case 3: fBrush = Brushes.Violet; break;
                    case 4: fBrush = Brushes.MistyRose; break;
                    case 5: fBrush = Brushes.RoyalBlue; break;
                    case 6: fBrush = Brushes.SteelBlue; break;
                    case 7: fBrush = Brushes.Chocolate; break;
                    case 8: fBrush = Brushes.LightGray; break;
                    case 9: fBrush = Brushes.Gold; break;
                }
                // ������ ���������
                g.FillPie(fBrush, x, y, d, d, M, alpha);
                // ������� �������
                g.DrawPie(System.Drawing.Pens.Black, x, y, d, d, M, alpha);
                // ��������� ����� ���� ��� ���������� �������
                M = M + (int)(360 * (K[i] / sum)) + 1;
                // �������:
                // ������ ����������� �������������:
                g.FillRectangle(fBrush, lx, ly + i * 20, 20, 10);
                // ������ ������ ������ ��������������:
                g.DrawRectangle(System.Drawing.Pens.Black, lx, ly
                + i * 20, 20, 10);
                /* ������� ������� (����� �� ������� L + ��������
                � ���������): */
                g.DrawString(L[i] + ":" + Convert.ToDouble(K[i] / sum * 100).ToString("N") + "%", font2, Brushes.Black, lx + 20, ly + i * 20 - 4);
            }
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            this.Refresh();
        }
    }
}