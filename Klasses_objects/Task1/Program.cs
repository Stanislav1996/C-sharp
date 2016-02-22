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
            Cat[] firstcat = new Cat[5];
            firstcat[0] = new Cat();
            firstcat[0].Name = "pesho";
            firstcat[0].Age = 5;
            firstcat[1] = new Cat();
            firstcat[1].Name = "Gosho";
            firstcat[1].Age = 6;
            firstcat[2] = new Cat();
            firstcat[2].Name = "Puci";
            firstcat[2].Age = 3;

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(firstcat[i]);
            }
        }
    }
}
