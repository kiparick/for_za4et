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

namespace ЛАБА10_ЗАДАНИЕ2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string a = textBox1.Text;
            string b = textBox2.Text;
           

            try
            {
                double a_1 = Convert.ToDouble(a);
                double b_1 = Convert.ToDouble(b);
                double I = 0;
                I = b_1 / a_1;
                textBox3.Text = I.ToString();

            }
            catch (Exception ex)
            {

                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                Console.WriteLine("Вы не увидите это");

            }
        }
    }
}
