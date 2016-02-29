using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class CollegeTeacher:Teacher,Interface_Teacher
    {
        public string College { get; set; }
        public CollegeTeacher()
        { }
        public CollegeTeacher(string Name, string SurName, int Years, int WorkExp, string Subject, string College)
            : base(Name, SurName, Years, WorkExp, Subject)
        {
            this.Name = Name;
            this.SurName = SurName;
            this.Years = Years;
            this.WorkExp = WorkExp;
            this.Subject = Subject;
            this.College = College;
        }
        void Interface_Teacher.CheckHomework()
        {
            Console.WriteLine("Homework checked");
        }
        public void PrintColTeacherInfo()
        {
            Console.WriteLine("I am a college teacher.My name is {0} {1}, I am {2} years old and I have {3} years working experience. My subject is {4},and I work in {5}"
                , Name, SurName, Years, WorkExp, Subject, College);
        }
    }
}
