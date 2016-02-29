using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat[] Cats = new Cat[10];
            for (int i = 0; i < Cats.Length; i++)
            {
                Cats[i] = new Cat();
                Console.WriteLine("Enter name:");
                Cats[i].Name = Console.ReadLine();
                Console.WriteLine("Enter years:");
                Cats[i].Years = int.Parse(Console.ReadLine());
                Cats[i].Say();
            }
        }
    }
}