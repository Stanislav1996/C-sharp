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

            Car[] Cars = new Car[10];
            for (int i = 0; i < Cars.Length / 2; i++)
            {
                Console.WriteLine("Enter price and fuelconsumption:");
                Cars[i] = new Automobile();
                (Cars[i] as Automobile).Price = int.Parse(Console.ReadLine());
                (Cars[i] as Automobile).FuelConsumption = int.Parse(Console.ReadLine());
                (Cars[i] as Automobile).CarInfo();
            }
            for (int i = Cars.Length / 2; i < Cars.Length; i++)
            {
                Console.WriteLine("Enter price and is 4x4:");
                Cars[i] = new SUV();
                (Cars[i] as SUV).Price = int.Parse(Console.ReadLine());
                (Cars[i] as SUV).HighlyPassable = bool.Parse(Console.ReadLine());
                (Cars[i] as SUV).SUVInfo();

            }
        }
    }
}
