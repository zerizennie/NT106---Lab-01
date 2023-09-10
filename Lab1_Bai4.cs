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
    public partial class Lab1_Bai4 : Form
    {
        public Lab1_Bai4()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1 || comboBox2.SelectedIndex == -1) MessageBox.Show("Vui lòng chọn giá trị cần chuyển đổi");
            else
            {
                int num;
                if (comboBox1.Text == "Hexadecimal")
                {
                    string input_hexa = textBox1.Text.Trim();
                    if (Int32.TryParse(input_hexa, System.Globalization.NumberStyles.HexNumber, null, out int value))
                    {
                        num = Convert.ToInt32(textBox1.Text, 16);
                        switch (comboBox2.Text)
                        {
                            case "Decimal":
                                textBox2.Text = num.ToString();
                                break;
                            case "Binary":
                                textBox2.Text = Convert.ToString(num, 2);
                                break;
                            case "Hexadecimal":
                                textBox2.Text = input_hexa.ToString();
                                break;
                        }
                    }
                    else MessageBox.Show("Nhập số hợp lệ!");
                }
                else
                {
                    if (int.TryParse(textBox1.Text, out num) && textBox1.Text.All(c => Char.IsDigit(c) && (c == '0' || c == '1')))
                    {
                        num = Int32.Parse(textBox1.Text.Trim());
                        switch (comboBox1.Text)
                        {
                            case "Decimal":
                                switch (comboBox2.Text)
                                {
                                    case "Binary":
                                        textBox2.Text = Convert.ToString(num, 2);
                                        break;
                                    case "Hexadecimal":
                                        textBox2.Text = Convert.ToString(num, 16);
                                        break;
                                    case "Decimal":
                                        textBox2.Text = textBox1.Text;
                                        break;
                                }
                                break;

                            case "Binary":
                                num = Convert.ToInt32(textBox1.Text, 2);
                                switch (comboBox2.Text)
                                {
                                    case "Decimal":
                                        textBox2.Text = num.ToString();
                                        break;
                                    case "Hexadecimal":
                                        textBox2.Text = Convert.ToString(num, 16);
                                        break;
                                    case "Binary":
                                        textBox2.Text = textBox1.Text;
                                        break;
                                }
                                break;

                        }
                    }
                    else MessageBox.Show("Nhập số hợp lệ!");
                }
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
