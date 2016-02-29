using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write a math task: ");
            string math1 = Console.ReadLine();
            int counter = 0;
            for (int i = 0; i < math1.Length; i++)
            {
                if (math1[i] == '(')
                {
                    counter++;
                }
                else if (math1[i] == ')')
                {
                    counter--;
                }
                if (counter < 0)
                {
                    break;
                }
            }
            Console.WriteLine(counter);
            if (counter < 0)
            {
                Console.WriteLine(math1 + " false");
            }
            else
            {
                Console.WriteLine(math1 + " true");
            }
        }
    }
    }
}
