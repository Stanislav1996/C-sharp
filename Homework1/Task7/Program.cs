using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write the double number: ");
            double d =double.Parse(Console.ReadLine());
            Console.WriteLine("Write the integer number: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine(d / b);
        }
    }
}
