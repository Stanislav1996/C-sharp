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

            Random x = new Random();
            int a = 0;
            int b = 0;
            int c = 0;
            for (int i = 0; i < 10; i++)
            {

                a = x.Next(-100, 100);
                b = x.Next(-100, 100);
                c = x.Next(-100, 100);
                Umnojenie(a, b, c);
            }
        }

        private static void Umnojenie(int a, int b, int c)
        {

            int q = a * b * c;
            Console.WriteLine(q);
        }
    }
    
}
