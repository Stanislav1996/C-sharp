using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write down a sentence: ");
            string sentence = Console.ReadLine();
            string toLower_sentence = sentence.ToLower();
            string[] words = Regex.Split(toLower_sentence, @"[^\w]");
            Array.Sort(words);
            Console.WriteLine("Words splited");
            foreach (var word in words)
            {
                Console.Write(word + ",");
            }
        }
    }
}
