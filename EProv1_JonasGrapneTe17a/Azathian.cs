using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EProv1_JonasGrapneTe17a
{
    class Azathian : ArchClass
    {
        public List<string> magiSkills = new List<string>();

        public Azathian()
        {
            className = "Azathian";
            MeleeLevel = 2;
            RangedLevel = 2;
            MagicLevel = 4;
            Defense = 5;
            Agility = 5;
        }

        public void printSkills() //för att göra detta dynamiskt kan man räkna hur många skills som finns i Skills-listan med .length
        {
            Console.WriteLine(magiSkills[0]);
        }

    }
}

//Main sorcerer