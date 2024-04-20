using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ЛАБА10_ЗАДАНИЕ2
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string a = textBox1.Text;
            string b = textBox2.Text;
            string c = textBox3.Text;

            try
            {
                double a_1 = Convert.ToDouble(a);
                double b_1 = Convert.ToDouble(b);
                double c_1 = Convert.ToDouble(c);
                double R12 = 0;
                R12 = a_1*b_1/b_1+a_1;
                double I = 0;
                I = c_1/R12;
                
                textBox4.Text = I.ToString();

            }
            catch (Exception ex)
            {

                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                Console.WriteLine("Вы не увидите это");

            }
        }
    }
}
