using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Temperature
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char) Keys.Enter)
            {
                double success;
                if ((textbox.Text.Length > 0) && (double.TryParse(textbox.Text, out success)))
                {
                    double result = Convert.ToDouble(textbox.Text);
                    if (result <= 35)
                        textbox.Text = "У вас гипотермия!";
                    else if (result >= 35.1f && result <= 37)
                        textbox.Text = "Это норма температуры. Вы здоровы.";
                    else if (result >= 37.1f && result <= 39)
                        textbox.Text = "У вас гипертермия! Вы заболели.";
                    else if (result >= 39.1f)
                        textbox.Text = "У вас гиперпирексия!";
                }
                else
                    textbox.Text = "Я вас не понимаю :(";
            }
        }
    }
}
