using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zadachaa24
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                pictureBox1.Image = Image.FromFile(@"D:\GrachevaRusinova(swag)\zadachaa24\zadachaa24\fabia1.jpg");
                label1.Text = "Цена модели Fabia 2 = 500000";
            }
            if (radioButton2.Checked)
            {
                pictureBox1.Image = Image.FromFile(@"D:\GrachevaRusinova(swag)\zadachaa24\zadachaa24\fabia2.jpg");
                label1.Text = ("Цена модели Fabia RS = 1000000");
            }
            if (radioButton3.Checked)
            {
                pictureBox1.Image = Image.FromFile(@"D:\GrachevaRusinova(swag)\zadachaa24\zadachaa24\fabia3.jpg");
                label1.Text = ("Цена модели Fabia MK2 = 1500000");
            }




        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
