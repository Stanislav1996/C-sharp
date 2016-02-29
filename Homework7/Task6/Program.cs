using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader reader = new StreamReader("text.txt"))
            {
                using (StreamWriter writer = new StreamWriter("text1.txt"))
                {
                    string text = reader.ReadToEnd();
                    string word = Regex.Replace(text, @"zdrastiiii", "");
                    text = word;
                    Console.WriteLine(text);
                    writer.Write(text);
                }

            }
        }
    }
}
