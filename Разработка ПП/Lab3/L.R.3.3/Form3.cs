﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace L.R._3._3
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Activated(object sender, EventArgs e)
        {
            this.label1.Text = "Приложение написано студентом потока ПиНб-21 \nСелезеневым Никитой Викторовичем, 2022";
        }

        private void button1_Click(object sender, EventArgs e)
        { this.Close(); }
    }
}
