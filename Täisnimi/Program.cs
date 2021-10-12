using System;

namespace Täisnimi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta oma eesnimi:");
            string first = Console.ReadLine();
            Console.WriteLine("Sisesta oma perekonnanimi:");
            string last = Console.ReadLine();

            Console.WriteLine($"Tere, {first[0]}. {last[0]}.");
        }
    }
}
