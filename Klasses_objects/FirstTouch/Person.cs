using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTouch
{
    class Person
    {
        public string Name { get; set; }
        public string email { get; set; }
        public int Age { get; set; }
        public Person(string name,int age,string email)
        {
            this.Name = name;
            this.Age = age;
            this.email = email;

        }
        public Person()
        { }
    }
   }

