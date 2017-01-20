using System;

namespace ConsoleApplication.Animals
{
    public class Animal : IEat
    {
        public string speciesName { get; set; }
        public int legNumber { get; set; }
        public string name { get; set; }
        public int weight { get; set; }
        public int height { get; set; }
        public string diet { get; set; }
        public string origin { get; set; }
        public virtual void fly()
        {
            Console.WriteLine("Woohoo! I'm on top of the world!");
            return;
        }
               
        public string Sleep()
        {
            System.Console.WriteLine("ZZZZZZzzzz");
            return "Zzzzzzz";
        }
        public string Sleep(int hoursOfSleep) 
        {
           string sleep = "";
            for (var i = 0; i < hoursOfSleep; i++)
            {
                sleep += "ZZZzzzzz";
            }
            return sleep;
        }
        public void Slurp() 
        {
            Console.WriteLine("slurp slurp"); 
        }
        public void Gobble()
        {
            Console.WriteLine("nom nom");
        }
        public void Starve()
        {
            Console.WriteLine("FEED ME!");
        }
    }
}