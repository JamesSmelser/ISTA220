// Name: C# Exercise04a
// Author: James Smelser
// Date: July 25, 2019
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise04
{
    class Horse
    {
        public static int counter = 0;
        public Horse()
        {
            counter++;
        }
        public Horse(string name)
        {
            Console.WriteLine($"Hello my name is {name} and I am a horse. {Eat()} and {Speak()}.");
            counter++;
        }
        public void Name(string name)
        {
            Console.WriteLine($"Hello my name is {name} and I am a horse. {Eat()} and {Speak()}.");
        }
        private string Eat()
        {
            string eat = $"I eat oats";
            return eat;
        }
        private string Speak()
        {
            string speak = $"I say Naaayyyy";
            return speak;
        }
    }
}
