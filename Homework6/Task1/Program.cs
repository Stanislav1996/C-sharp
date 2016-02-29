using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Teacher First_teacher = new Teacher("Geogri", "Gospodino", 19, 1, "Chemistry");
            First_teacher.Hello();
            Console.WriteLine();
            First_teacher.PrintTeacherInfo();
            Console.WriteLine();
            First_teacher.CheckHomework();
            Console.WriteLine();
            First_teacher.Goodbye();
            Console.WriteLine();
            SchoolTeacher First_Sc_teacher = new SchoolTeacher("Plamen", "Ivanov", 23, 3, "Math", "11A,12G");
            First_Sc_teacher.PrintSchTeacherInfo();
            Console.WriteLine();
            First_Sc_teacher.CheckHomework();
            Console.WriteLine();
            First_Sc_teacher.Classes();
            Console.WriteLine();
            First_Sc_teacher.Animator();
            Console.WriteLine();
            Proffesor First_Proffesor = new Proffesor("Ivan", "Kirilov", 43, 7, "SU", "Doctor");
            First_Proffesor.PrintProfessorInfo();
            Console.WriteLine();
            First_Proffesor.SayTitle();
            Console.WriteLine();
            First_Proffesor.CheckHomework();
            Console.WriteLine();
            First_Proffesor.Exams();
            Console.WriteLine();
            Lecturer First_lecturer = new Lecturer("Stefan", "Chikalov", 47, 24, "Technical University-Sofia");
            First_lecturer.Hello();
            Console.WriteLine();
            First_lecturer.PrintLecturerInfo();
            Console.WriteLine();
            First_lecturer.CheckHomework();
            Console.WriteLine();
            First_lecturer.Practice();
            Console.WriteLine();
            CollegeTeacher First_coll_teacher = new CollegeTeacher("Martin", "Georgiev", 34, 14, "OOP", "Software college");
            First_coll_teacher.PrintColTeacherInfo();
            Console.WriteLine();
            First_coll_teacher.CheckHomework();
            Console.WriteLine();
            Assistant As1 = new Assistant("Bistra", "Toteva", 29, 11, "MU", "headassistant");
            As1.SayName();
            Console.WriteLine();
            As1.PrintAssistantInfo();
            Console.WriteLine();
            As1.ScienceArticles();
            Console.WriteLine();
            As1.CheckHomework();
            Console.WriteLine();
            As1.CheckExams();
        }
    }
}
