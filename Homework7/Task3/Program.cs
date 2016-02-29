using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Text: ");
            string text = Console.ReadLine();
            Console.WriteLine("Enter a word for a count in the text");
            string word = Console.ReadLine();
            if (text.Contains(word))
            {
                int count = Regex.Matches(text, word).Count;
                Console.WriteLine("The count of the word is {0}", count);
            }
        }
    }
}
