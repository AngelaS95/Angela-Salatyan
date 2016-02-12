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
    enum operation { PLUS, MINUS, MULTIPLY, DEVIDE };
    public partial class Form1 : Form
    {
        public int selectedOperation;
        public double firstNumber { get; set; }
        public double secondNumber { get; set; }
        Logic calculatorLogic = new Logic();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textInputOutput.Text == "0")
            {
                textInputOutput.Text = "";
            }
                textInputOutput.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textInputOutput.Text == "0")
            {
                textInputOutput.Text = "";
            }
                textInputOutput.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textInputOutput.Text == "0")
            {
                textInputOutput.Text = "";
            }
                textInputOutput.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textInputOutput.Text == "0")
            {
                textInputOutput.Text = "";
            }
            textInputOutput.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textInputOutput.Text == "0")
            {
                textInputOutput.Text = "";
            }
            textInputOutput.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (textInputOutput.Text == "0")
            {
                textInputOutput.Text = "";
            }
            textInputOutput.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (textInputOutput.Text == "0")
            {
                textInputOutput.Text = "";
            }
            textInputOutput.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (textInputOutput.Text == "0")
            {
                textInputOutput.Text = "";
            }
            textInputOutput.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (textInputOutput.Text == "0")
            {
                textInputOutput.Text = "";
            }
            textInputOutput.Text += "9";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (textInputOutput.Text == "0")
            {
                textInputOutput.Text = "";
            }
            textInputOutput.Text += "0";
        }

        private void plusButton_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(textInputOutput.Text);
            calculatorLogic.OpFunction(firstNumber, operation.PLUS);
            textInputOutput.Text = "";
        }

        private void minusButton_Click(object sender, EventArgs e)
        {
            firstNumber = Convert.ToDouble(textInputOutput.Text);
            calculatorLogic.OpFunction(firstNumber, operation.MINUS);
            textInputOutput.Text = "";
        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {

            firstNumber = Convert.ToDouble(textInputOutput.Text);
            calculatorLogic.OpFunction(firstNumber, operation.MULTIPLY);
            textInputOutput.Text = "";
        }

        private void devideButton_Click(object sender, EventArgs e)
        {

            firstNumber = Convert.ToDouble(textInputOutput.Text);
            calculatorLogic.OpFunction(firstNumber, operation.DEVIDE);
            textInputOutput.Text = "";
        }

        private void equalButton_Click(object sender, EventArgs e)
        {
            secondNumber = Convert.ToDouble(textInputOutput.Text);
            textInputOutput.Text = calculatorLogic.signEquals(secondNumber);
        }

        private void dotButton_Click(object sender, EventArgs e)
        {
            if(textInputOutput.Text == "")
            {
                textInputOutput.Text = "0";
            }
            textInputOutput.Text += ",";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            textInputOutput.Text = "";
        }

        private void plusMinusButton_Click(object sender, EventArgs e)
        {
            firstNumber = 0;
            secondNumber = Convert.ToDouble(textInputOutput.Text);
            calculatorLogic.OpFunction(firstNumber, operation.MINUS);
            textInputOutput.Text = calculatorLogic.signEquals(secondNumber);
        }
    }
}
