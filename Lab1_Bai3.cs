using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
namespace Lab1_21522317_Võ_Thị_Bích_Ly
{
    public partial class Lab1_Bai3 : Form
    {
        public Lab1_Bai3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num;

            if (Int32.TryParse(textBox1.Text, out num))
            {
                if (num < 10000)
                {
                    string[] ones = { "không", "một", "hai", "ba", "bốn", "năm", "sáu", "bảy", "tám", "chín"};
                    string[] tens = { "", "mười", "hai mươi", "ba mươi", "bốn mươi", "năm mươi", "sáu mươi", "bảy mươi", "tám mươi", "chín mươi" };

                    string word = "";
                    string pad = "";
                    if (num < 10)
                    {
                        word = ones[num];
                    }
                    else if (num < 100)
                    {
                        if (num % 10 == 1) ones[1] = "mốt";
                        word = tens[num / 10] ;
                        if (num % 10 != 0) word += " " + ones[num % 10];
                    }
                    else if (num < 1000)
                    {
                        if ((num / 10) % 10 == 0 && num % 10 == 0) word = ones[num/100]+" trăm";
                        else
                        {
                            if ((num / 10) % 10 == 0 && (num % 10 != 0)) pad = "lẻ";
                            if (num % 10 == 1 && (num / 10) % 10 > 1)
                            {
                                word = ones[num / 100] + " trăm " + pad + tens[(num % 100) / 10] + " mốt";
                            }
                            else
                            {
                                word = ones[num / 100] + " trăm " + pad + tens[(num % 100) / 10] ;
                                if (num % 10 != 0) word += " " + ones[num % 10];
                            }
                        }
                    }
                    else if (num < 10000)
                    {
                        if ((num / 100) % 10 == 0 && (num / 10) % 10 == 0 && num % 10 == 0) word = ones[num/1000]+" nghìn";
                        else
                        {
                            if ((num / 10) % 10 == 0 && (num % 10 != 0)) pad = "lẻ";
                            if (num % 10 == 1 && (num / 10) % 10 > 1) word = ones[num / 1000] + " nghìn " + ones[(num % 1000) / 100] + " trăm " + pad + tens[(num % 100) / 10] + " mốt";
                            else
                            {
                                word = ones[num / 1000] + " nghìn " + ones[(num % 1000) / 100] + " trăm " + pad + tens[(num % 100) / 10] ;
                                if (num % 10 != 0) word +=" "+ ones[num % 10];
                            }
                        }
                    }

                    textBox2.Text = word;
                }
                else
                {
                    MessageBox.Show("Số bạn vừa nhập không hợp lệ!");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập một số nguyên.");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}



