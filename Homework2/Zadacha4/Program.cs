using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha4
{
    class Program
    {
        static void Main(string[] args)
        {
            int FirstNumber = int.Parse(Console.ReadLine());
            int SecondNumber = int.Parse(Console.ReadLine());
            int BiggerNummber;
            int NOD=0;
            if (FirstNumber>SecondNumber)
            {
                BiggerNummber = FirstNumber;
            }
            else
            {
                BiggerNummber = SecondNumber;
            }
            for (int i = 1; i < BiggerNummber; i++)
            {
                if (FirstNumber%i==0&&SecondNumber%i==0)
                {
                    NOD = i;
                }
                
            }
            Console.WriteLine(NOD);

        }
    }
}
