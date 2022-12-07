using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace L.R._3._5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

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
    }
}

