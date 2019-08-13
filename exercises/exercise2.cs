// Name: C# exercise02
// Author: James Smelser
// Date: July 10, 2019
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise2a
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Enter the numeric grade:");
            double number = int.Parse(Console.ReadLine());
            numberGrade(number);
            int start = 1;
            int end = 10;
            double sum = 0;
            sum = tenAvg(start, end, sum);
            Console.WriteLine($"The numeric average is: {sum / 10}");
            numberGrade(sum / 10);
            int top = 0;
            double sid = 0;
            sid = endAvg(top, sid);
            Console.WriteLine($"The numeric average is: {sid}");
            numberGrade(sid);
            Console.WriteLine($"Enter the number of test to be graded");
            int full = int.Parse(Console.ReadLine());
            double half = 0;
            int numb = 0;
            half = QuoAvg(full, numb, half);
            Console.WriteLine($"The numeric average is: {half}");
            numberGrade(half);
        }
        private static double QuoAvg(int full, int numb, double half)
        {
            Console.WriteLine($"Enter you numeric test grade: ");
            int aVVg = int.Parse(Console.ReadLine());
            if (numb == full)
                return half / full;
            else
                return QuoAvg(full, numb + 1, half + aVVg);
        }
        static double tenAvg(int start, int end, double sum)
        {
            Console.WriteLine($"Enter your numeric test grade: ");
            int avg = int.Parse(Console.ReadLine());
            if (start > end)
                return sum;
            else
                return tenAvg(start + 1, end, sum + avg);
        }
        static double endAvg(int top, double sid)
        {
            Console.WriteLine($"Enter you numeric test grade, enter -1 when finished: ");
            int aVg = int.Parse(Console.ReadLine());
            if (aVg == -1)
                return sid / top;
            else
                return endAvg(top + 1, sid + aVg);
        }
        static void numberGrade(double numbergrade)
        {
            string letterGrade = "";
            if (numbergrade >= 90)
                letterGrade = "A";
            else if (numbergrade >= 80)
                letterGrade = "B";
            else if (numbergrade >= 70)
                letterGrade = "C";
            else if (numbergrade >= 60)
                letterGrade = "D";
            else if (numbergrade < 60)
                letterGrade = "F";
            Console.WriteLine($"Your grade is: {letterGrade}");
        }

    }
}
