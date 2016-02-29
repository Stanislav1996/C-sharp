using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class triangle
    {
        public double ab;
        public double bc;
        public double ac;
        public double AB { get; set; }
        public double BC { get; set; }
        public double AC { get; set; }
        public triangle(double AB, double BC)
        {
            this.AB = AB;
            this.BC = BC;
        }
        public void hypotenuse()
        {

            ab = Math.Pow(AB, 2);
            bc = Math.Pow(BC, 2);
            AC = AB + BC;
            ac = Math.Pow(AC, 2);

            Console.WriteLine("The hypotenuse is {0}cm ", AC);
        }
        public void angle()
        {
            double anglealpha = BC / AC;
            double angleA = Math.Sin(anglealpha);
            anglealpha = angleA * 180 / Math.PI;
            int alpha = Convert.ToInt16(anglealpha);
            double anglebeta = AB / AC;
            double angleB = Math.Pow(anglebeta, -1);
            anglebeta = angleB * 180 / Math.PI;
            int beta = Convert.ToInt16(anglebeta);
            Console.WriteLine("Angle alpha is {0}, beta is {1}", alpha, beta);
        }
    }
}
