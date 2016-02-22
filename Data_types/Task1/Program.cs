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
            int index = 0;
            int max = 0;
            List<Company> Companies = new List<Company>();
            Console.WriteLine("Insert 3 companies: ");
            for (int i = 0; i < 3; i++)
            {
                Companies.Add(new Company()
                {
                    Name = Console.ReadLine(),
                    Workers = int.Parse(Console.ReadLine())
                });
            }
            foreach (var item in Companies)
            {

                if (item.Workers > max)
                {
                    max = item.Workers;
                    index = Companies.IndexOf(item);
                }
            }
            Companies.RemoveAt(index);
            foreach (var item in Companies)
            {
                Console.WriteLine(String.Format("Name of the Company {0} and numbers of workers in it: {1}",
                    item.Name,
                    item.Workers
                    ));
            }
            Console.WriteLine("Insert 2 more Companies");
            for (int i = 0; i < 2; i++)
            {
                Companies.Add(new Company()
                {
                    Name = Console.ReadLine(),
                    Workers = int.Parse(Console.ReadLine())
                });
            }
            int indexofStrings = 0;
            int MaxLenght = 0;
            foreach (var item in Companies)
            {

                if (item.Name.Length > MaxLenght)
                {
                    MaxLenght = item.Name.Length;
                    indexofStrings = Companies.IndexOf(item);
                }
            }
            Console.WriteLine(String.Format(@"The longest name of a company is {0} with {1} lenght. 
                Write new name: 
                ",
                Companies[indexofStrings].Name,
                MaxLenght
                ));
            Companies.Insert(indexofStrings, new Company()
            {
                Name = Console.ReadLine(),
                Workers = int.Parse(Console.ReadLine())

            });
            Companies.RemoveAt(indexofStrings + 1);
            foreach (var item in Companies)
            {
                Console.WriteLine(String.Format("Name of the Company {0} and numbers of workers in it: {1}",
                    item.Name,
                    item.Workers
                    ));
            }
        }
    }
}
