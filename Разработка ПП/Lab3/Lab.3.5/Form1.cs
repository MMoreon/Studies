using System.Windows.Forms;

namespace Lab._3._5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            trackBar1.Maximum = 100;
            trackBar1.Minimum = 0;
            trackBar1.Value = 50;
            trackBar1.TickFrequency = 10;
            label1.Text = Convert.ToString(trackBar1.Value) + "%";
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            float a, b;
            a = pictureBox1.Image.PhysicalDimension.Width;
            b = pictureBox1.Image.PhysicalDimension.Height;
            label1.Text = Convert.ToString(trackBar1.Value) + "%";
            pictureBox1.Width = (Int16)(a / 50 * trackBar1.Value);
            pictureBox1.Height = (Int16)(b / 50 * trackBar1.Value);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}