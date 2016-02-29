using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "This is an apple. This is an orange. I love apples and oranges.";
            string Apple_str = "apple";
            if (str.Contains(Apple_str))
            {
                string[] split = str.Split('.');
                string a = split[0];
                string b = split[1];
                string c = split[2];
                if (a.Contains(Apple_str))
                {
                    Console.WriteLine(a);
                }
                if (b.Contains(Apple_str))
                {
                    Console.WriteLine(b);
                }
                if (c.Contains(Apple_str))
                {
                    Console.WriteLine(c);
                }

            }
        }
    }
}
