using System; 

namespace ConsoleApplication.Animals
{
    public class Penguin : Bird
    {
        public Penguin ()
        {
            this.name = "Luna";
        }
        public bool tuxedo { get; set; }
        public override void fly()
            {
                Console.WriteLine("My wings don't work like that - I fly through the ocean!");
                return;
            }

    }
}
