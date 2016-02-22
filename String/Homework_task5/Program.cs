using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_task5
{
    class Program
    {
        static void Main(string[] args)
        {
            string Math = Console.ReadLine();
            int counter = 0;
            for (int i = 0; i < Math.Length; i++)
            {
                if (Math[i]=='(')
                {
                    counter++;
                }
                if (Math[i] == ')')
                {
                    counter--;
                }
                if (counter==-1)
                {
                    Console.WriteLine("Nepravilno postavqne na skobi");
                    break;
                }
            }
            if (counter==0)
            {
                Console.WriteLine("Skobite sa postaveni pravilno");
            }
        }
    }
}
