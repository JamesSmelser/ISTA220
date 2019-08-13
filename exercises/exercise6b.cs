using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise06
{
    class Soldier
    {
        public virtual void Motto()
        {
            Console.WriteLine($"I am a U.S. Army Soldier");
            Console.WriteLine($"-------------------------------------------------------------------------------");
            Console.WriteLine($"Motto: This We'll Defend");
        }
        public virtual void Mission()
        {
            Console.WriteLine($"Mission: I defend my country against enemies foreign and domestic");
        }
        public virtual void Mos()
        {
            Console.WriteLine($"MOS: There are 190 occupations in the Army");
        }
        public void Uniform()
        {
            Console.WriteLine($"Uniform: Universal Camouflage Pattern, Combat Boots, and Advanced Combat Helmet");
        }
        public virtual void Weapon()
        {
            Console.WriteLine($"Weapon: M-4 Carbine Rifle");
        }
        public virtual void Equipment()
        {
            Console.WriteLine($"Special Equipment: Assault Pack");
        }
    }
}
