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
            List<int> NumList = new List<int>();
            
            Console.WriteLine("Enter numbers:");
            string line = Console.ReadLine();
            while (line != "")
            {
                int number = int.Parse(line);
                NumList.Add(number);
                line = Console.ReadLine();
            }
            Console.WriteLine(NumList.Sum());
            Console.WriteLine(NumList.Average());
        }
    }
}
