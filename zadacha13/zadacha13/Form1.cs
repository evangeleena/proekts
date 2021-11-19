using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zadacha13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string textSum = textBox1.Text;
            int p = Convert.ToInt32(textSum);

            string textMes = textBox2.Text;
            int BB = Convert.ToInt32(textMes);
            int BBB = BB / 12;
            int t = BBB + 1; 

            string textProc = textBox3.Text;
            int n = Convert.ToInt32(textProc);

            int Sum = p + (p * t * n) / 100;
            textBox4.Text = Convert.ToString(Sum);

        }
    }
}
