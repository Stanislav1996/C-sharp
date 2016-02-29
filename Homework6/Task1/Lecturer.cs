using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Lecturer:Person,Interface_Lecturer
    {
        public string University { get; set; }
   
        public Lecturer()
        { }
        public Lecturer(string Name, string SurName, int Years, int WorkExp, string University)
            : base(Name, SurName, Years, WorkExp)
        {
            this.Name = Name;
            this.SurName = SurName;
            this.Years = Years;
            this.WorkExp = WorkExp;
            this.University = University;
        }
        public void CheckHomework()
        {
            Console.WriteLine("Homework checked");
        }
        public void Hello()

        { Console.WriteLine("Hello");
        }
        public void Practice()
        {

        }
        public void PrintLecturerInfo()
        {
            Console.WriteLine("I am a lecturer.My name is {0} {1}, I am {2} years old and I have {3} years working experience. My university is {4}"
                , Name, SurName, Years, WorkExp, University);
        }
    }
}
