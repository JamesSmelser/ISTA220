using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise06
{
    class CombatEngineer : Soldier
    {
        public override void Motto()
        {
            Console.WriteLine($"I am a U.S. Army Combat Engineer");
            Console.WriteLine($"-------------------------------------------------------------------------------");
            Console.WriteLine($"Motto: ESSAYONS (Let Us Try)");
        }
        public override void Mission()
        {
            Console.WriteLine($"Mission: Supervise or assist team members when tackling rough terrain in combat situations");
        }
        public override void Mos()
        {
            Console.WriteLine($"MOS: 12 Bravo");
        }
        public override void Weapon()
        {
            Console.WriteLine($"Weapon: M-4 Carbine, M-249 SAW, M-203 Grenade Launcher");
        }
        public override void Equipment()
        {
            Console.WriteLine($"Special Equipment: Bangalore, C-4 Explosives, Det Cord");
        }
    }
}
