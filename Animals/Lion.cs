using System; 

namespace ConsoleApplication.Animals
{
    public class Lion : Animal
    {
        public bool mane { get; set; }
        public bool fly { get; set; }
        public string Roar()
            {
                System.Console.WriteLine("RAAAAAWWWRRRRR");
                return "Roar";
            }

    }
}