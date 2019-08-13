using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"\nThese are the U.S. Army's Combat Professions");
            Console.WriteLine($"\n");
            Console.ReadKey();
            Soldier s = new Soldier();
            Infantry i = new Infantry();
            Artillery a = new Artillery();
            CombatEngineer e = new CombatEngineer();
            CombatMedic m = new CombatMedic();
            s.Motto();
            s.Mission();
            s.Mos();
            s.Uniform();
            s.Weapon();
            s.Equipment();
            Console.WriteLine($"\n");
            Console.ReadKey();
            s = i;
            s.Motto();
            s.Mission();
            s.Mos();
            s.Uniform();
            s.Weapon();
            s.Equipment();
            Console.WriteLine($"\n");
            Console.ReadKey();
            s = a;
            s.Motto();
            s.Mission();
            s.Mos();
            s.Uniform();
            s.Weapon();
            s.Equipment();
            Console.WriteLine($"\n");
            Console.ReadKey();
            s = e;
            s.Motto();
            s.Mission();
            s.Mos();
            s.Uniform();
            s.Weapon();
            s.Equipment();
            Console.WriteLine($"\n");
            Console.ReadKey();
            s = m;
            s.Motto();
            s.Mission();
            s.Mos();
            s.Uniform();
            s.Weapon();
            s.Equipment();
        }
    }
}
