using System;

namespace SOLID.App
{
    class Program
    {
        static void Main(string[] args)
        {
            var person = new Person(new BServiceProvider());
            person.DeliverMessage("12312312312");
        }
    }
}
