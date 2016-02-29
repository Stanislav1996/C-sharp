using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Person
    {
        protected string Name { get; set; }
        protected string SurName { get; set; }
        protected int Years { get; set; }
        public int WorkExp { get; set; }
        public static int counter { get; set; }
        public Person()
        { }
        public Person(string Name, string SurName, int Years, int WorkExp)
        {
            this.Name = Name;
            this.SurName = SurName;
            this.Years = Years;
            this.WorkExp = WorkExp;

        }
    }
}