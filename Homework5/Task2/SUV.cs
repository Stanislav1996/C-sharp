using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class SUV:Car
    {
        public bool HighlyPassable { get; set; }
        public SUV()
        { }
        public SUV(int Price, bool HighlyPassable)
            : base(Price)
        {
            this.HighlyPassable = HighlyPassable;
            this.Price = Price;
        }
        public void SUVInfo()
        {
            Console.WriteLine("SUV price is {0}. Is it highlypassable:{1}", Price, HighlyPassable);
        }
    }
}
