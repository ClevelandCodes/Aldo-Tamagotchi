using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tamagotchi
{
    class Program
    {
        static void Main(string[] args)
        {
            Tamagotchi t1 = new Tamagotchi("Luffy", "Male", 100, 100);
            Console.WriteLine("Name: {0}, Gender: {1}, Fullness: {2}, Happiness: {3}", t1.getName(), t1.getGender(), t1.getFullness(), t1.getHappiness());
            for (int i = 1; i<= 100; i++)
            {
                Console.WriteLine("Would you like to feed or pet your Tamagotchi?");
                string entry = Console.ReadLine();
                if (entry == "feed")
                {
                    t1.feed();
                    Console.WriteLine("You have feed your Tamagotchi he is now " + t1.feed() + " full");
                }
                else if(entry == "pet")
                {
                    t1.pet();
                    Console.WriteLine("You have pet your Tamagotchi he is now " + t1.pet() + " happy");
                }
                t1.doStuff();
                Console.WriteLine(t1.getFullness());
                Console.WriteLine(t1.getHappiness());
                if (t1.getFullness() <= 0 || t1.getHappiness() <= 0)
                {
                    Console.WriteLine("You have killed your Tamagotchi GOOD JOB!");
                    break;
                }
            }
        }
    }
}
