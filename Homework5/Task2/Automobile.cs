using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Automobile:Car
    {
        public int FuelConsumption { get; set; }
        public Automobile()
        { }
        public Automobile(int FuelConsumption, int Price)
            : base(Price)
        {
            this.FuelConsumption = FuelConsumption;
            this.Price = Price;
        }
        public void CarInfo()
        {
            Console.WriteLine("Car price is {0} and it consumes {1} litres per 100km", Price, FuelConsumption);
        }
    }
}
