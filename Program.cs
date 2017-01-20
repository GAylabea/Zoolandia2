using System;
using ConsoleApplication.Animals;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {

            var ElphasMaximus = new Elephant();
            ElphasMaximus.speciesName = "Elephas Maximus";
            ElphasMaximus.legNumber = 4;
            ElphasMaximus.weight = 12500;
            // ElphasMaximus.name = "Packy";
            ElphasMaximus.height = 120; 
            ElphasMaximus.origin = "Asia";
            ElphasMaximus.diet = "herbivore";
            ElphasMaximus.tusk = true;
            ElphasMaximus.Sleep(); 

            var AptenodytesForsteri = new Penguin();
            AptenodytesForsteri.speciesName = "Aptenodytes forsteri";
            // AptenodytesForsteri.name = "Luna";
            AptenodytesForsteri.legNumber = 2;
            AptenodytesForsteri.origin = "Antartica";
            AptenodytesForsteri.tuxedo = true;
            
            var PantheraLeo = new Lion();
            PantheraLeo.speciesName = "Panthera leo";
            // PantheraLeo.name = "Zawadi Mungu";
            PantheraLeo.legNumber = 4;
            PantheraLeo.origin = "sub-Sahara Africa";
            PantheraLeo.diet = "carnivor";
            PantheraLeo.mane = true;
            PantheraLeo.Fur(7);
                        
            var Otariidae = new SeaLion();
            Otariidae.speciesName = "Otariidae";
            // Otariidae.name = "Gus";
            Otariidae.legNumber = 0;
            Otariidae.origin = "Coastal waters and rocky shorelines";
            Otariidae.diet = "Omnivore";
            Otariidae.flippers = true;

            var Chinook = new Salmon();
            Chinook.speciesName = "Oncorhynchus tshawytscha";
            Chinook.scaleColor = "blue, green, purple, silver";
            Chinook.Slurp();
        
            Elephant superman = new Elephant("Packy");
            Console.WriteLine(superman.name);

            Console.WriteLine(ElphasMaximus.name);
            Console.WriteLine($"I have an elephant named {ElphasMaximus.name} he is really heavy at {ElphasMaximus.weight} pounds.");
            ElphasMaximus.fly();
            Console.WriteLine($"I also have a SeaLion named {Otariidae.name} - his scientific name is {Otariidae.speciesName}.");
            Console.WriteLine($"Pop quiz: Sea lions have flippers. True or False? {Otariidae.flippers}!");
            Console.WriteLine($"My Penguin is adorable - his name is {AptenodytesForsteri.name}. He wishes he were still in {AptenodytesForsteri.origin}.");
            Console.WriteLine($"Watch out for my pet lion, {PantheraLeo.name}. He's a {PantheraLeo.diet} and may eat you!");
            Console.WriteLine(PantheraLeo.Fur());
            PantheraLeo.Roar();
            Console.WriteLine(Otariidae.Sleep(7));
            Console.WriteLine($"I caught a {Chinook.speciesName}! It is very colorful with {Chinook.scaleColor} scales.");
         }
    }
}