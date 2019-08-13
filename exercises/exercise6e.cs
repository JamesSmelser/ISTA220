using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise06
{
    class CombatMedic : Soldier
    {
        public override void Motto()
        {
            Console.WriteLine($"I am a U.S. Army Combat Medic");
            Console.WriteLine($"-------------------------------------------------------------------------------");
            Console.WriteLine($"Motto: So Others May Live");
        }
        public override void Mission()
        {
            Console.WriteLine($"Mission:  To provide first aid and frontline trauma care on the battlefield");
        }
        public override void Mos()
        {
            Console.WriteLine($"MOS: 68 Whiskey");
        }
        public override void Weapon()
        {
            Console.WriteLine($"Weapon: M-9 Pistol");
        }
        public override void Equipment()
        {
            Console.WriteLine($"Special Equipment: First Aid Bag");
        }
    }
}
