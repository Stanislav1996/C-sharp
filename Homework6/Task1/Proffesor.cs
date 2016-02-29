using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Proffesor:Lecturer,Interface_Proffesor
    {

        public string Title { get; set; }
 
        public Proffesor(string Name, string SurName, int Years, int WorkExp, string University, string Title)
            :base (Name, SurName, Years,WorkExp,University)
        {
            this.Name = Name;
            this.SurName = SurName;
            this.Years = Years;
            this.WorkExp = WorkExp;
            this.University = University;
            this.Title = Title;
        }
        public void SayTitle()
        {
            Console.WriteLine("The professor title is {0} and has {1} years of experience", Title, WorkExp);
        }
        public void Exams()
        {
            Console.WriteLine("Every 6 months {0} has exams for the students", Name);
        }
        public void PrintProfessorInfo()
        {
            Console.WriteLine("I am a professor.My name is {0} {1}, I am {2} years old and I have {3} years working experience. My university is {4},and I am a {5}"
                , Name, SurName, Years, WorkExp, University, Title);
        }
    }
}
