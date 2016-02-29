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
            Console.WriteLine("Enter a string:");
            string str = Console.ReadLine();
            StringBuilder revstr = new StringBuilder();
            for (int i = str.Length - 1; i >= 0; i--)
            {
                revstr.Append(str[i]);
            }
            Console.WriteLine(revstr);
        }
    }
}
