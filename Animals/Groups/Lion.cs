using System; 

namespace ConsoleApplication.Animals
{
    public class Lion : Mammal
    {
        public bool mane { get; set; }
        public override void fly()
            {
                Console.WriteLine("I'm too dangerous to fly!");
                return;
            }
        public string Roar()
            {
                System.Console.WriteLine("RAAAAAWWWRRRRR");
                return "Roar";
            }
    }
}