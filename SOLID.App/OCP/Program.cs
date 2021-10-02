namespace SOLID.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal lion = new Lion();
            lion.MakeSound();

            Animal dog = new Dog();
            dog.MakeSound();

            Animal cow = new Cow();
            cow.MakeSound();
        }
    }
}
