using System;

namespace CalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Input 1: ");
            int inputOne = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter an operation (+, -, *, /): ");
            char op = char.Parse(Console.ReadLine());

            Console.WriteLine("Enter Input 2: ");
            int inputTwo = int.Parse(Console.ReadLine());

            double result = 0;

            switch (op)
            {
                case '+':
                    result = inputOne + inputTwo;
                    break;

                case '-':
                    result = inputOne - inputTwo;
                    break;

                case '*':
                    result = inputOne * inputTwo;
                    break;
                case '/':
                    result = inputOne / inputTwo;
                    break;
                default:
                    Console.WriteLine("Invalid Operator!");
                    break;
            }

            Console.WriteLine("Result: " + result);
        }
    }
}
