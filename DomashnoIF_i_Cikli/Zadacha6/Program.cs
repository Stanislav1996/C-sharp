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
            Console.WriteLine("Vuvedete broq chisla: ");
            int number=int.Parse(Console.ReadLine());
            int max = int.MinValue;
            int min = int.MaxValue;
            int a;
            for (int i = 0; i < number; i++)
            {
                Console.WriteLine("Vuvedete chislo: ");
                a = int.Parse(Console.ReadLine());
                if (max<a)
                {
                    max = a;
                }
                if (min>a)
                {
                    min = a;
                }

            }
            Console.WriteLine("Min e : "+min);
            Console.WriteLine("Max e : "+max);
        }
    }
}
