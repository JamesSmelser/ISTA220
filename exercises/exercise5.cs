// Name: C# Exercise05
// Author: James Smelser
// Date: July 25, 2019
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"This is Exercise 5");
            int[] A = new int[] { 0, 2, 4, 6, 8, 10 };
            int[] B = new int[] { 1, 3, 5, 7, 9 };
            int[] C = new int[] { 3, 1, 4, 1, 5, 9, 2, 6, 5, 3, 5, 9 };
            getSum(A);
            getSum(B);
            getSum(C);   
            getReverse(A);
            getReverse(B);
            getReverse(C);
            roTall(A, 2, "L");
            roTall(B, 2, "R");
            roTall(C, 4, "L");
            getSort(C);
        }
        private static void getReverse(int[] game)
        {
            Console.WriteLine($"The reverse order is");
            for (int y = game.Length - 1; y >= 0; y--)
            {
                Console.Write($"{game[y]}, ");
            }
            Console.WriteLine($"\n");
        }

        private static void getSum(int[] set)
        {
            double sum = 0;
            for (int i = 0; i < set.Length; i++)
            {
                sum += set[i];
            }
            double avg = sum / set.Length;
            Console.WriteLine($"The Sum is : {sum} and the Average is : {avg}");
            Console.WriteLine($"\n");
        }
        private static void roTall(int[] match, int pos, string direction)
        {
            if (direction == "R")
            {
                roTar(match, pos);
            }
            else if (direction == "L")
            {
                roTal(match, pos);
            }
        }
        private static void roTar(int[] match, int pos)
        {
            Console.WriteLine($"The array was rotated right {pos}");
            int[] temp = new int[match.Length];
            int len = match.Length;
             for (int i = 0; i < pos; i++)
                temp[i] = match[len - pos + i];
             for (int i = pos; i < len; i++)
                temp[i] = match[i - pos];
             foreach (int rotated in temp)
            Console.Write($"{rotated}, ");
            Console.WriteLine($"\n");
        }
        private static void roTal(int[] match, int pos)
        {
            Console.WriteLine($"The array was rotated left {pos}");
            int[] temp = new int[match.Length];
            int len = match.Length;
             for (int i = 0; i < len - pos; i++)
                temp[i] = match[pos + i];
             for (int i = len - pos; i < len; i++)
                temp[i] = match[i + pos - len];
             foreach (int rotated in temp)
            Console.Write($"{rotated}, ");
            Console.WriteLine($"\n");
        }
        private static void getSort(int[] sorted)
        {
            Console.WriteLine($"The array was sorted");
            int len = sorted.Length;
            for (int current = 0; current < len - 1; current++)
                for (int currentTest = current + 1; currentTest < len; currentTest++)
                    if (sorted[current] > sorted[currentTest])
                    {
                        int temp = sorted[currentTest];
                        sorted[currentTest] = sorted[current];
                        sorted[current] = temp;
                    }

            foreach (int sort in sorted)
                Console.Write($"{sort} ");
        }
    }
}

