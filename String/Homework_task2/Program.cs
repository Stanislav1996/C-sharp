using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_task2
{
    class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            string tekst = Console.ReadLine();
            tekst.Replace(word, word.ToUpper());
            Console.WriteLine(tekst);
        }
    }
}
