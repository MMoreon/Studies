﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace L.R._3._4
{
    public partial class Form2 : Form
    {
        public double a, b;
        public Form2()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.a = Convert.ToDouble(textBox1.Text);
                this.b = Convert.ToDouble(textBox2.Text);
                this.Close();
                
            }
            catch
            {
                MessageBox.Show("Проверьте корректность входных данных!", "Внимание"); }
            }

        }
    }
