using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha5
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 10; i <= 999; i++)
            {
                if (i < 100)
                {
                    Malki(i);
                }
                if (i > 100)
                {
                    Golemi(i);
                }
            }
        }

        private static void Golemi(int i)
        {
            int a = i / 100;
            int b = i % 10;
            if (a == b)
            {
                Console.WriteLine(i);
            }
        }

        private static void Malki(int i)
        {
            int a = i / 10;
            int b = i % 10;

            if (a == b)
            {
                Console.WriteLine(i);
            }
        }
    }
}
