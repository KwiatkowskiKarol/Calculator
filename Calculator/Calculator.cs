using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Calculator
    {

        public static Decimal AddNumbers(String firstNumberString, String secondNumberString)
        {
            decimal firstNumber = 0;
            decimal secondNumber = 0;
            decimal result = 0;

            if (Decimal.TryParse(firstNumberString, out firstNumber) & Decimal.TryParse(secondNumberString, out secondNumber))
            {
                result = firstNumber + secondNumber;
            }
            return result;
        }

        public static Decimal SubtractNumbers(String firstNumberString, String secondNumberString)
        {
            decimal firstNumber = 0;
            decimal secondNumber = 0;
            decimal result = 0;

            if (Decimal.TryParse(firstNumberString, out firstNumber) & Decimal.TryParse(secondNumberString, out secondNumber))
            {
                result = firstNumber - secondNumber;
            }
            return result;
        }

        public static Decimal DivideNumbers(String firstNumberString, String secondNumberString)
        {
            decimal firstNumber = 0;
            decimal secondNumber = 0;
            decimal result = 0;

            if (Decimal.TryParse(firstNumberString, out firstNumber) & Decimal.TryParse(secondNumberString, out secondNumber))
            {
                try {result = firstNumber / secondNumber;}
                catch(DivideByZeroException) { Console.WriteLine("Cannot divide by zero!"); }
            }
            return result;
        }

        public static Decimal MultiplyNumbers(String firstNumberString, String secondNumberString)
        {
            decimal firstNumber = 0;
            decimal secondNumber = 0;
            decimal result = 0;

            if (Decimal.TryParse(firstNumberString, out firstNumber) & Decimal.TryParse(secondNumberString, out secondNumber))
            {
                result = firstNumber * secondNumber;
            }
            return result;
        }

    }
}
