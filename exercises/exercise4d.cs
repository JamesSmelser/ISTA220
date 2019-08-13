// Name: C# Exercise04d
// Author: James Smelser
// Date: July 25, 2019
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise04
{
    class Sheep
    {
        public static int counter = 0;
        public Sheep()
        {
            counter++;
        }
        public Sheep(string name)
        {
            Console.WriteLine($"Hello my name is {name} and I am a sheep. {Eat()} and {Speak()}.");
            counter++;
        }
        public void Name(string name)
        {
            Console.WriteLine($"Hello my name is {name} and I am a sheep. {Eat()} and {Speak()}.");
        }
        private string Eat()
        {
            string eat = $"I eat grass";
            return eat;
        }
        private string Speak()
        {
            string speak = $"I say Baahhhh";
            return speak;
        }
    }
}
