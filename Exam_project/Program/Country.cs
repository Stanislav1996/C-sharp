using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Program
{
    public class Country
    {
        public string Name { get; set; }

        public string Capital { get; set; }

        public int Population { get; set; }
        public Country(string name, string Capital, int Population)
        {
            this.Name = name;
            this.Capital = Capital;
            this.Population = Population;
        }
        public override string ToString()
        {
            return string.Format("{0} | {1} | {2}", this.Name, this.Capital, this.Population);
        }
    }
}
