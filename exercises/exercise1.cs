using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_1
{
    class Program
    {
        static void Main(string[] args)
        {              
         Console.WriteLine($"Enter the radius of a circle:");
         string aRadius = Console.ReadLine();
         int iRadius = int.Parse(aRadius);
         double iArea = (Math.Pow(iRadius, 2) * Math.PI);
         double iCirc = Math.PI * 2 * iRadius;
         double aHem = (((Math.PI * (Math.Pow(iRadius, 3)) * 4 / 3)/2));
         Console.WriteLine($"The area is: {iArea}");
         Console.WriteLine($"The circumference is: {iCirc}");
         Console.WriteLine($"The volume of a hemisphere is: {aHem}");
            Console.WriteLine($"Enter side A of the triangle:");
            string aSide = Console.ReadLine();
            Console.WriteLine($"Enter side B of the triangle:");
            string bSide = Console.ReadLine();
            Console.WriteLine($"Enter side C of the triangle:");
            string cSide = Console.ReadLine();
            double aaSide = int.Parse(aSide);
            double abSide = int.Parse(bSide);
            double acSide = int.Parse(cSide);
            double atTri = (aaSide + abSide + acSide) / 2;
            double paSide = atTri - aaSide;
            double pbSide = atTri - abSide;
            double pcSide = atTri - acSide;
            double abcSide = (((paSide * atTri) * pbSide) * pcSide);
            double tArea = Math.Sqrt(abcSide);
            Console.WriteLine($"The area of the triangle is: {tArea}");
               Console.WriteLine("Enter value a of the quadratic formula:");
               string aVal = Console.ReadLine();
               Console.WriteLine("Enter value b of the quadratic formula:");
               string bVal = Console.ReadLine();
               Console.WriteLine("Enter value c of the quadratic formula:");
               string cVal = Console.ReadLine();
               int aaVal = int.Parse(aVal);
               int abVal = int.Parse(bVal);
               int acVal = int.Parse(cVal);
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
