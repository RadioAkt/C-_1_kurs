using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            if (textBox6.Text == "" & textBox7.Text == "")
            {
                MessageBox.Show("Введите значения m и n!!!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            } else if (textBox6.Text == "")
            {
                MessageBox.Show("Введите значения m!!!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            }
            else if (textBox7.Text == "")
            {
                MessageBox.Show("Введите значение n!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            } else
            {
                double m = Double.Parse(textBox6.Text);
                double n = Double.Parse(textBox7.Text);
                double x = (Math.Sqrt(m) + 1.27) / (Math.Log(n + m));
                double y = 0.8 * Math.Exp(0.1 * m);
                double c = y + 3.2 * Math.Sin(x * y + 1.8) + Math.Sqrt(Math.Abs(x - Math.Log(2.6 + x)));
                label8.Visible = true;
                label9.Visible = true;
                label10.Visible = true;
                textBox8.Visible = true;
                textBox9.Visible = true;
                textBox10.Visible = true;
                textBox8.Text = x.ToString();
                textBox9.Text = y.ToString();
                textBox10.Text = c.ToString();
                label8.Text = "x = ";
                label9.Text = "y = ";
                label10.Text = "c = ";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox6.Text = "";
            textBox7.Text = "";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textBox6.Text == "" & textBox7.Text == "")
            {
                MessageBox.Show("Введите значения m и n!!!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            }
            else if (textBox6.Text == "")
            {
                MessageBox.Show("Введите значения m!!!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            }
            else if (textBox7.Text == "")
            {
                MessageBox.Show("Введите значение n!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            }
            else
            {
                double m = Double.Parse(textBox6.Text);
                double n = Double.Parse(textBox7.Text);
                double x = Math.Exp(-Math.Sqrt(n / m));
                double t = Math.Log(m / Math.Sqrt(n)) + 7.21;
                double y = (Math.Cos(Math.Pow(x, 2) - Math.Sqrt(t) + Math.Sin(x - Math.Pow(t, 1 / 3)))) / (Math.Pow(Math.Sin(t - Math.Pow(x, 1 / 4)), 2) + 1.731);
                label8.Visible = true;
                label9.Visible = true;
                label10.Visible = true;
                textBox8.Visible = true;
                textBox9.Visible = true;
                textBox10.Visible = true;
                textBox8.Text = x.ToString();
                textBox9.Text = t.ToString();
                textBox10.Text = y.ToString();
                label8.Text = "x = ";
                label9.Text = "t = ";
                label10.Text = "y = ";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textBox6.Text == "" & textBox7.Text == "")
            {
                MessageBox.Show("Введите значения m и n!!!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            }
            else if (textBox6.Text == "")
            {
                MessageBox.Show("Введите значения m!!!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            }
            else if (textBox7.Text == "")
            {
                MessageBox.Show("Введите значение n!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            } else
            {
                if (checkBox5.Checked == false & checkBox6.Checked == false)
                {
                    MessageBox.Show("Выберите номер примера!!!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                }
                else if (checkBox5.Checked == true & checkBox6.Checked == true)
                {
                    MessageBox.Show("Выберите только один из номеров примера!!!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                }
                else
                {
                    if (checkBox5.Checked == true)
                    {
                        double m = Double.Parse(textBox6.Text);
                        double n = Double.Parse(textBox7.Text);
                        double x = Math.Exp(m / n);
                        double y = Math.Cos(m / Math.Sqrt(n));
                        double u = 0;
                        if (x + y < x * y)
                            u = x + y;
                        else if (x + y > x * y)
                            u = x * y;
                        else
                            u = 1;
                        label8.Visible = true;
                        label9.Visible = true;
                        label10.Visible = true;
                        textBox8.Visible = true;
                        textBox9.Visible = true;
                        textBox10.Visible = true;
                        textBox8.Text = x.ToString();
                        textBox9.Text = y.ToString();
                        textBox10.Text = u.ToString();
                        label8.Text = "x = ";
                        label9.Text = "y = ";
                        label10.Text = "u = ";
                        checkBox5.Checked = false;
                    }
                    else if (checkBox6.Checked == true)
                    {
                        double m = Double.Parse(textBox6.Text);
                        double n = Double.Parse(textBox7.Text);
                        double x = 3 * Math.Cos(n / m);
                        double z = 0;
                        if (x < 1)
                            z = x - 1.5;
                        else if (1 <= x & x < 2)
                            z = x + 2.5;
                        else
                            z = Math.Pow(x, 3) - 3.5;
                        label8.Visible = true;
                        label9.Visible = true;
                        label10.Visible = false;
                        textBox8.Visible = true;
                        textBox9.Visible = true;
                        textBox10.Visible = false;
                        textBox8.Text = x.ToString();
                        textBox9.Text = z.ToString();
                        label8.Text = "x = ";
                        label9.Text = "z = ";
                        checkBox6.Checked = false;
                    }
                }
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            textBox8.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textBox6.Text == "" & textBox7.Text == "")
            {
                MessageBox.Show("Введите значения m и n!!!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            }
            else if (textBox6.Text == "")
            {
                MessageBox.Show("Введите значения m!!!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            }
            else if (textBox7.Text == "")
            {
                MessageBox.Show("Введите значение n!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            }
            else
            {
                if (checkBox7.Checked == false & checkBox8.Checked == false)
                {
                    MessageBox.Show("Выберите номер примера!!!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                }
                else if (checkBox5.Checked == true & checkBox6.Checked == true)
                {
                    MessageBox.Show("Выберите только один из номеров примера!!!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
                }
                else
                {
                    if (checkBox7.Checked == true)
                    {
                        double m = Double.Parse(textBox6.Text);
                        double n = Double.Parse(textBox7.Text);
                        double y = 0;
                        double z = 0;
                        for (int k = 1; k <= 15; k++)
                            y += Math.Pow(-1, k) / (2 * k + m);
                        z = y * (y - 4) + 0.02 * n;
                        label8.Visible = true;
                        label9.Visible = true;
                        label10.Visible = false;
                        textBox8.Visible = true;
                        textBox9.Visible = true;
                        textBox10.Visible = false;
                        textBox8.Text = y.ToString();
                        textBox9.Text = z.ToString();
                        label8.Text = "y = ";
                        label9.Text = "z = ";
                        checkBox7.Checked = false;
                    } else if (checkBox8.Checked == true)
                    {
                        double m = Double.Parse(textBox6.Text);
                        double n = Double.Parse(textBox7.Text);
                        double v = 0;
                        double u = 0;
                        for (int k = 1; k <= 30; k++)
                            v += Math.Pow(-1, k + 1) / (m * k + 1);
                        v = m * v;
                        u = Math.Pow(v, 2) + (2 * v) - (0.2 * n);
                        label8.Visible = true;
                        label9.Visible = true;
                        label10.Visible = false;
                        textBox8.Visible = true;
                        textBox9.Visible = true;
                        textBox10.Visible = false;
                        textBox8.Text = v.ToString();
                        textBox9.Text = u.ToString();
                        label8.Text = "v = ";
                        label9.Text = "u = ";
                        checkBox8.Checked = false;
                    }
                }
            }
        }
    }
}
