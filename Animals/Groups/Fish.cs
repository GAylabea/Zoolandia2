using System;

namespace ConsoleApplication.Animals
{
    public class Fish : Animal
    {
        public bool fins { get; set; }
        // public string Swim()
        //     {
        //         Console.WriteLine("Here we go upstream!");
        //         return "Keep swimming!";
        //     }
        public string Swim(int lengthOfSwim)
        {
            string swim = "";
            for (var i = 0; 0 < lengthOfSwim; i++)
            {
            swim += "swish swish!";
            }
            return swim;
        }
    }
}

