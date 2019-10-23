using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static decimal result; 
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number: ");
            String firstNumberString = Console.ReadLine();

            Console.WriteLine("Enter second number: ");
            String secondNumberString = Console.ReadLine();

            result = Calculator.AddNumbers(firstNumberString, secondNumberString);
            Console.WriteLine("Add: " + result);

            result = Calculator.SubtractNumbers(firstNumberString, secondNumberString);
            Console.WriteLine("Sub: " + result);

            result = Calculator.DivideNumbers(firstNumberString, secondNumberString);
            Console.WriteLine("Div: " + result);
             
            result = Calculator.MultiplyNumbers(firstNumberString, secondNumberString);
            Console.WriteLine("Mul: " + result);

            Console.ReadLine();
        }

    }
}
