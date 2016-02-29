using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Car
    {
        public int Price { get; set; }
        public Car()
        { }
        protected Car(int Price)
        {
            this.Price = Price;
        }
    }
}
