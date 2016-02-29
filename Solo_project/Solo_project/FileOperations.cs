using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace Solo_project
{
    public class FileOperations
    {
        public const string FilePath = @"C:\Users\Stanislav\Desktop\AVG.txt";

        public static List<Student> ReadStudentsfromdatabase()
        {
            var listOfStudent = new List<Student>();

            using (var reader = new StreamReader(FileOperations.FilePath))
            {
                var CurrentStudent = reader.ReadLine();

                while (CurrentStudent != null)
                {
                    var currentStudent = CurrentStudent.Split('|');
                    var Student = new Student(
                        currentStudent[0].Trim(),
                       currentStudent[1].Trim(),
                        int.Parse(currentStudent[2].Trim()),
                        double.Parse(currentStudent[3].Trim()));
                    listOfStudent.Add(Student);

                    CurrentStudent = reader.ReadLine();
                }
            }

            return listOfStudent;
        }
        public static bool Addstudenttodatabase(Student Studenttoadd)
        {
            try
            {
                using (var writer = new StreamWriter(FileOperations.FilePath, true))
                {
                    writer.WriteLine(Studenttoadd);
                }

                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }
    }
}