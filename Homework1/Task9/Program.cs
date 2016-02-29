using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a word with five or more letters: ");
            string str = Console.ReadLine();
            Console.WriteLine("The 5th symbol of the word is:" + " " + str[4]);
        }
    }
}
