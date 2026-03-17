using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3
{
    public partial class Form1 : Form
    {
        Form fr2;
        public Form1()
        {
            InitializeComponent();
            fr2 = new Form2();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double m = 8;
            double n = 103;
            double x = (Math.Sqrt(m) + 1.27) / (Math.Log(n + m));
            double y = 0.8 * Math.Exp(0.1 * m);
            double c = y + 3.2 * Math.Sin(x * y + 1.8) + Math.Sqrt(Math.Abs(x - Math.Log(2.6 + x)));
            textBox1.Text = c.ToString();
            textBox2.Text = x.ToString();
            textBox3.Text = y.ToString();
            CheckBox ch1 = (CheckBox)fr2.Controls["checkbox1"];
            CheckBox ch2 = (CheckBox)fr2.Controls["checkbox2"];
            textBox1.Visible = true;
            textBox2.Visible = ch1.Checked;
            textBox3.Visible = ch2.Checked;
            label1.Visible = true;
            label2.Visible = ch1.Checked;
            label3.Visible = ch2.Checked;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fr2.Show();
        }
    }
}
