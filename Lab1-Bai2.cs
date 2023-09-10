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
    public partial class Lab1_Bai2 : Form
    {
        public Lab1_Bai2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double num1, num2, num3, min, max;
            if (double.TryParse(textBox1.Text, out  num1) && double.TryParse(textBox2.Text, out num2) && double.TryParse(textBox3.Text, out num3))
            {
                max = Math.Max(num1, Math.Max(num2, num3));
                min = Math.Min(num1, Math.Min(num2, num3));
                textBox4.Text = max.ToString();
                textBox5.Text = min.ToString();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập 3 số  hợp lệ!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
