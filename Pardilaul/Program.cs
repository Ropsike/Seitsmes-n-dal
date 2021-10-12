using System;

namespace Pardilaul
{
    class Program
    {
        static void Main(string[] args)
        {


            string ducks;
            for (int i = 5; i > 0; i--)
            {
                if (i > 1)
                {
                    ducks = "Parti";

                }

                else
                {
                    ducks = "Part";
                }



                Console.WriteLine($"{i} Väikest {ducks} Läks ühel päeval välja");
                Console.WriteLine("Üle mägede kaugele");
                Console.WriteLine("Ema part ütles, \"Quack, quack, quack, quack \"");

                if (i == 2)
                {

                    ducks = "Part";

                }

                if (i > 1)
                    Console.WriteLine($"Aga ainult {i - 1 } Väikest {ducks} Tuli tagasi.");

                else
                {
                    Console.WriteLine($"Aga mitte ükski {i + 4} väike {ducks} ei tulnud tagasi. ");

                }


                Console.WriteLine();
            }
        }

    }



}
