using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha4
{
    class Program
    {
        static void Main(string[] args)
        {


            int a = int.Parse(Console.ReadLine());
            Odd(a);
        }

        private static void Odd(int a)
        {

            if (a % 2 == 0)
            {
                Console.WriteLine("Chetno");
            }
            else
            {
                Console.WriteLine("Nechetno");
            }
        }
    }
}
