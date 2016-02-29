using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    class Celsi
    {
        public double Celsius { get; set; }
        public double Fahrenheit { get; set; }
        public Celsi(double Celsius)
        {
            this.Celsius = Celsius;
        }
        public void Convert()
        {
            Fahrenheit = (Celsius * 1.8) + 32;
            Console.WriteLine("{0} celsius equals to {1} fahrenheit", Celsius, Fahrenheit);
        }
    }
}
