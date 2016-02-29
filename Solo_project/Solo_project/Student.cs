using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Solo_project
{
    public class Student
    {
        public string Name { get; set; }

        public string Faculty { get; set; }

        public int Faculty_number { get; set; }
        public double Avg { get; set; }
         public Student(string name,string Faculty,int faculti_number,double avg)
        {
            this.Name = name;
            this.Faculty = Faculty;
            this.Faculty_number = faculti_number;
            this.Avg = avg;

        }
        public override string ToString()
        {
            return string.Format("{0} | {1} | {2} | {3}", this.Name, this.Faculty, this.Faculty_number,this.Avg);
        }
    }
}