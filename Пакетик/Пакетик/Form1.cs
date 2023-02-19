using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Globalization;

namespace Пакетик
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private double[] massiv;
        private void button2_Click(object sender, EventArgs e)
        {
            string a = textBox1.Text;
            string b = textBox2.Text;
            string с = textBox3.Text;
            CultureInfo temp_culture = Thread.CurrentThread.CurrentCulture;
            Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("en-US");
            double a_1 = double.Parse(a);
            double b_1 = double.Parse(b);
            Thread.CurrentThread.CurrentCulture = temp_culture;
            int c_1 = Convert.ToInt32(с);
            double shag = (b_1 - a_1)/(c_1 - 1);
            massiv = new double [c_1];
            for (int i = 0; i<c_1; i++)
            {
                massiv[i] = a_1 + shag * i;
            }
            label6.Visible = true;
            textBox1.ReadOnly = true;
            textBox2.ReadOnly = true;
            textBox3.ReadOnly = true;
            button1.Enabled = true;
            textBox4.Enabled = true;
            button2.Enabled = false;
            if (b_1 <= a_1)
            {
                label7.Visible = true;
                button2.Enabled = false;
                textBox1.ReadOnly = true;
                textBox2.ReadOnly = true;
                textBox3.ReadOnly = true;
                label6.Visible = false;
                button1.Enabled = false;
                textBox4.Enabled = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (massiv == null) return;
            string d = textBox4.Text;
            string b = textBox2.Text;
            string a = textBox1.Text;
            string с = textBox3.Text;
            int c_1 = Convert.ToInt32(с);
            int d_1 = Convert.ToInt32(d);
            CultureInfo temp_culture = Thread.CurrentThread.CurrentCulture;
            Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture("en-US");
            double b_1 = double.Parse(b);
            double a_1 = double.Parse(a);
            Thread.CurrentThread.CurrentCulture = temp_culture;

            double znach = 0;
            if (d_1 > c_1)
            {
                textBox5.BackColor = Color.Red;
                textBox5.Clear();
                label8.Visible = true;
            }
            if (d_1 < 1)
            {
                textBox5.BackColor = Color.Red;
                textBox5.Clear();
                label8.Visible = true;
            }
            if (d_1 >= 1)
            { if (d_1 <= c_1)
                {
                    textBox5.BackColor = Color.White;
                    label8.Visible = false;
                    znach = massiv[d_1 - 1];
                    textBox5.Text = znach.ToString();
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox5.BackColor = Color.White;
            label6.Visible = false;
            label7.Visible = false;
            button1.Enabled = false;
            textBox4.Enabled = false;
            textBox1.ReadOnly = false;
            textBox2.ReadOnly = false;
            textBox3.ReadOnly = false;
            button2.Enabled = true;
            label8.Visible = false;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (ch == 45 && textBox1.Text.IndexOf("-") != -1)
            {
                e.Handled = true;
                return;
            }
            if (ch == 46 && textBox1.Text.IndexOf(".") != -1)
            {
                e.Handled = true;
                return;
            }
            if (!Char.IsDigit(ch) && ch != 8 && ch != 45 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (ch == 45 && textBox2.Text.IndexOf("-") != -1)
            {
                e.Handled = true;
                return;
            }
            if (ch == 46 && textBox2.Text.IndexOf(".") != -1)
            {
                e.Handled = true;
                return;
            }
            if (!Char.IsDigit(ch) && ch != 8 && ch != 45 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
