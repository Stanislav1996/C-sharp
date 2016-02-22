using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Car[] arr = new Car[10];
            arr[0]= new Car();
            arr[0].prize = 1000;
            arr[0] = new Car();
            arr[0].prize = 1000;
            arr[0] = new Car();
            arr[0].prize = 1000;
            for (int i = 0; i < 10; i++)
            {
                Automobile firstcat = new Automobile(car[i], 12);
            }
        }
    }
}
