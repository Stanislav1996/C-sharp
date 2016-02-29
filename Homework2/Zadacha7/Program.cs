using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha7
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstnumber = int.Parse(Console.ReadLine());
            int factfirst = 1;
            int factsecond = 1;
            int factthird = 1;
            int secondnumber = int.Parse(Console.ReadLine());
            for (int i = 1; i < firstnumber + 1; i++)
            {
                factfirst *= i;
            }
            for (int i = 1; i < secondnumber + 1; i++)
            {
                factsecond *= i;
            }
            for (int i = 1; i < firstnumber - secondnumber; i++)
            {
                factthird *= i;
            }
            double sum = factfirst / factsecond;
            Console.WriteLine(sum);
            double sum2 = (factfirst * factsecond) / factthird;
            Console.WriteLine(sum2);
        }
    }
}
