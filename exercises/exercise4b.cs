// Name: C# Exercise04b
// Author: James Smelser
// Date: July 25, 2019
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise04
{
    class Pig
    {
        public static int counter = 0;
        public Pig()
        {
            counter++;
        }
        public Pig(string name)
        {
            Console.WriteLine($"Hello my name is {name} and I am a pig. {Eat()} and {Speak()}.");
            counter++;
        }
        public void Name(string name)
        {
            Console.WriteLine($"Hello my name is {name} and I am a pig. {Eat()} and {Speak()}.");
        }
        private string Eat()
        {
            string eat = $"I eat slop";
            return eat;
        }
        private string Speak()
        {
            string speak = $"I say Oink";
            return speak;
        }
    }
}
