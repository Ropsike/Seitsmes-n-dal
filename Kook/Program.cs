using System;

namespace Kook
{
    class Program
    {
        static void Main(string[] args)
        {
            string cake = "The c4ke i3 4 l1e.";
            
            Console.WriteLine($"The initial string: '{cake}'", cake);
            
            cake = cake.Replace("4", "a").Replace("3", "s").Replace("1", "i");

            Console.WriteLine($"The final string: '{cake}'", cake);

        }
    }
}