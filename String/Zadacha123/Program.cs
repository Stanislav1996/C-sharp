using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha123
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader reader = new StreamReader("Coutries.txt"))
            {
                using (StreamWriter writer = new StreamWriter("Cities.txt"))
                {
                    string line = reader.ReadLine();
                    int lineNumber = 0;
                    while (line != null)
                    {
                        lineNumber++;
                        Console.WriteLine("Stolicata na  {0}:", lineNumber);
                        writer.WriteLine(Console.ReadLine());
                        line = reader.ReadLine();
                    }
                }
            }

        }
    }
}
