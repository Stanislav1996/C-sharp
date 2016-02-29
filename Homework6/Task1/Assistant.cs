using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Assistant:Lecturer,Interface_Assistant
    {
        public string HeadAssistant { get; set; }
        public Assistant(string Name, string SurName, int Years, int WorkExp, string University, string HeadAssistant)
            : base(Name, SurName, Years, WorkExp, University)
        {
            this.Name = Name;
            this.SurName = SurName;
            this.Years = Years;
            this.WorkExp = WorkExp;
            this.University = University;
            this.HeadAssistant = HeadAssistant;
        }

        public void SayName()
        {
            Console.WriteLine("Assistant name is {0} and is {1}", this.Name, this.HeadAssistant);
        }
        public void ScienceArticles()
        {
            Console.WriteLine("Assistant {0} has 3 science articles", Name);
        }
        public void CheckHomework()
        {
            
            Console.WriteLine("All homeworks are checked");
        }
        public void CheckExams()
        {
            Console.WriteLine("Every 6 months {0} checks exams for the students", Name);
        }
        public void PrintAssistantInfo()
        {
            Console.WriteLine("I am an assistant.My name is {0} {1}, I am {2} years old and I have {3} years working experience. My university is {4}. I am {5}"
                , Name, SurName, Years, WorkExp, University, HeadAssistant);
        }
    }
}
