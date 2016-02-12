using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GM_CalcUlator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double result;
        
        char act;//this is symbol , which can hava + - * /

        public void Text_TextChanged(object sender, EventArgs e)
        {

        }
        private void c_1_Click(object sender, EventArgs e)
        {
            if(this.Screen.Text == "+" || this.Screen.Text == "-" || this.Screen.Text == "/" || this.Screen.Text == "*" || this.Screen.Text == "0")
                this.Screen.Text = "1";
            else
            this.Screen.Text += "1";
        }

        private void c_2_Click(object sender, EventArgs e)
        {
            if (this.Screen.Text == "+" || this.Screen.Text == "-" || this.Screen.Text == "/" || this.Screen.Text == "*" || this.Screen.Text == "0")
                this.Screen.Text = "2";
            else
                this.Screen.Text += "2";
        }
        private void three_Click(object sender, EventArgs e)
        {
            if (this.Screen.Text == "+" || this.Screen.Text == "-" || this.Screen.Text == "/" || this.Screen.Text == "*" || this.Screen.Text == "0")
                this.Screen.Text = "3";
            else
                this.Screen.Text += "3";

        }

        private void c_4_Click(object sender, EventArgs e)
        {
            if (this.Screen.Text == "+" || this.Screen.Text == "-" || this.Screen.Text == "/" || this.Screen.Text == "*" || this.Screen.Text == "0")
                this.Screen.Text = "4";
            else
                this.Screen.Text += "4";
        }

        private void c_5_Click(object sender, EventArgs e)
        {
            if (this.Screen.Text == "+" || this.Screen.Text == "-" || this.Screen.Text == "/" || this.Screen.Text == "*" || this.Screen.Text == "0")
                this.Screen.Text = "5";
            else
                this.Screen.Text += "5";
        }

        private void c_6_Click(object sender, EventArgs e)
        {
            if (this.Screen.Text == "+" || this.Screen.Text == "-" || this.Screen.Text == "/" || this.Screen.Text == "*" || this.Screen.Text == "0")
                this.Screen.Text = "6";
            else
                this.Screen.Text += "6";
        }

        private void c_7_Click(object sender, EventArgs e)
        {
            if (this.Screen.Text == "+" || this.Screen.Text == "-" || this.Screen.Text == "/" || this.Screen.Text == "*" || this.Screen.Text == "0")
                this.Screen.Text = "7";
            else
                this.Screen.Text += "7";
        }

        private void c_8_Click(object sender, EventArgs e)
        {
            if (this.Screen.Text == "+" || this.Screen.Text == "-" || this.Screen.Text == "/" || this.Screen.Text == "*" || this.Screen.Text == "0")
                this.Screen.Text = "8";
            else
                this.Screen.Text += "8";
        }

        private void c_9_Click(object sender, EventArgs e)
        {
            if (this.Screen.Text == "+" || this.Screen.Text == "-" || this.Screen.Text == "/" || this.Screen.Text == "*" || this.Screen.Text == "0")
                this.Screen.Text = "9";
            else
                this.Screen.Text += "9";
        }

        private void c_0_Click(object sender, EventArgs e)
        {
            if (this.Screen.Text == "+" || this.Screen.Text == "-" || this.Screen.Text == "/" || this.Screen.Text =="*" || this.Screen.Text == "0")
                this.Screen.Text = "0";
            else
                this.Screen.Text += "0";
        }
        private void plus_Click(object sender, EventArgs e)
        {
            result = double.Parse(this.Screen.Text);
            act = '+';
            this.Screen.Text = "+";
        }
        private void minus_Click(object sender, EventArgs e)
        {
            result = double.Parse(this.Screen.Text);
            act = '-';
            this.Screen.Text = "-";
        }

        private void even_Click(object sender, EventArgs e)
        {
            result = double.Parse(this.Screen.Text);
            act = '*';
            this.Screen.Text = "*";
           // MessageBox.Show(Convert.ToString(result));
        }

        private void divide_Click(object sender, EventArgs e)
        {
            result = double.Parse(this.Screen.Text);
            act = '/';
            this.Screen.Text = "/";
          //  MessageBox.Show(Convert.ToString(result));
        }


        private void equal_Click(object sender, EventArgs e)
        {
 
            //MessageBox.Show(Convert.ToString(second_n));
            if (act == '+')
                 result += double.Parse(this.Screen.Text);
            if (act == '-')
                 result -= double.Parse(this.Screen.Text);
            if (act == '*')
                 result *= double.Parse(this.Screen.Text);

            if (act == '/')
            {
                if (this.Screen.Text == "0")
                {
                    this.Screen.Text = "infinity";
                    result = 0.0;
                    act = '\0';
                    return;
                }
                else
                    result /= double.Parse(this.Screen.Text);
            }


            //  MessageBox.Show(Convert.ToString(final_result));
            this.Screen.Text = Convert.ToString(result);
            result = 0.0;
            act = '\0';



        }

        private void clear_Click(object sender, EventArgs e)
        {
            result = 0.0;
            act = '\0';
            this.Screen.Clear();
        }
    }
}
