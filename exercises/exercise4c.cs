// Name: C# Exercise04c
// Author: James Smelser
// Date: July 25, 2019
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise04
{
    class Cow
    {
        public static int counter = 0;
        public Cow()
        {
            counter++;
        }
        public Cow(string name)
        {
            Console.WriteLine($"Hello my name is {name} and I am a cow. {Eat()} and {Speak()}.");
            counter++;
        }
        public void Name(string name)
        {
            Console.WriteLine($"Hello my name is {name} and I am a cow. {Eat()} and {Speak()}.");
        }
        private string Eat()
        {
            string eat = $"I eat hay";
            return eat;
        }
        private string Speak()
        {
            string speak = $"I say Mooooo";
            return speak;
        }
    }
}
