using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Triangle
    {
        public double a { get; set; }
        public double b { get; set; }
        public double C(double a, double b,double c)
        {
            c = Math.Sqrt((a * a) + (b * b));
            return c;
        }
        public double Sin(double C, double b)
        {

            double sin = b / C;
            return sin;
        }
        public double Cos(double C, double a)
        {
            double Cos = a / C;
            return Cos;
        }
        public double TG(double Cos, double Sin)
        {
            double TG = Sin / Cos;
            return TG;
        }

        //public Triangle(double C, double Sin, double Cos, double TG)
        //{
            //this.C = C;
        
        //}
        //public override string ToString()
        //{
        //    return String.Format("Hipotenuzata na triagulniak e :{0}. Sin:{1}. Cos:{2}. Tg:{3}",
        //        C,
        //       Triangle.Sin,
        //       Triangle.Cos,
        //       Triangle.TG);
        //}

    }
}
