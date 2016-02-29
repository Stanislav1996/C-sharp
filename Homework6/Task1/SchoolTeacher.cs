using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class SchoolTeacher:Teacher,Interface_SchoolTeacher,Interface_Teacher
    {
        public string SchoolClasses { get; set; }
        private string[] Schoolclasses = new string[] { "11B", "12B" };
        public SchoolTeacher()
        { }
        public SchoolTeacher(string Name, string SurName, int Years, int WorkExp, string Subject, string SchoolClasses)
            : base(Name, SurName, Years, WorkExp, Subject)
        {
            this.Name = Name;
            this.SurName = SurName;
            this.Years = Years;
            this.WorkExp = WorkExp;
            this.Subject = Subject;
            this.SchoolClasses = SchoolClasses;
        }
        void Interface_Teacher.CheckHomework()
        {
            Console.WriteLine("Homework checked");
        }
        public void Animator()
        {
            Console.WriteLine("All kids are having fun :D");
        }
        public void Classes()
        {
            Console.WriteLine("The school teacher has {0} classes", SchoolClasses);
        }
        public void PrintSchTeacherInfo()
        {
            Console.WriteLine("I am a school teacher.My name is {0} {1}, I am {2} years old and I have {3} years working experience. My subject is {4}, I got {5} classes"
                , Name, SurName, Years, WorkExp, Subject, SchoolClasses);
        }
    }
}
