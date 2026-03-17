using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox2.Visible = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox1.Visible = true;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "" & comboBox2.Text == "")
            {
                MessageBox.Show("Выберите значения m и n!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            }
            else if (comboBox1.Text == "")
            {
                MessageBox.Show("Выберите значения m!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            }
            else if (comboBox2.Text == "")
            {
                MessageBox.Show("Выберите значения n!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            }
            else
            {
                double m = Double.Parse(comboBox1.Text);
                double n = Double.Parse(comboBox2.Text);
                if (listBox1.SelectedItem.ToString() == "1")
                {
                    listBox5.DataSource = null;
                    listBox5.Visible = true;
                    listBox6.Visible = true;
                    label3.Visible = true;
                    label4.Visible = true;
                    double y;
                    for (double x = 0; x <= 3.2; x += 0.2)
                    {
                        double z = (m * x) / (n * Math.Log(x));
                        y = Math.Pow(2, z);
                        listBox5.Items.Add(Math.Round(x, 5));
                        listBox6.Items.Add(Math.Round(y, 5));
                    }
                }
                if (listBox1.SelectedItem.ToString() == "2")
                {
                    listBox5.Items.Clear();
                    listBox6.Items.Clear();
                    listBox5.Visible = true;
                    listBox6.Visible = false;
                    label3.Visible = false;
                    label4.Visible = false;
                    double a = 2;
                    double b = 4.1;
                    double h = 0.2;
                    int k = (int)((b - a) / h + 1);
                    string[] s = new string[k];
                    double x, y;
                    x = a;
                    for (int i = 0; i < k; i++)
                    {
                        double z_2 = Math.Exp(Math.Pow(-x, 2)) + 5;
                        double z_1 = x + (n / m);
                        y = z_2 / z_1;
                        s[i] = "y(" + x.ToString() + ") = " + Math.Round(y, 5).ToString();
                        x += h;
                    }
                    listBox5.DataSource = s;
                }
            }
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "" & comboBox2.Text == "")
            {
                MessageBox.Show("Выберите значения m и n!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            }
            else if (comboBox1.Text == "")
            {
                MessageBox.Show("Выберите значения m!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            }
            else if (comboBox2.Text == "")
            {
                MessageBox.Show("Выберите значения n!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            }
            else
            {
                double m = Double.Parse(comboBox1.Text);
                double n = Double.Parse(comboBox2.Text);
                if (listBox2.SelectedItem.ToString() == "1")
                {

                    chart1.Series[0].Points.Clear();
                    chart1.Visible = true;
                    double y;
                    for (double x = 0; x <= 3.2; x += 0.2)
                    {
                        double z = (m * x) / (n * Math.Log(x));
                        y = Math.Pow(2, z);
                        listBox5.Items.Add(Math.Round(x, 5));
                        listBox6.Items.Add(Math.Round(y, 5));
                        this.chart1.Series[0].Points.AddXY(Math.Round(x, 5), y);
                    }
                }
                if (listBox2.SelectedItem.ToString() == "2")
                {
                    chart1.Series[0].Points.Clear();
                    chart1.Visible = true;
                    double y;
                    for (double x = -2; x <= 2.2; x += 0.2)
                    {
                        double z_2 = Math.Exp(Math.Pow(-x, 2)) + 5;
                        double z_1 = x + (n / m);
                        y = z_2 / z_1;
                        this.chart1.Series[0].Points.AddXY(Math.Round(x, 5), y);
                    }
                }
            }
        }

        private void listBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text == "" & comboBox2.Text == "")
            {
                MessageBox.Show("Выберите значения m и n!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            }
            else if (comboBox1.Text == "")
            {
                MessageBox.Show("Выберите значения m!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            }
            else if (comboBox2.Text == "")
            {
                MessageBox.Show("Выберите значения n!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
            }
            else
            {
                double m = Double.Parse(comboBox1.Text);
                double n = Double.Parse(comboBox2.Text);
                if (listBox3.SelectedItem.ToString() == "1")
                {
                    dataGridView1.Visible = true;
                    dataGridView1.Columns.Clear();
                    dataGridView1.Rows.Clear();
                    dataGridView1.Columns.Add("", "x / y");
                    double a = -1;
                    double b = 1;
                    double h = 0.4;
                    double c = 1.25;
                    double d = 3;
                    double l = 0.25;
                    double z;
                    for (double x = a; x <= b; x += h)
                    {
                        dataGridView1.Rows.Add(x.ToString());
                    }
                    for (double y = c; y <= d; y += l)
                    {
                        dataGridView1.Columns.Add("", y.ToString());
                    }
                    int row = 0;
                    for (double x = a; x <= b; x += h)
                    {
                        int colums = 1;
                        for (double y = c; y <= d; y += l)
                        {
                            z = (Math.Log(x + y +  n)) / (m * (x + y));
                            dataGridView1.Rows[row].Cells[colums].Value = Math.Round(z, 5);
                            colums++;
                        }
                        row++;
                    }
                }
                if (listBox3.SelectedItem.ToString() == "2")
                {
                    double a = 0.4;
                    double b = 1;
                    double h = 0.1;
                    double c = 0;
                    double d = 1;
                    double l = 0.2;
                    double z;
                    dataGridView1.Visible = true;
                    dataGridView1.Columns.Clear();
                    dataGridView1.Rows.Clear();
                    dataGridView1.Columns.Add("", "x / y");
                    for (double x = a; x <= b; x += h)
                    {
                        dataGridView1.Rows.Add(x.ToString());
                    }
                    for (double y = c; y <= d; y += l)
                    {
                        dataGridView1.Columns.Add("", y.ToString());
                    }
                    int row = 0;
                    for (double x = a; x <= b; x += h)
                    {
                        int columns = 1;
                        for (double y = c; y <= d; y += l)
                        {
                            z = Math.Pow(m * m / n, x + 3 * y);
                            dataGridView1.Rows[row].Cells[columns].Value = Math.Round(z, 5);
                            columns++;
                        }
                        row++;
                    }
                }
            }
        }

        private void listBox4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox4.SelectedItem.ToString() == "1")
            {
                string[] lines = File.ReadAllLines(openFileDialog1.FileName);
                string s;
                string f = "";
                for (int i = 0; i < 5; i++)
                {
                    s = lines[i];
                    string[] y = s.Split(' ');
                    for (int j = 0; j < 5; j++)
                    {
                        double x = Convert.ToDouble(y[j]);
                        if (x > 2 & x < 3)
                        {
                            f += x.ToString() + " ";
                        }
                    }
                }
                File.WriteAllText(saveFileDialog1.FileName, f, Encoding.Default);
            }
            if (listBox4.SelectedItem.ToString() == "2")
            {
                StreamReader sr = new StreamReader(openFileDialog1.FileName); 
                StreamWriter sw = new StreamWriter(saveFileDialog1.FileName); 
                string l;
                string[] f;
                double y;
                for (int i = 0; i < 5; i++)
                {
                    int i1 = i + 1;
                    l = sr.ReadLine();
                    f = l.Split(' ');
                    for (int j = 0; j < f.Length; j++)
                    {
                        int j1 = j + 1;
                        y = Convert.ToDouble(f[j]);
                        if (i1 + j1 > 7)
                        {
                            sw.WriteLine(y.ToString());
                        }
                    }
                }
                sr.Close();
                sw.Close();
            }
        }

        private void listBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {
            chart1.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox3.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox4.Visible = true;
            openFileDialog1.ShowDialog();
            saveFileDialog1.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Visible = false;
            listBox5.DataSource = null;
            listBox5.Items.Clear();
            listBox6.Items.Clear();
            listBox5.Visible = false;
            listBox6.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            chart1.Series[0].Points.Clear();
            chart1.Visible = false;
            listBox2.Visible = false;
            listBox3.Visible = false;
            dataGridView1.Rows.Clear();
            dataGridView1.Visible = false;
            listBox4.Visible = false;
        }
    }
}
