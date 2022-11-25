using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpeedCounter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public char sSeporator = ' ';
        public char tSeporator = ' ';

        public string[] sArrOfExceptions = new string[7] {"км", "м", "см", "фут", "миля", "мл", "дц"};
        public string[] tArrOfExceptions = new string[7] {"ч", "мин", "с", "д", "месяц", "г", "мс"};

        private void button1_Click(object sender, EventArgs e)
        {
            bool isSValid(string sValue)
            {
                for (int i = 0; i < sArrOfExceptions.Length; i++)
                    if (sValue == sArrOfExceptions[i]) return true;
                return false;
            }

            bool istValid(string tValue)
            {
                for (int i = 0; i < tArrOfExceptions.Length; i++)
                    if (tValue == tArrOfExceptions[i]) return true;
                return false;
            }

            string S = textBox2.Text;
            string t = textBox1.Text;

            for (int i = 0; i < S.Length; i++)
            {
                bool success = double.TryParse(S[i].ToString(), out double value);


                if (success)
                    continue;
                else
                {
                    sSeporator = Convert.ToChar(S[i]);
                    break;
                }
            }

            for (int i = 0; i < t.Length; i++)
            {
                bool success = double.TryParse(t[i].ToString(), out double value);

                if (success)
                    continue;
                else
                {
                    tSeporator = Convert.ToChar(t[i]);
                    break;
                }
            }

            if (sSeporator != ' ' && tSeporator != ' ')
            {
                string[] sArr = new string[S.Length];
                string[] tArr = new string[t.Length];

                sArr = S.Split(sSeporator);
                sArr[1] = sArr[1].Insert(0, sSeporator.ToString());

                tArr = t.Split(tSeporator);
                tArr[1] = tArr[1].Insert(0, tSeporator.ToString());

                // Console.WriteLine(tArr[1] + " " + tArr[0] + " " + sArr[1] + " " + sArr[0]);
                // Console.WriteLine(isSValid(sArr[1].ToString()) + " " + istValid(tArr[1].ToString()));

                bool sSuccess = double.TryParse(sArr[0], out double sValue);
                bool tSuccess = double.TryParse(tArr[0], out double tValue);

                if (
                        (sSuccess && tSuccess) && 
                        (sArr[1].ToString() != tArr[1].ToString()) && 
                        (sSeporator != ' ' && tSeporator != ' ') &&
                        (isSValid(sArr[1].ToString()) && istValid(tArr[1].ToString()))
                    )
                    label5.Text = "V = " + (Convert.ToDouble(sArr[0]) / Convert.ToDouble(tArr[0])).ToString() + sArr[1] + "/" + tArr[1];
                else
                    label5.Text = "V = ...";
            }
            else
                label5.Text = "V = ...";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            label5.Text = "V = ...";
        }
    }
}
