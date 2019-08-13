// Name: C# Lab08b
// Author: James Smelser
// Date: July 17, 2019
using System;

namespace Parameters
{
    class Pass
    {
        public static void Value(ref int param)
        {
            Console.WriteLine($"1. in method Value, param is {param}");
            param = 42;
            Console.WriteLine($"2. in method Value, param is {param}");
        }
        public static void Reference(WrappedInt param)
        {
            Console.WriteLine($"3. in method Reference, param is {param}");
            param.Number = 42;
            Console.WriteLine($"4. in method Reference, param is {param}");
        }
    }
}
