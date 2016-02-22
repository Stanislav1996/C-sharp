using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    class Program
    {
        static void Main(string[] args)
        {
            string arr = Console.ReadLine();
            Console.WriteLine( arr.StartsWith("John"));
            Console.WriteLine(   arr.EndsWith("!"));
            Console.WriteLine(   arr.Contains("party"));
        }
    }
}
