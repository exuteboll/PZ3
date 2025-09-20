using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace yaica
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

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                double a = double.Parse(textBox1.Text);
                double b = double.Parse(textBox2.Text);
                double c = double.Parse(textBox3.Text);
                double x = double.Parse(textBox4.Text);

                double F;

                if (a < 0 && x != 0)
                {
                    F = a - Math.Pow(x, 2) + Math.Pow(b, 2) * x;
                }
                else if (a > 0 && x == 0)
                {
                    if (x == c)
                    {
                        MessageBox.Show("Ошибка: деление на ноль (x = c).");
                        return;
                    }
                    F = x - (a / (x - c));
                }
                else
                {
                    if (c == 0)
                    {
                        MessageBox.Show("Error: деление на ноль (c = 0).");
                        return;
                    }
                    F = (x / c) + 1;
                }

                labelResult.Text = "ф = " + F.ToString("F2");
            }
            catch
            {
                MessageBox.Show("Ошибка ввода! Введите корректные числа.");
            }
        }
    }
}
