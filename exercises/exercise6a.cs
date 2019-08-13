using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise06
{
    class Infantry : Soldier
    {
        public override void Motto()
        {
            Console.WriteLine($"I am a U.S. Army Infantryman");
            Console.WriteLine($"-------------------------------------------------------------------------------");
            Console.WriteLine($"Motto: I am the Queen of Battle");
        }
        public override void Mission()
        {
            Console.WriteLine($"Mission: To close with and destroy my enemies");
        }
        public override void Mos()
        {
            Console.WriteLine($"MOS: 11 Bravo, 11 Charlie");
        }
        public override void Weapon()
        {
            Console.WriteLine($"Weapon: M-4 Carbine, M-249 SAW, M-203 Grenade Launcher, M-240B Light Machine Gun");
        }
        public override void Equipment()
        {
            Console.WriteLine($"Special Equipment: Caffeine and HATE");
        }
    }
}
