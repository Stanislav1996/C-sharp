using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int lenght = int.Parse(Console.ReadLine());
            int[] array = new int[lenght];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            
            int counter = 0;
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] == array[i + 1])
                {
                    counter++;
                    if (counter >= array.Length / 2)
                    {
                        counter++;
                        Console.WriteLine(array[i] + " is the majorant of the array, it appears " + counter + " times");
                    }
                }
            }
        }
    }
}
