using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Logic
    {
        private double firstNumber { get; set; }
        private double secondNumber { get; set; }
        operation curentOperation;

        public void OpFunction(double fNumber, operation op)
        {
            firstNumber = fNumber;
            curentOperation = op;
        }

        public string signEquals(double sNumber)
        {
            secondNumber = sNumber;
            string answer = "";
            switch (Convert.ToInt32(curentOperation))
            {
                case 0:
                    {
                       answer = Convert.ToString(firstNumber + secondNumber);
                        break;
                    }
                case 1:
                    {
                        answer = Convert.ToString(firstNumber - secondNumber);
                        break;
                    }
                case 2:
                    {
                        answer = Convert.ToString(firstNumber * secondNumber);
                        break;
                    }

                case 3:
                    {
                        answer = Convert.ToString(firstNumber / secondNumber);
                        break;
                    }
                default:
                    break;
            }
            return answer;
        }
    }
}
