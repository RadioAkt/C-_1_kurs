using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Label label1, label2, label3;
        TextBox textBox1, textBox2, textBox3;
        Button button1;
        private void Form1_Load(object sender, EventArgs e)
        {
            Label label1 = new Label();
            label1.Text = "m = ";
            panel6.Controls.Clear();
            panel6.Controls.Add(label1);
            Label label2 = new Label();
            label2.Text = "n = ";
            panel2.Controls.Clear();
            panel2.Controls.Add(label2);
            Label label3 = new Label();
            label3.Text = "c = ";
            panel4.Controls.Clear();
            panel4.Controls.Add(label3);
            textBox1 = new TextBox();
            panel1.Controls.Add(textBox1);
            textBox2 = new TextBox();
            panel3.Controls.Add(textBox2);
            textBox3 = new TextBox();
            panel5.Controls.Add(textBox3);
            button1 = new Button();
            button1.Text = "OK";
            panel7.Controls.Add(button1);
            button1.Click += Button1_Click;
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            double m = Double.Parse(textBox1.Text);
            double n = Double.Parse(textBox2.Text);
            double x = (Math.Sqrt(m) + 1.27) / (Math.Log(n + m));
            double y = 0.8 * Math.Exp(0.1 * m);
            double c = y + 3.2 * Math.Sin(x * y + 1.8) + Math.Sqrt(Math.Abs(x - Math.Log(2.6 + x)));
            textBox3.Text = Math.Round(c, 7).ToString();
        }
    }
}
