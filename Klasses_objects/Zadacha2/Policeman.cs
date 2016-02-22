using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha2
{
    class Policeman:Employee
    {
        public int Rang { get; set; }
        public Policeman(int Hours, int Payment, int Rang)
            :base(Hours,Payment)
        {
          //  this.Hours = Hours;
           // this.Payment = Payment;
            this.Rang = Rang;

        }
        public override string ToString()
        {
            return String.Format("Chasove rabota:{0}. Mesechna zaplata:{1}. Rang:{2}",this.Hours,this.Payment,this.Rang);
        }
    }
}
