// Name: C# Exercise04
// Author: James Smelser
// Date: July 25, 2019
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise04
{
    class Program
    {
        static void Main(string[] args)
        {
            new Horse($"Ed");
            new Horse($"Black Beauty");
            new Horse($"Silver");
            new Horse($"Sea Biscuit");
            Console.WriteLine($"Number of Horse objects {Horse.counter.ToString()}");
            new Pig($"Wilbur");
            new Pig($"Pumba");
            new Pig($"Babe");
            new Pig($"Porky");
            Console.WriteLine($"Number of Pig objects {Pig.counter.ToString()}");
            new Cow($"Clarabelle");
            new Cow($"Elsie");
            new Cow($"Bluebell");
            new Cow($"Heifer");
            Console.WriteLine($"Number of Cow objects {Cow.counter.ToString()}");
            new Sheep($"Dolly");
            new Sheep($"Lamb Chop");
            new Sheep($"Aries");
            new Sheep($"Wallace");
            Console.WriteLine($"Number of Sheep objects {Sheep.counter.ToString()}");
        }
    }
}
