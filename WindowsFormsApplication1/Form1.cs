using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimeNumbers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int p; 
     
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int q = 1, c = 0;
            long a = -1;
            char[] d;


            d = textBox1.Text.ToCharArray();

            for (int i = 0; i < textBox1.Text.Length; i++)
            {
                q = 0;
                for (int j = 48; j <= 57; j++)
                    if (d[i] == j)
                        q = 1;
                if (q == 0)
                {
                    p = 0;
                    goto a;
                }
                else
                    p = 1;
            }

        a:
            if (textBox1.Text == "")
                label2.Text = " ";
            else if (p == 1)
                a = int.Parse(textBox1.Text);
            else
                a = -2;

            for (int i = 1; i <= a; i++)
                if (a % i == 0)
                    c++;

            if (a == -1)
                label2.Text = "";
            else if (a == -2)
            {

                label2.Text = "\" " + textBox1.Text + " \" is not a number";
                label2.ForeColor = Color.Red; 
            }
            else if (a == 0 || a == 1)
            {
                label2.Text = a + " is not Prime or Non Prime";

                label2.ForeColor = Color.HotPink; 
            }
            else if (c <= 2)
            {
                label2.Text = a + " is a Prime number. ";
                label2.ForeColor = Color.Green; 
            }
            else
            {
                label2.Text = a + " is not a Prime number.";
                label2.ForeColor = Color.OrangeRed; 
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}
