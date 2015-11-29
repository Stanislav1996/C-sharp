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
            int a;
            double b;
            string c;
            Console.WriteLine("Vuvedete TIP promenliva");
            Console.WriteLine("1.int");
            Console.WriteLine("2.double");
            Console.WriteLine("3.string");
            int x = int.Parse(Console.ReadLine());
            switch (x)
            {
                case 1:
                    {
                        a = int.Parse(Console.ReadLine());
                        Console.WriteLine(a+1);
                        break;
                    }
                case 2:
                    {
                        b = double.Parse(Console.ReadLine());
                        Console.WriteLine(b+1);
                        break;
                    }
                case 3:
                    {
                        c = (Console.ReadLine());
                        Console.WriteLine(c+"*");
                        break;
                    }
            }

        }
    }
}
