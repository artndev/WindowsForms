using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp12_calc
{
    public partial class Form1 : Form
    {   
        char cur_operation = ' ';
        double a = 0, b = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button_1_Click(object sender, EventArgs e)
        {
            label.Text = label.Text + "1";
        }

        private void button_2_Click(object sender, EventArgs e)
        {
            label.Text = label.Text + "2";
        }

        private void button_3_Click(object sender, EventArgs e)
        {
            label.Text = label.Text + "3";
        }

        private void button_0_Click(object sender, EventArgs e)
        {
            label.Text = label.Text + "0";
        }

        private void button_4_Click(object sender, EventArgs e)
        {
            label.Text = label.Text + "4";
        }

        private void button_5_Click(object sender, EventArgs e)
        {
            label.Text = label.Text + "5";
        }

        private void button_6_Click(object sender, EventArgs e)
        {
            label.Text = label.Text + "6";
        }

        private void button_7_Click(object sender, EventArgs e)
        {
            label.Text = label.Text + "7";
        }

        private void button_8_Click(object sender, EventArgs e)
        {
            label.Text = label.Text + "8";
        }

        private void button_9_Click(object sender, EventArgs e)
        {
            label.Text = label.Text + "9";
        }

        private void button_point_Click(object sender, EventArgs e)
        {
            label.Text = label.Text + ",";
        }





        private void button_equal_Click(object sender, EventArgs e)
        {
            if (label.Text.Length != 0)
            {
                b = Convert.ToDouble(label.Text);
                if (cur_operation == '+') a = a + b;
                else if (cur_operation == '-') a = a - b;
                else if (cur_operation == '*') a = a * b;
                else if (cur_operation == '/') a = a / b;
                else if (cur_operation == '%') a = a / 100 * b;
                label.Text = a.ToString();
                cur_operation = ' ';
            }
        }


        private void button_minus_Click(object sender, EventArgs e)
        {
            if (label.Text.Length != 0)
            {
                cur_operation = '-';
                a = Convert.ToDouble(label.Text);
                label.Text = "";
            }
        }

        private void button_multiply_Click(object sender, EventArgs e)
        {
            if (label.Text.Length != 0)
            {
                cur_operation = '*';
                a = Convert.ToDouble(label.Text);
                label.Text = "";
            }
        }

        private void button_divide_Click(object sender, EventArgs e)
        {
            if (label.Text.Length != 0)
            {
                cur_operation = '/';
                a = Convert.ToDouble(label.Text);
                label.Text = "";
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (label.Text.Length != 0)
                label.Text = label.Text.Remove(label.Text.Length - 1);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (label.Text.Length != 0)
            {
                a = Convert.ToDouble(label.Text);
                label.Text = Convert.ToString(a * -1);
            }
        }

        private void button_sqrt_Click(object sender, EventArgs e)
        {
            if (label.Text.Length != 0)
            {
                a = Math.Sqrt(Convert.ToDouble(label.Text));
                label.Text = a.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (label.Text.Length != 0)
            {
                a = Convert.ToDouble(label.Text);
                label.Text = Convert.ToString(a * a);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (label.Text.Length != 0)
            {
                a = Convert.ToDouble(label.Text);
                label.Text = Convert.ToString(1 / a);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label.Text = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (label.Text.Length != 0)
            {
                cur_operation = '%';
                a = Convert.ToDouble(label.Text);
                label.Text = "";
            }
        }

        private void button_plus_Click(object sender, EventArgs e)
        {
            if (label.Text.Length != 0)
            {
                cur_operation = '+';
                a = Convert.ToDouble(label.Text);
                label.Text = "";
            }
        }
    }
}
