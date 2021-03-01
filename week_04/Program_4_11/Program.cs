using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_4_11
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;

            Console.WriteLine("Podaj liczbę całkowitą: ");
            num = GetNumber();
            OddOrEven(num);

            Console.ReadLine();
        }

        private static void OddOrEven(int number)
        {
            if (number % 2 == 0)
                Console.WriteLine("Liczba jest parzysta");
            else
                Console.WriteLine("Liczba jest nieparzysta");
        }

        private static int GetNumber()
        {
            while (true)
            {
                if (!int.TryParse(Console.ReadLine(), out int number))
                {
                    Console.WriteLine("To nie jest liczba całkowita. Spróbuj jeszcze raz.");
                    continue;
                }
                return number;
            }
        }
    }
}
