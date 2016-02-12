using System;
using System.Globalization;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class fmSimpleCalculator : Form
    {
        private bool _isFirstOperator = true;
        private bool _numberWasPressed;
        private string _operand;
        private string _operator = "";
        private bool _operatorWasPressed;
        private double _result;

        public fmSimpleCalculator()
        {
            InitializeComponent();
            KeyPreview = true;
        }

        private void btnNumber_Click(object sender, EventArgs e)
        {
            if (tbResult.Text == "0")
                tbResult.Clear();

            var numberButton = (Button) sender;

            if (_operatorWasPressed)
            {
                tbResult.Clear();
                _operatorWasPressed = false;
            }

            if (numberButton.Text != "." || !tbResult.Text.Contains("."))
            {
                if (numberButton.Text != "." || tbResult.Text.Length >= 1)
                    tbResult.Text += numberButton.Text;
                else
                    tbResult.Text = "0.";
            }

            _numberWasPressed = true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbResult.Text = "0";
            _result = 0;
            _operand = "";
            _operator = "";

            _isFirstOperator = true;
            _numberWasPressed = false;
            _operatorWasPressed = false;
        }

        private void btnOperator_Click(object sender, EventArgs e)
        {
            var operatorButton = (Button) sender;

            if (_operatorWasPressed)
            {
                _operator = operatorButton.Text;
            }

            if (_numberWasPressed)
            {
                if (_isFirstOperator && operatorButton.Text != "=")
                {
                    _operator = operatorButton.Text;
                    _result = double.Parse(tbResult.Text);
                    _isFirstOperator = false;
                }

                else
                {
                    identifyOperators(operatorButton);
                }

                _numberWasPressed = false;
            }

            _operatorWasPressed = true;
        }


        private void identifyOperators(Button operatorButton)
        {
            switch (_operator)
            {
                case "+":

                    _operand = tbResult.Text;
                    _result += double.Parse(_operand, NumberStyles.Float);
                    tbResult.Text = _result.ToString();
                    _operator = operatorButton.Text;
                    break;

                case "-":

                    _operand = tbResult.Text;
                    _result -= double.Parse(_operand, NumberStyles.Float);
                    tbResult.Text = _result.ToString();
                    _operator = operatorButton.Text;
                    break;

                case "*":

                    _operand = tbResult.Text;
                    _result *= double.Parse(_operand, NumberStyles.Float);
                    tbResult.Text = _result.ToString();
                    _operator = operatorButton.Text;
                    break;

                case "/":

                    _operand = tbResult.Text;
                    _result /= double.Parse(_operand, NumberStyles.Float);
                    tbResult.Text = _result.ToString();
                    _operator = operatorButton.Text;
                    break;

                case "=":
                    _operand = tbResult.Text;
                    identifyOperators(operatorButton);
                    tbResult.Text = _result.ToString();
                    break;
            }
        }


        private void fmSimpleCalculator_KeyPress(object sender, KeyPressEventArgs e)
        {
            //MessageBox.Show(e.KeyChar.ToString());
            switch (e.KeyChar.ToString())
            {
                case "0":
                    btnZero.PerformClick();
                    break;
                case "1":
                    btnOne.PerformClick();
                    break;
                case "2":
                    btnTwo.PerformClick();
                    break;
                case "3":
                    btnThree.PerformClick();
                    break;
                case "4":
                    btnFour.PerformClick();
                    break;
                case "5":
                    btnFive.PerformClick();
                    break;
                case "6":
                    btnSix.PerformClick();
                    break;
                case "7":
                    btnSeven.PerformClick();
                    break;
                case "8":
                    btnEight.PerformClick();
                    break;
                case "9":
                    btnNine.PerformClick();
                    break;
                case "+":
                    btnAdd.PerformClick();
                    break;
                case "-":
                    btnSubtract.PerformClick();
                    break;
                case "*":
                    btnMultiply.PerformClick();
                    break;
                case "/":
                    btnDivide.PerformClick();
                    break;
                case ".":
                    btnDot.PerformClick();
                    break;
                case "c":
                    btnClear.PerformClick();
                    break;
                case "ENTER":
                    btnEqual.PerformClick();
                    break;
            }
        }
    }
}