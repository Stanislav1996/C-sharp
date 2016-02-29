using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Teacher : Person, Interface_Teacher
    {
        public string Subject { get; set; }
        public Teacher()
        { }
        public Teacher(string Name, string SurName, int Years, int WorkExp, string Subject)
            : base(Name, SurName, Years, WorkExp)
        {
            this.Name = Name;
            this.SurName = SurName;
            this.Years = Years;
            this.WorkExp = WorkExp;
            this.Subject = Subject;
        }
        public void Hello()
        {
            Console.WriteLine("Hello");
        }
        public void Goodbye()
        {
            Console.WriteLine("Goodbye,children!");
        }
        public void CheckHomework()
        {
            Console.WriteLine("Homework checked");
        }
        public void PrintTeacherInfo()
        {
            Console.WriteLine("I am a Teacher.My name is {0} {1}, I am {2} years old and I have {3} years working experience. My subject is {4}"
                , Name, SurName, Years, WorkExp, Subject);
        }
    }
}
