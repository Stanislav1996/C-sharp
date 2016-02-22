using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTouch
{
    class Program
    {
        static void Main(string[] args)
        {
            Person Stani = new Person();
            Stani.Age = 19;
            Stani.Name = Console.ReadLine();
            Stani.email = "Motam se @abv.bg";
            Console.WriteLine(Stani.Name);
            Console.WriteLine(Stani.email);
            Console.WriteLine(Stani.Age);
            Person Georgi = new Person();
            Georgi.Age = 21;
            Georgi.Name = "Gosho";
            Georgi.email = "Ucha se @gmail.com";
            Console.WriteLine(Georgi.Name);
            Console.WriteLine(Georgi.email);
            Console.WriteLine(Georgi.Age);
            Person Ivaylo = new Person("Ivaylo", 24, "DEV@mail.bg");
            Console.WriteLine(Ivaylo.Name);
            Console.WriteLine(Ivaylo.Age);
            Console.WriteLine(Ivaylo.email);
            if (Georgi.Age > Ivaylo.Age)
            {
                Console.WriteLine("zdrasti");
            }
        }
    }
}
