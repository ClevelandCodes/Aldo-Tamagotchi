using System;

namespace ConsoleApplication7
{
    public class Tamagotchi
    {
        private string Name = "";
        private string Gender = "";
        private int Fullness = 0;
        private int Happiness = 0;

        public Tamagotchi(string n, string g, int a, int h)
        {
            Name = n;
            Gender = g;
            Age = a;
            Happiness = h;
        }
        public string getName()
        {
            return Name;
        }
        public string getGender()
        {
            return Gender;
        }
        public int getFullness()
        {
            return Fullness;
        }
        public int getHappiness()
        {
            return Happiness;
        }
        public int pet()
        {
            Happiness = Happiness + 1;
            return Happiness;
        }
        public int feed()
        {
            Fullness = Fullness + 1;
            return Fullness;
        }
        public int doStuf()
        {
            Happiness = Happiness - 5;
            return Happiness;
            Fullness = Fullness - 5;
            return Fullness;
        }
    }
}
