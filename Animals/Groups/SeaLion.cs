using System; 

namespace ConsoleApplication.Animals
{
    public class SeaLion : Mammal
    {
        public SeaLion()
        {
            this.name = "Gus";
        }
        public bool flippers { get; set; }
        public override void fly()
            {
                Console.WriteLine("I'm boring and just swim. And eat. Please feed me.");
                return;
            }

    }
}