using System;

namespace SOLID.App
{
    public class Cow : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Moooo!!!");
        }
    }
}
