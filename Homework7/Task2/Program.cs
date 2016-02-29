using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            string myString = "What`s up my nigga";
            Console.WriteLine(myString.Contains(str));
            string toUpper_str = str.ToUpper();
            Console.WriteLine(myString.Replace(str, toUpper_str));
        }
    }
}
