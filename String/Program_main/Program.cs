using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_main
{
    class Program
    {
        static void Main(string[] args)
        {
            Student[] Gosho = new Student[5];
            Gosho[0] = new Student();
            Gosho[1] = new Student();
            Gosho[0].Name = "Gosho";
            Gosho[0].FamilyName = "Georgiev";
            Gosho[0].FactNummber = 1234;
            Gosho[0].Group = 7;
            Gosho[1].Name = "Pesho";
            Gosho[1].FamilyName = "peshev";
            Gosho[1].FactNummber = 234;
            Gosho[1].Group = 8;
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine(Gosho[i]);
            }
          
        }
    }
}
