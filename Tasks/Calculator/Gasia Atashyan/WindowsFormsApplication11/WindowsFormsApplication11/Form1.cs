using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication11
{
    public partial class Form1 : Form
    {
        public string a = "";
        public int result = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            a += "1";
            textBox1.Text = a;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            a += "2";
            textBox1.Text = a;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            a += "3";
            textBox1.Text = a;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            a += "4";
            textBox1.Text = a;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            a += "5";
            textBox1.Text = a;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            a += "6";
            textBox1.Text = a;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            a += "7";
            textBox1.Text = a;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            a += "8";
            textBox1.Text = a;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            a += "9";
            textBox1.Text = a;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            a += "+";
            textBox1.Text = a;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            a += "-";
            textBox1.Text = a;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            
            int i = 0;
           while(i!=a.Length)
            {
                while (i != a.Length && a[i] != '+' && a[i] != '-' )
                {
                    result = result * 10 + (a[i]-'0');
                    i++;
                }

                if (i != a.Length && a[i] == '+')
                {
                    i++;
                    int secondOperand = 0;
                    while (i != a.Length && a[i] != '+' && a[i] != '-'  )
                    {
                        secondOperand = secondOperand * 10 + (a[i] - '0');
                        i++;
                    }
                    result += secondOperand;
                }

                else if (i != a.Length && a[i] == '-')
                {
                    i++;
                    int secondOperand = 0;
                    while (i  != a.Length && a[i] != '+' && a[i] != '-' )
                    {
                        secondOperand = secondOperand * 10 + (a[i] - '0');
                        i++;
                    }
                    result -= secondOperand;
                }
            }
            label2.Text = result+"";
            a = "";

        }

        private void button13_Click(object sender, EventArgs e)
        {
            a += "0";
            textBox1.Text = a;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            a = "";
            result = 0;
            textBox1.Text = "";
            label2.Text = "";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (a.Length > 0)
            {
                a = textBox1.Text.Substring(0, a.Length - 1);
                textBox1.Text = a;
            }
        }
    }
}
