using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            Maxnumber(a, b, c);
        }

        private static void Maxnumber(int a, int b, int c)
        {
            if (a > c && a > b)
            {
                Console.WriteLine(a);
            }
            if (b > c && b > a)
            {
                Console.WriteLine(b);
            }
            if (c > a && c > b)
            {
                Console.WriteLine(c);
            }
        }
    }
}
