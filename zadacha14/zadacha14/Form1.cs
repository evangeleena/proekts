﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zadacha14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int cena = 0;
            int n;
            int sum;
            if (radioButton1.Checked)
            { cena = 100; }
            if (radioButton2.Checked)
            { cena = 50; }
            n = Convert.ToInt32(textBox1.Text);
            sum = cena * n;
            textBox2.Text = Convert.ToString(sum);
        }
    }
}
