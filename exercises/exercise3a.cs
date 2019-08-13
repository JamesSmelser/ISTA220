// Name: C# exercise03
// Author: James Smelser
// Date: July 19, 2019
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercise03
{
    class Program
    {
        static void Main(string[] args)
        {
            start:
            try
            {
                Console.Write($"Enter the radius of a circle: ");
                double iRadius = int.Parse(Console.ReadLine());
                CaTch(iRadius);
                if (iRadius == 0)
                    goto start;
                else if (iRadius < 0)
                    goto start;
                Circ(iRadius);
            }
            catch (FormatException)
            {
                Console.WriteLine($"Must enter a number.");
                goto start;
            }
            catch (OverflowException)
            {
                Console.WriteLine($"Number is to large.");
                goto start;
            }

            begin:
            try
            {
                Console.Write($"Enter side A of the triangle: ");
                double aaSide = int.Parse(Console.ReadLine());
                CaTch(aaSide);
                if (aaSide == 0)
                    goto begin;
                else if (aaSide < 0)
                    goto begin;
            right:
                Console.Write($"Enter side B of the triangle: ");
                double abSide = int.Parse(Console.ReadLine());
                CaTch(abSide);
                if (abSide == 0)
                    goto right;
                else if (abSide < 0)
                    goto right;
            now:
                Console.Write($"Enter side C of the triangle: ");
                double acSide = int.Parse(Console.ReadLine());
                CaTch(acSide);
                if (acSide == 0)
                    goto now;
                else if (acSide < 0)
                    goto now;
                Tarea(aaSide, abSide, acSide);
            }
            catch (FormatException)
            {
                Console.WriteLine($"Must enter a number.");
                goto begin;
            }
            catch (OverflowException)
            {
                Console.WriteLine($"Number is to large.");
                goto begin;
            }

            first:
            try
            {
                Console.WriteLine("Enter value a of the quadratic formula:");
                int aaVal = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter value b of the quadratic formula:");
                int abVal = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter value c of the quadratic formula:");
                int acVal = int.Parse(Console.ReadLine());
                Quad(aaVal, abVal, acVal);
            }
            catch (FormatException)
            {
                Console.WriteLine($"Must enter a number.");
                goto first;
            }
            catch (OverflowException)
            {
                Console.WriteLine($"Number is to large.");
                goto first;
            }
        }

        private static void CaTch(double first = 0.0)
        {
            try
            {
                try
                {
                    if (first == 0.0)
                        throw new DivideByZeroException($"Can not divide by zero.");
                    else if (first < 0.0)
                        throw new InvalidOperationException($"Please input a positive number.");
                }
                finally
                {
                    if (first > 0.0)
                        Console.WriteLine($"Your number is good.");
                }
            }
            catch (DivideByZeroException dBz)
            {
                Console.WriteLine(dBz.Message);
            }
            catch (InvalidOperationException iOe)
            {
                Console.WriteLine(iOe.Message);
            }
        }

            private static void Tarea(double aaSide, double abSide, double acSide)
        {
            double atTri = (aaSide + abSide + acSide) / 2;
            double paSide = atTri - aaSide;
            double pbSide = atTri - abSide;
            double pcSide = atTri - acSide;
            double abcSide = (((paSide * atTri) * pbSide) * pcSide);
            double tArea = Math.Sqrt(abcSide);
            Console.WriteLine($"The area of the triangle is: {tArea}");
        }

        private static void Circ(double iRadius)
        {
            double iArea = (Math.Pow(iRadius, 2) * Math.PI);
            double iCirc = Math.PI * 2 * iRadius;
            double aHem = (((Math.PI * (Math.Pow(iRadius, 3)) * 4 / 3) / 2));
            Console.WriteLine($"The area is: {iArea}");
            Console.WriteLine($"The circumference is: {iCirc}");
            Console.WriteLine($"The volume of a hemisphere is: {aHem}");
        }

        private static void Quad(int aaVal, int abVal, int acVal)
        {
            double abaVal = Math.Pow(abVal, 2);
            double aaaVal = ((-4) * aaVal);
            double acaVal = aaaVal * acVal;
            double abcVal = abaVal + acaVal;
            double abcaVal = Math.Sqrt(abcVal);
            double posVal = ((-1) * abVal - abcaVal);
            double negVal = ((-1) * abVal + abcaVal);
            double botaVal = 2 * aaVal;
            double xVal = negVal / botaVal;
            double xxVal = posVal / botaVal;
            Console.WriteLine("x equals: " + xVal);
            Console.WriteLine("x equals: " + xxVal);
        }
    }
}

