// Name: C# lab03c
// Author: James Smelser
// Date: July 6, 2019
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            (new Program()).run();
        }

        void run()
        {
            Console.Write("Please enter a positive integer: ");
            string inputValue = Console.ReadLine();
            int input = int.Parse(inputValue);
            long factorialValue = 1;
            factorialValue = CalculateFactorial(input, factorialValue);
            Console.WriteLine($"Factorial({inputValue}) is {factorialValue}");
        }
        private static long CalculateFactorial(int input, long factorialValue)
        {
            if (input == 1)
                return factorialValue;
                
            else
                return CalculateFactorial(input - 1, factorialValue * input);
             
        }
    }
}
