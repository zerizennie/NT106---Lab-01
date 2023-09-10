using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab1_21522317_Võ_Thị_Bích_Ly
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bai1 bai1 = new Bai1();
            bai1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Lab1_Bai2 bai2 = new Lab1_Bai2();
            bai2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Lab1_Bai3 bai3 = new Lab1_Bai3();
            bai3.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Lab1_Bai4 bai4 = new Lab1_Bai4();
            bai4.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Lab1_Bai5 bai5 = new Lab1_Bai5();
            bai5.Show();
        }
    }
}
