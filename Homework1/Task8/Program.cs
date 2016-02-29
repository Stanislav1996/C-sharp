using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task8
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "Kvo staa maina !";
            string str2 = "maina !";
            bool b = str1.Contains(str2);

            Console.WriteLine("Does str1 contain str2: " + b);
        }
    }
}
