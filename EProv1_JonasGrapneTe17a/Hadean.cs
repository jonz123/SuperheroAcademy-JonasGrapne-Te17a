using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EProv1_JonasGrapneTe17a
{
    class Hadean : ArchClass
    {
        public List<string> physSkills = new List<string>();

        public Hadean()
        {
            className = "Hadean";
            MeleeLevel = 4;
            RangedLevel = 2;
            MagicLevel = 2;
            Defense = 8;
            Agility = 3;
        }

        public void printSkills() //för att göra detta dynamiskt kan man räkna hur många skills som finns i Skills-listan med .length
        {
            Console.WriteLine(physSkills[0]);
        }
    }
}

//main fighter