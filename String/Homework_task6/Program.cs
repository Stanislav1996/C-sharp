using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_task6
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
                        for (int i = 0; i < line.Length; i++)
                        {
                            if (line[i] ==','||
                                line[i] == '.' ||
                                line[i] == '!' ||
                                line[i] == '?' ||
                                line[i] == ':' ||
                                line[i] == ';' ||
                                line[i] == '(' ||
                                line[i] == ')' ||
                                line[i] == '-' )
                            {
                                i++;
                            }
                        }
                        line = reader.ReadLine();
                    }
                }
            }
        }
    }
}
