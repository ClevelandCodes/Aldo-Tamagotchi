using System;

namespace Tamagotchi
{
    public class Tamagotchi
    {
        private string Name = "";
        private string Gender = "";
        private int Fullness = 0;
        private int Happiness = 0;
        Random rnd = new Random();
        public Tamagotchi(string name, string gender, int fullness, int happiness)
        {
            Name = name;
            Gender = gender;
            Fullness = fullness;
            Happiness = happiness;
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
        public void doStuff()
        {
            Happiness = Happiness - rnd.Next(0,6);
            Fullness = Fullness - rnd.Next(0,6);
        }
    }
}