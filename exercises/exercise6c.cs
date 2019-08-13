using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise06
{
    class Artillery : Soldier
    {
        public override void Motto()
        {
            Console.WriteLine($"I am a U.S. Army Artilleryman");
            Console.WriteLine($"-------------------------------------------------------------------------------");
            Console.WriteLine($"Motto: I am the King of Battle");
        }
        public override void Mission()
        {
            Console.WriteLine($"Mission: To rain down hell on my enemies");
        }
        public override void Mos()
        {
            Console.WriteLine($"MOS: 13 Bravo, 13 Delta, 13 Fox");
        }
        public override void Weapon()
        {
            Console.WriteLine($"Weapon: M-4 Carbine");
        }
        public override void Equipment()
        {
            Console.WriteLine($"Special Equipment: 105MM Howitzer, 155MM Howitzer");
        }
    }
}
