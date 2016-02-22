using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha6
{
    class Program
    {
        static void Main(string[] args)
        {
            int b = 1;
            int a = int.Parse(Console.ReadLine());
            Recursion(a,b);
        }

        private static void Recursion(int a,int b)
        {
            b *= b;
            if(b<=a)
            {
                Recursion(a, b + 1);
            }
            else
            {
                Console.WriteLine(b);
            }
        }
    }
}
