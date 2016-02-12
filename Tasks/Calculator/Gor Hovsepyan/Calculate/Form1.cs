using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculate
{
    public partial class Calculator : Form
    {
        double resultValue = 0;
        string operation = "";
        bool isOperationcomplete = false;
        
        public Calculator()
        {
            InitializeComponent();

           
        }

        

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar) || Char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        void myButton_Click(object sender, EventArgs e)
        {
            if((textboxResult.Text =="0") || isOperationcomplete)
            {
                textboxResult.Clear();
            }
           Button btn = (Button)sender;
           isOperationcomplete = false;
            if(btn.Text == ".")
            {
                if (!textboxResult.Text.Contains("."))
                    textboxResult.Text += btn.Text;
            }else
           textboxResult.Text += btn.Text;
                
            }        
        

        private void button3_Click(object sender, EventArgs e)
        {
            textboxResult.Text = "0";
            resultValue = 0;
            numbLabel.Text = "";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textboxResult.Text = "0";
        }

        private void operation_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (resultValue != 0)
            {
                equalbt.PerformClick();
                operation = button.Text;
                
                numbLabel.Text = resultValue + " " + operation;
                isOperationcomplete = true;
            }
            else
            {
                operation = button.Text;
                resultValue = Double.Parse(textboxResult.Text);
                numbLabel.Text = resultValue + " " + operation;
                isOperationcomplete = true;
            }
        }

        private void equalbt_Click(object sender, EventArgs e)
        {
            switch (operation)
            {

                case "+":
                    textboxResult.Text = (resultValue + Double.Parse(textboxResult.Text)).ToString();
                    break;
                case "-":
                    textboxResult.Text = (resultValue - Double.Parse(textboxResult.Text)).ToString();
                    break;
                case "*":
                    textboxResult.Text = (resultValue * Double.Parse(textboxResult.Text)).ToString();
                    break;
                case "/":
                    textboxResult.Text = (resultValue / Double.Parse(textboxResult.Text)).ToString();
                    break;
                default:
                    break;

                   

            }
            resultValue = Double.Parse(textboxResult.Text);
            numbLabel.Text = "";
        }
    }
}
