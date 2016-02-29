using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Nums;
            int lenght = int.Parse(Console.ReadLine());
            int[] Numbers = new int[lenght];
            for (int i = 0; i < Numbers.Length; i++)
            {
                Numbers[i]=int.Parse(Console.ReadLine());
            }
            Nums = Count(Numbers);
            for (int i = 0; i < Nums.Length; i++)
            {
                if (Nums[i] != 0)
                {
                    Console.WriteLine(i + " -> " + Nums[i] + " times");
                }
            }
        }
        static int[] Count(int[] arr)
        {
            int[] CountNum = new int[1001];
            for (int i = 0; i < arr.Length; i++)
            {
                CountNum[arr[i]]++;
            }
            return CountNum;
        }
    }
    }
}
