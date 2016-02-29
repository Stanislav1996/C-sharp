using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            triangle sides = new triangle(9, 3);
            sides.hypotenuse();
            sides.angle();
        }
    }
}
