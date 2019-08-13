// Name: C# Lab11a
// Author: James Smelser
// Date: July 23, 2019
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParamsArray
{
    class Program
    {
        static void doWork()
        {
            int total = Util.Sum(10, 9, 8, 7, 6, 5, 4, 3, 2, 1);
            Console.WriteLine(total);
        }

        static void Main()
        {
            try
            {
                doWork();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception: {0}", ex.Message);
            }
        }
    }
}
