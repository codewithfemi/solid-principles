namespace SOLID.App
{
    class Program
    {
        static void Main(string[] args)
        {
            Fruit fruit = new Orange();
            fruit.DisplayColor();

            fruit = new Apple();
            fruit.DisplayColor();
        }
    }
}
