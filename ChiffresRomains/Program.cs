using System;

namespace RomanNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            do
            {
                Console.Clear();
                Console.WriteLine("----   Roman Numbers   ----");
                Console.WriteLine("---------------------------");
                Console.WriteLine();
                Console.WriteLine("Type the number you want to get in Roman or type 0 to Exit : ");
                if (int.TryParse(Console.ReadLine(), out number) && number > 0)
                {
                    Console.WriteLine();
                    Console.WriteLine(new RomanNumber(number).Generate());
                    Console.WriteLine();
                    Console.WriteLine("Press a key to continue...");
                    Console.ReadKey();
                }
            } while (number > 0);
        }
    }
}
