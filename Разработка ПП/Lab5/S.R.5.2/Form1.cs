﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace S.R._5._2
{
    public partial class Form1 : Form
    {
        DateTime dataOne, dataTwo;

        private void button1_Click(object sender, EventArgs e)
        {
            dataOne = dateTimePicker1.Value;
            dataTwo = dateTimePicker2.Value;
            while (dataOne != dataTwo)
            {
                if (dataOne.DayOfWeek == DayOfWeek.Saturday) label4.Text += $"{dataOne}, суббота\n";
                if (dataOne.DayOfWeek == DayOfWeek.Sunday) label4.Text += $"{dataOne}, воскресенье\n";
                dataOne = dataOne.AddDays(1);
            }
        }

        public Form1()
        {
            InitializeComponent();
        }
    }
}
