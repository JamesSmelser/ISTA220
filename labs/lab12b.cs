﻿// Name: C# Lab12b
// Author: James Smelser
// Date: July 25, 2019
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    class Car : Vehicle
    {
        public void Accelerate()
        {
            Console.WriteLine("Accelerating");
        }
        public void Brake()
        {
            Console.WriteLine("Braking");
        }
        public override void Drive()
        {
            Console.WriteLine("Motoring");
        }
    }
}
