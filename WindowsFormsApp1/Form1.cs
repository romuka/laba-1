using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            string s = textBox3.Text;
            float R = Convert.ToSingle(s);

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            double h = Convert.ToSingle(textBox1.Text);
            double R = Convert.ToSingle(textBox3.Text);
           double L =  Convert.ToSingle(textBox2.Text);
            const double PI = 3.1415;
            double V = 0.3334 * PI * R * R * h;
            double S = PI * R * (L + R);
            if (checkBox1.Checked && checkBox2.Checked)
            {
                label1.Text = V.ToString() + ";" + S.ToString();
            }
            else if (checkBox1.Checked)
            {
                label1.Text = V.ToString();


            }
            else if (checkBox2.Checked)
            {
                label1.Text = S.ToString();
            }
            else
            {
                label1.Text = "Не выбран режим!";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string b = textBox2.Text;
            float l = Convert.ToSingle(b);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string a = textBox1.Text;
            float h = Convert.ToSingle(a);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
