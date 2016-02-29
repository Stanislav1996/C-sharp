using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha2
{
    class Program
    {
        static void Main(string[] args)
        {

            string Name = Console.ReadLine();

            Metod(Name);
        }

        private static void Metod(string Name)
        {
            Console.WriteLine("Hello  " + Name);
        }
    }
}
