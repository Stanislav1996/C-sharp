using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of lines of the tree: ");
            int a = int.Parse(Console.ReadLine());
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < a - i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k < i * 2 + 1; k++)
                {
                    Console.Write("o");

                }
                Console.WriteLine();
            }
            for (int i = 0; i < a + 2; i++)
            {
                Console.WriteLine(" ");
            }
        }
    }
}
