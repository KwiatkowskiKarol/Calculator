using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number: ");
            String firstNumberString = Console.ReadLine();

            Console.WriteLine("Enter second number: ");
            String secondNumberString = Console.ReadLine();

            AddNumbers(firstNumberString, secondNumberString);

            Console.ReadLine();
        }

        static Decimal AddNumbers(String firstNumberString, String secondNumberString)
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

        static Decimal SubstractNumbers(String firstNumberString, String secondNumberString)
        {
            decimal firstNumber = 0;
            decimal secondNumber = 0;
            decimal result = 0;

            if (Decimal.TryParse(firstNumberString, out firstNumber) || Decimal.TryParse(secondNumberString, out secondNumber))
            {
                result = firstNumber - secondNumber;
            }
            return result;
        }

        static Decimal DivideNumbers(String firstNumberString, String secondNumberString)
        {
            decimal firstNumber = 0;
            decimal secondNumber = 0;
            decimal result = 0;

            if (Decimal.TryParse(firstNumberString, out firstNumber) || Decimal.TryParse(secondNumberString, out secondNumber))
            {
                result = firstNumber / secondNumber;
            }
            return result;
        }

        static Decimal MultiplicateNumbers(String firstNumberString, String secondNumberString)
        {
            decimal firstNumber = 0;
            decimal secondNumber = 0;
            decimal result = 0;

            if (Decimal.TryParse(firstNumberString, out firstNumber) || Decimal.TryParse(secondNumberString, out secondNumber))
            {
                result = firstNumber * secondNumber;
            }
            return result;
        }

    }
}
