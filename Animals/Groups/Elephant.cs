using System; 

namespace ConsoleApplication.Animals
{
    public class Elephant : Mammal
    {
        public Elephant ()
        {
            this.name = "Packy";
        }

        public Elephant (string Name)
        {
            base.name = Name;
        }
        public bool trunk { get; set; }
        public bool tusk { get; set; }
        public override void fly()
            {
                Console.WriteLine("I'm too fat to fly - unless my name is Dumbo!");
                return;
            }
    }
}
