using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EProv1_JonasGrapneTe17a
{
    class Program
    {
        static void Main(string[] args)
        {

            //Definerar alla klasser, läs nedan om varför jag tycker att detta är en jobbig grej
            ArchClass player = new ArchClass();
            Hadean hadean = new Hadean();
            Valkyrian valkyrian = new Valkyrian();
            Azathian azathian = new Azathian();


            string name = "";
            string chosenClass = "";
            bool active = true;

            Console.WriteLine("Congratulations!");
            Console.WriteLine("You have been accepted to the Superhero Academy!");
            Console.WriteLine("Before you can enroll, however, you must identify yourself according to our power system.");
            Console.WriteLine("But before that, please enter your name.");
            Console.WriteLine();
            name = Console.ReadLine(); //Spelaren får heta vad den vill, så ingen check
            while (name == "") //Om det inte, såklart, är tomt
            {
                Console.WriteLine("What, nothing? Come on, you must have some sort of name!");
                Console.WriteLine();
                name = Console.ReadLine();
            }
            Console.WriteLine();
            Console.WriteLine("Ah, is that so, " + name + "?");
            Console.WriteLine("Pleasure to meet you!");
            Console.WriteLine();
            Console.WriteLine("Now, it is time for you to tell us what power you were born with.");
            Console.WriteLine("For reference:");
            Console.WriteLine("[Hadean] is the archclass for warriors. Your powers are based on power and force.");
            Console.WriteLine("[Valkyrian] is the archclass for rangers. Your powers are based on intellect and agility.");
            Console.WriteLine("[Azathian] is the archclass for magicians. Your powers are stronger in fields of physical and etherial manipulation.");
            Console.WriteLine("So, which one are you?");
            Console.WriteLine();

            while (active == true) //när valet är aktivt; loopa
            {
                chosenClass = Console.ReadLine(); //skriver in sitt svar; Jag kunde ha gjort detta till en siffra men det var inte lika roligt
                chosenClass = chosenClass.ToLower(); //för simplicitet, gör svaret lowercase

                //Denna del är grovt ineffektiv men jag lyckedes inte hitta ett annat sätt
                //Hade egentligen velat definera player som en klass i var och en av alla utfall, men då gick det inte att hämta player i huvudskriptet
                //Därav måste allt defineras enligt en mall som skapades i början....

                if (chosenClass == "hadean")
                {
                    player.className = hadean.className;
                    player.MeleeLevel = hadean.MeleeLevel;
                    player.RangedLevel = hadean.RangedLevel;
                    player.MagicLevel = hadean.MagicLevel;
                    player.Defense = hadean.Defense;
                    player.Agility = hadean.Agility;
                    active = false;
                }
                else if (chosenClass == "valkyrian")
                {
                    player.className = valkyrian.className;
                    player.MeleeLevel = valkyrian.MeleeLevel;
                    player.RangedLevel = valkyrian.RangedLevel;
                    player.MagicLevel = valkyrian.MagicLevel;
                    player.Defense = valkyrian.Defense;
                    player.Agility = valkyrian.Agility;
                    active = false;
                }
                else if (chosenClass == "azathian")
                {
                    player.className = azathian.className;
                    player.MeleeLevel = azathian.MeleeLevel;
                    player.RangedLevel = azathian.RangedLevel;
                    player.MagicLevel = azathian.MagicLevel;
                    player.Defense = azathian.Defense;
                    player.Agility = azathian.Agility;
                    active = false;
                }
                else
                {
                    Console.WriteLine("Huh? That doesn't sound right. Please try again!");
                }
            }
            Console.WriteLine();
            if (player.className == "Azathian")
            {
                Console.WriteLine("Ah! So you're an Azathian?");
            }
            else
            {
                Console.WriteLine("Ah! So you're a " + player.className + "?");
            }

            //displayar alla stats som klassen har
            Console.WriteLine("Simply splendid!");
            Console.WriteLine("Here, we'll show your base stats in this form.");
            Console.WriteLine();
            Console.WriteLine(name + " : " + player.className);
            Console.WriteLine("Melee: " + player.MeleeLevel);
            Console.WriteLine("Ranged: " + player.RangedLevel);
            Console.WriteLine("Magic: " + player.MagicLevel);
            Console.WriteLine("Defense: " + player.Defense);
            Console.WriteLine("Agility: " + player.Agility);

            Console.WriteLine();
            Console.WriteLine("Interesting, is it not?");
            Console.WriteLine("I would let you assign a starting amount of XP based on what difficulty setting you choose...");
            Console.WriteLine("...But it seems we're running out of time!");
            Console.WriteLine("Come see us in the office later, and we'll sort that out.");
            Console.WriteLine();
            Console.WriteLine("Welcome to Superhero Academy!");

            //planerade att spelaren fick välja en difficulty som bestämde vilken bas-XP som spelaren skulle få, men det hann jag inte

            Console.ReadKey();
        }
    }
}
