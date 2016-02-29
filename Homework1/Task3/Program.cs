using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            string str1 = "Hello,";
            string str2 = "world";
            Console.WriteLine(str1 + str2);

            Console.WriteLine("Hello,world" == str1 + str2);
        }
    }
}
