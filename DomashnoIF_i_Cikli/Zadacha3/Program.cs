using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha3
{
    class Program
    {
        static void Main(string[] args)
        {
            string karta = Console.ReadLine();
            if (karta == "2" || 
                karta == "3" ||
                karta == "4" ||
                karta == "5" ||
                karta == "6" ||
                karta == "7" ||
                karta == "8" ||
                karta == "9" ||
                karta == "10" ||
                karta == "J" ||
                karta == "Q" ||
                karta == "K" ||
                karta == "A")
            {
                Console.WriteLine("Validna karta");
            }
            else
            {
                Console.WriteLine("Nevalidna karta");

            }
        }
    }
}
