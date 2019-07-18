//Name: C# Lab01a
//Author: James Smelser
//Date: July 3, 2019
using System;

namespace TestHello1
{ 
    class Program
    { 
        static void Main(string[] args)
        {
            Console.WriteLine("Hello MSSA");
            int number1 = 0;
            int number2 = 0;
            int sum = number1 + number2;  
            Console.WriteLine("Enter a number:");
            string a = Console.ReadLine();
            Console.WriteLine("Enter another number:");
            string b = Console.ReadLine(); 
            number1 = int.Parse(a);
            number2 = int.Parse(b);
            sum = number1 + number2;
            Console.WriteLine("equals" +  sum);
        }
    }
}
