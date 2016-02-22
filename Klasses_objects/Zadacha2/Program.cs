using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Policeman firstperson = new Policeman(240, 500, 10);
            Console.WriteLine(firstperson);
            Doctor secondperson = new Doctor(240, 1000, 50, 25);
            Console.WriteLine(secondperson);
        }
    }
}
