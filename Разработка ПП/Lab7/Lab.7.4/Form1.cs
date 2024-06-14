namespace Lab._7._4
{
    public partial class Form1 : Form
    {
        /* ���������� sky � plane ����� ���������
        ����������� ���� � �������� */
        private Bitmap sky, plane;
        // ������� �����������
        private Graphics g;
        /* ���������� ���������� �� X ����������
        �������� ������ - ��� ������ ����� ���������� dx ��
        ��������� �������� �������, ��� ���� ��������� */
        private int dx;
        // ������������ �������, � ������� ��������� �������
        private Rectangle rct;
        // ��������� ��������� �����
        private Random r;

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            { // ��������� ������� ������
              // ����:
                sky = new Bitmap(@"C:\Users\MM0r3\source\repos\Lab7\Lab.7.4\sky.jpg");
                // �������:
                plane = new Bitmap(@"C:\Users\MM0r3\source\repos\Lab7\Lab.7.4\Plane.png");
                plane.MakeTransparent();
                /*��������� ������� ���������� ���� ���� � ��������
                ���������� �����������, ��� ����� �����. �����
                MakeTransparent() ������ ���������� ���������� �����
                ��������������� ��� ������� ������� Bitmap. �����
                �������, ����� ����� ����� ������ �������, ��� ���
                ������ �������������� ���� */
            }
            catch (Exception exc)
            {
                MessageBox.Show("������ �������� ������� ������� \n" + exc.ToString(), "����� � �������", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }
            // ������� ������� �����:
            BackgroundImage = new Bitmap(@"C:\Users\MM0r3\source\repos\Lab7\Lab.7.4\Sky.jpg");
            /* ������ ������ �����, ��������������� ��������
            �������: */
            this.ClientSize = new Size
            (BackgroundImage.Width, BackgroundImage.Height);
            // ������ ������� ���� �������������
            this.FormBorderStyle =
            FormBorderStyle.FixedSingle;
            // ��������� ������ "����������"
            this.MaximizeBox = false;
            /* g - ����������� �����������, �� ������� �����
            ����������� ������� */
            g = Graphics.FromImage(BackgroundImage);
            // �������������� ��������� ��������� �����
            r = new Random();
            // ��������� ��������� ������� � ���������
            rct.X = -40;
            rct.Y = 20 + r.Next(20); //���������� �� y ��������
            rct.Width = plane.Width;
            rct.Height = plane.Height;
            /* �������� ������ ������������ �������� ��������
            ������� � ��������� ���������� dx */
            dx = 2;// �������� ������ - 2 �������/��� �������
            timer1.Interval = 20;
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // ������� ����������� �������� ����� ���������� ���� ������� �����:
            g.DrawImage(sky, 0, 0);
            // �������� ��������� ��������
            // ���� �� �������� �������, ��������� ���������� �� ���������� �:
            if (rct.X < this.ClientRectangle.Width) rct.X += dx;
            else
            { /* ���� �������� �������, ������ ���������
                �������� ������ */
                rct.X = -40;
                rct.Y = 20 + r.Next(this.ClientSize.Height -
                40 - plane.Height);
                // ������ �������� - �� 2 �� 6 ��������/��� �������
                dx = 2 + r.Next(5);
            }
            // ������ ������� �� ������� �����������
            g.DrawImage(plane, rct.X, rct.Y);
            // ������ ������� �������� � �������:
            // ������ ������������ �����
            Rectangle rct2 = new Rectangle(20, 20, sky.Width -
            40, sky.Height - 40);
            g.DrawRectangle(Pens.Black, rct2.X, rct2.Y, rct2.Width
            - 1, rct2.Height - 1);
            // ��������� �������
            this.Invalidate(rct2);
        }

        public Form1()
        {
            InitializeComponent();
            this.Text = "����� � �������";
        }
    }
}