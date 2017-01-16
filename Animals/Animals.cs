using System;

namespace ConsoleApplication.Animals
{
    public class Animal
    {
        public string speciesName { get; set; }
        public string name { get; set; }
        public int legNumber { get; set; }
        public int weight { get; set; }
        public int height { get; set; }
        public string diet { get; set; }
        public string origin { get; set; }
               
        public string Sleep()
        {
            System.Console.WriteLine("ZZZZZZzzzz");
            return "Zzzzzzz";
        }
    }
}