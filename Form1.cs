using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace modul_103022330096
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
        }

        int a, b, jumlah;
        bool plus=false;

        private void button1_Click(object sender, EventArgs e)
        {
            plus = true;
            label2.Text = a + " + " + b;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (!plus)
            {
                a = a * 10 + 9;
            }
            else
            {
                b = b * 10 + 9;
            }
            label2.Text = a + " + " + b;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (!plus)
            {
                a = a * 10 + 8;
            }
            else
            {
                b = b * 10 + 8;
            }
            label2.Text = a + " + " + b;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (!plus)
            {
                a = a * 10 + 7;
            }
            else
            {
                b = b * 10 + 7;
            }
            label2.Text = a + " + " + b;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (!plus)
            {
                a = a * 10 + 6;
            }
            else
            {
                b = b * 10 + 6;
            }
            label2.Text = a + " + " + b;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (!plus)
            {
                a = a * 10 + 5;
            }
            else
            {
                b = b * 10 + 5;
            }
            label2.Text = a + " + " + b;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (!plus)
            {
                a = a * 10 + 4;
            }
            else
            {
                b = b * 10 + 4;
            }
            label2.Text = a + " + " + b;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (!plus)
            {
                a = a * 10 + 3;
            }
            else
            {
                b = b * 10 + 3;
            }
            label2.Text = a + " + " + b;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (!plus)
            {
                a = a * 10 + 2;
            }
            else
            {
                b = b * 10 + 2;
            }
            label2.Text = a + " + " + b;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (!plus)
            {
                a = a * 10 + 1;
            }
            else
            {
                b = b * 10 + 1;
            }
            label2.Text = a + " + " + b;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!plus)
            {
                a = a * 10 + 0;
            } else
            {
                b = b * 10 + 0;
            }
            label2.Text = a + " + " + b;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            jumlah = a + b;

            label2.Text = a + " + " + b;
            label1.Text = "Hasil = " + jumlah;
            a = jumlah;
            b = 0;

        }
    }
}
