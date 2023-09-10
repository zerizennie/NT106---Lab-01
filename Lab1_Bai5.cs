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
    public partial class Lab1_Bai5 : Form
    {
        public Lab1_Bai5()
        {
            InitializeComponent();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] scores_string = textBox0.Text.Split(' ');
            int[] scores = new int[scores_string.Length];
            if (Array.TrueForAll(scores_string, s => int.TryParse(s, out int score)) && scores_string.Length<=12)
            {
                scores = Array.ConvertAll(scores_string, s => int.Parse(s));
                textBox1.Text = scores_string[0];
                textBox2.Text = scores_string[1];
                textBox3.Text = scores_string[2];
                textBox4.Text = scores_string[3];
                textBox5.Text = scores_string[4];
                textBox6.Text = scores_string[5];
                textBox7.Text = scores_string[6];
                textBox8.Text = scores_string[7];
                textBox9.Text = scores_string[8];
                textBox10.Text = scores_string[9];
                textBox11.Text = scores_string[10];
                textBox12.Text = scores_string[11];
                double avg = scores.Average();
                textBox13.Text = avg.ToString();
                textBox14.Text = scores.Max().ToString();
                textBox17.Text = scores.Min().ToString();
                switch (avg)
                {
                    case double n when n >= 8 && Array.TrueForAll(scores, x => x >= 6.5):
                        textBox16.Text = "Giỏi";
                        break;
                    case double n when n >= 6.5 && Array.TrueForAll(scores, x => x >= 5):
                        textBox16.Text = "Khá";
                        break;
                    case double n when n >= 5 && Array.TrueForAll(scores, x => x >= 3.5):
                        textBox16.Text = "TB";
                        break;
                    case double n when n >= 3.5 && Array.TrueForAll(scores, x => x >= 2):
                        textBox16.Text = "Yếu";
                        break;
                    default:
                        textBox16.Text = "Kém";
                        break;
                }
                int count_pass = 0;
                int count_not_pass = 0;
                foreach (int score in scores)
                {
                    if (score >= 5) count_pass++;
                    else count_not_pass++;
                }
                textBox15.Text = count_pass.ToString();
                textBox18.Text = count_not_pass.ToString();
            }
            else MessageBox.Show("Danh sách điểm không hợp lệ, nhập lại!");
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }
    }
}