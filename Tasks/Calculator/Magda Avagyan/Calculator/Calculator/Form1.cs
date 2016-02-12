using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        private double result;
        string operation = "";

        string operand1 = "";
        string operand2 = "";

        bool isOpClicked = false;
        bool isEqClicked = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void numButtonClick(object sender, EventArgs e)
        {
            try
            {
                Button btn = sender as Button;
               
                if ((resultTextBox.Text == "0") || isOpClicked || isEqClicked)
                    resultTextBox.Clear();
                isOpClicked = false;

                if (btn.Text == ".")
                {
                    if (resultTextBox.Text == "")
                    {
                        resultTextBox.Text = "0.";
                    }

                    if (!resultTextBox.Text.Contains("."))
                    {
                        resultTextBox.Text += btn.Text;
                    }
                }
                else
                    resultTextBox.Text += btn.Text;

                operand2 = resultTextBox.Text;

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void opButtonClick(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
         
            if (isEqClicked) operand2 = "0";

            if (result!=0)
            {
                buttonEq.PerformClick();

                isEqClicked = false;             
            }

            else
	        {
                result = double.Parse(resultTextBox.Text);
            }

            operation = btn.Text;
            isOpClicked = true;

            operand1 = result.ToString();
        }

        private void buttonCE_Click(object sender, EventArgs e)
        {
            resultTextBox.Text = "0";
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            resultTextBox.Text = "0";
            result = 0;
        }

        private void buttonEq_Click(object sender, EventArgs e)
        {
            isEqClicked = true;
            
            switch (operation)
            {
                case "+":
                    resultTextBox.Text = (result + double.Parse(operand2)).ToString();
                    break;

                case "-":
                    resultTextBox.Text = (result - double.Parse(operand2)).ToString();
                    break;

                case "*":
                    resultTextBox.Text = (result * double.Parse(operand2)).ToString();
                    break;

                case "/":
                    resultTextBox.Text = (result / double.Parse(operand2)).ToString();
                    break;

                default:
                    break;

            }

            result = double.Parse(resultTextBox.Text);
            operand1 = resultTextBox.Text;
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
           //Keys.Enter
            switch (e.KeyChar.ToString())
            {
                case "0":
                    button0.PerformClick();
                    break;

                case "1":
                    button1.PerformClick();
                    break;

                case "2":
                    button2.PerformClick();
                    break;

                case "3":
                    button3.PerformClick();
                    break;

                case "4":
                    button4.PerformClick();
                    break;

                case "5":
                    button5.PerformClick();
                    break;

                case "6":
                    button6.PerformClick();
                    break;

                case "7":
                    button7.PerformClick();
                    break;

                case "8":
                    button8.PerformClick();
                    break;

                case "9":
                    button9.PerformClick();
                    break;

                case "+":
                    buttonAdd.PerformClick();
                    break;

                case "-":
                    buttonSub.PerformClick();
                    break;

                case "*":
                    buttonMult.PerformClick();
                    break;

                case "/":
                    buttonDiv.PerformClick();
                    break;

                case "=":
                    buttonEq.PerformClick();
                    break;

                case ".":
                    buttonDot.PerformClick();
                    break;

                //case "Return":
                //    buttonEq.PerformClick();
                //    break;

                default:
                    break;
            }

            e.Handled = true;
        }
    }
}
