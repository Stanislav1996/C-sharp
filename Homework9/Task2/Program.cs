using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[20];
            Random rand = new Random();
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = rand.Next(1, 100);
            }
            var stopwatch1 = new Stopwatch();
            stopwatch1.Start();
            Array.Sort(nums);
            Console.WriteLine("Randomly entered numbers:");
            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write("{0}, ", nums[i]);
            }
            stopwatch1.Stop();
            double elapsed_time = stopwatch1.ElapsedMilliseconds;
            List<int> Even = new List<int>();
            List<int> Odd = new List<int>();
            int temp;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] % 2 == 0)
                {
                    temp = nums[i];
                    Even.Add(temp);
                }
                else if (nums[i] % 2 != 0)
                {
                    temp = nums[i];
                    Odd.Add(temp);
                }
            }
            var stopwatch2 = new Stopwatch();
            stopwatch2.Start();
            Even.Sort();
            Console.WriteLine();
            Console.WriteLine("Even numbers, sorted ascendingly:");
            for (int i = 0; i < Even.Count; i++)
            {
                Console.Write("{0}, ", Even[i]);
            }
            Console.WriteLine();
            Odd.Sort();
            Console.WriteLine("Odd numbers, sorted descendingly:");
            for (int i = Odd.Count - 1; i >= 0; i--)
            {
                Console.Write("{0}, ", Odd[i]);
            }
            stopwatch2.Stop();
            double elapsedtime = stopwatch2.ElapsedMilliseconds;
            Console.WriteLine();
            Console.WriteLine("Took {0} miliseconds to sort the big array.", elapsed_time);
            Console.WriteLine("Took {0} miliseconds  to sort the 2 smaller arrays.", elapsedtime);
        }
    }
}
