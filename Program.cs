using System;

namespace Persons
{
    class Program
    {
        static void Main(string[] args)
        {
            Person Jhoan = new Person ("Jhoan Smith");
            Jhoan.SayHello();

            Person Jhoana = new Person ("Jhoana Smith");
            Jhoana.SayHello();

            Console.WriteLine(Person.bloodColor);

            Person.PrintRace();
        }
    }
}
