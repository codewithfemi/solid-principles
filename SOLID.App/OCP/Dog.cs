using System;

namespace SOLID.App
{
    public class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Woooof!");
        }
    }
}
