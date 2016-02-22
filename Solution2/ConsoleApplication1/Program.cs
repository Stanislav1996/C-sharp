using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] asd = new int[] {1,2,3,4,5,5,6,7,8 };
            Random rand = new Random();
            for (int i = 0; i < asd.Length; i++)
            {
          //      asd[i] = rand.Next(0,100);
            }
            Array.Sort(asd);
            for (int i = 0; i < asd.Length; i++)
            {
                Console.WriteLine(asd[i]);
            }
            int gosho = int.Parse(Console.ReadLine());
            //int x=Array.BinarySearch(asd, gosho);
            //for (int i = 0; i < 9; i++)
            //{
            //    if (asd[x+i] != asd[x + i+1])
            //    {
            //        Console.WriteLine(asd[x + i+1]);
            //        break;
            //    }
            //}
            for (int i = 0; i < asd.Length; i++)
            {
                if (gosho==asd[i])
                {
                    while (gosho==asd[i])
                    {
                        i++;
                    }
                    Console.WriteLine(asd[i]);
                }
            }
        }
    }
}
