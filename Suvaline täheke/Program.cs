using System;

namespace Suvaline_täheke
{
    class Program
    {
        
            static void Main(string[] args)
            {
                Console.WriteLine("Palun sisesta enda eesnimi:");
                string name = Console.ReadLine();
             Random rnd = new Random();
             int index = rnd.Next(0, name.Length);

             Console.WriteLine(name[index]);



            }
        }
    }
