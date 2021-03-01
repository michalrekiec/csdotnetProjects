using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie_3_21
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dataUrodzenia;

            try
            {

                Console.WriteLine("Podaj swoje imię");
                var imie = Console.ReadLine();

                Console.WriteLine("Podaj miejsce urodzenia");
                var miejsce = Console.ReadLine();

                Console.WriteLine("Podaj rok urodzenia");
                var rokUrodzenia = int.Parse(Console.ReadLine());

                Console.WriteLine("Podaj miesiąc urodzenia");
                var miesiacUrodzenia = int.Parse(Console.ReadLine());

                Console.WriteLine("Podaj dzień miesiąca, w ktorym się urodziłeś/urodziłaś");
                var dzienUrodzenia = int.Parse(Console.ReadLine());

                dataUrodzenia = new DateTime(rokUrodzenia, miesiacUrodzenia, dzienUrodzenia);
                Console.WriteLine("Cześć {0}, urodziłeś się w miejscowości {1} i masz {2} lat.", imie, miejsce, ObliczWiek(dataUrodzenia));
            }
            catch (FormatException)
            {
                Console.WriteLine("Niewłaściwy format danych.");
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Niewłaściwa data urodzenia.");
            }

            Console.ReadLine();
        }
        private static int ObliczWiek(DateTime dataUr)
        {
            if (DateTime.Now.DayOfYear >= dataUr.DayOfYear)
                return DateTime.Now.Year - dataUr.Year;
            else
                return (DateTime.Now.Year - dataUr.Year) - 1;
        }
    }
}
