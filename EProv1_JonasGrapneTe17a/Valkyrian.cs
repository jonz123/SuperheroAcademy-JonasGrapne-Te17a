using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EProv1_JonasGrapneTe17a
{
    class Valkyrian : ArchClass
    {
        public List<string> rangSkills = new List<string>();

        public Valkyrian() 
        {
            className = "Valkyrian";
            MeleeLevel = 2;
            RangedLevel = 4;
            MagicLevel = 2;
            Defense = 3;
            Agility = 8;
        }

        public void printSkills() //för att göra detta dynamiskt kan man räkna hur många skills som finns i Skills-listan med .length
        {
            Console.WriteLine(rangSkills[0]);
        }
    }
}

//main ranger