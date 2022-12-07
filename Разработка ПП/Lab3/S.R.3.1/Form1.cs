using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace S.R._3._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void крупныйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Font = new Font("Times New Roman", 30);
        }

        private void среднийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Font = new Font("Times New Roman", 20);
        }

        private void мелкийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.Font = new Font("Times New Roman", 10);
        }

        private void красныйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Red;
        }

        private void зеленыйToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Green;
        }

        private void синийToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label1.ForeColor = Color.Blue;
        }
    }
}
