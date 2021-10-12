using System;

namespace Eesnimi tagurpidi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Palun sisesta enda eesnimi:");
            string FirstName = Console.ReadLine();

            for (int i = FirstName.Length - 1; i >= 0; i--)
            {
                if (FirstName.Length > 5)
                {
                    Console.Write(FirstName[i]);
                }
                else
                {
                    Console.WriteLine(FirstName);
                    break;
                }
            }
        }
    }
}