using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_3_23
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int losowa = random.Next(1, 101);
            int ileProb = 0;
            int wybor;

            try
            {
                do
                {
                    Console.WriteLine("Podaj liczbę z zakresu 1-100");
                    wybor = int.Parse(Console.ReadLine());

                    if (wybor < losowa)
                        Console.WriteLine("Za mało");
                    else if (wybor > losowa)
                        Console.WriteLine("Za dużo");

                    ileProb++;
                }
                while (wybor != losowa);

                Console.WriteLine("Brawo!!! Ilość prób: {0}", ileProb);
            }
            catch (Exception)
            {
                Console.WriteLine("Zły format wprowadzonych danych.");
            }

            Console.ReadLine();
        }
    }
}