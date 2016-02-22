using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Cat
    {
        public string Name { get; set; }
        public int Age { get; set; }
/*        public Cat(string name, int age)
        {
            this.Name=name;
            this.Age=age;
        }*/
        public override string ToString()
        {
            return String.Format("Imeto na kotkata e {0} i e na {1} godini"
                , this.Name
                , this.Age);
               
        }
    }
}
