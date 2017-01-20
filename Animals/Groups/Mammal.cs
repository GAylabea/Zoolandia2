using System;

namespace ConsoleApplication.Animals
{
    public class Mammal : Animal
    {
    public string Walk()
        {
            Console.WriteLine("Here we go to search for food!");
            return "Keep walking!";
        }
    public string Fur()
    {
        Console.WriteLine("Yes, I could use a shave");
        return "Fuzzy!";
    }

    public string Fur(int lengthOfFur)
        {
            string furry = "";
            if (lengthOfFur == 1) 
            {
                Console.WriteLine("You don't need a shave!");
            }
            else
            {
                Console.WriteLine("Please unmat my fur!");             
            }
            return furry;
        }

    }
}
    
