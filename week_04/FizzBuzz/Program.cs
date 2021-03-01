using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            FizzBuzz fizzBuzz = new FizzBuzz();
            int number = 0;

            Console.WriteLine("Podaj liczbę całkowitą. Wpisz 'k' jeśli chcesz wyjść z programu. ");

            while (true)
            {
                number = GetValue();
                Console.WriteLine(fizzBuzz.GetFizzOrBuzz(number));
            }
        }

        private static int GetValue()
        {
            while(true)
            {
                var val = Console.ReadLine();
                if (val.ToUpper() == "K")
                {
                    Environment.Exit(0);
                }

                if (!int.TryParse(val, out int num))
                {
                    Console.WriteLine("To nie jest liczba całkowita");
                    continue;
                }

                return num;
            }
        }
    }
}
