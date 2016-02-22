using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha2
{
    class Doctor:Employee
    {
        public int Nightsshift { get; set; }
        public int Dayshifts { get; set; }
        public Doctor(int Hours, int Payment, int Nightsshift,int Dayshifts)
            :base(Hours,Payment)
        {
            //this.Hours = Hours;
            //this.Payment = Payment;
            this.Nightsshift =Nightsshift;
            this.Dayshifts = Dayshifts;

        }
        public override string ToString()
        {
            return String.Format("Chasove rabota:{0}. Mesechna zaplata:{1}.Broi noshtni: {2}.Broi dnevni:{3} "
                ,this.Hours
                ,this.Payment
                ,this.Nightsshift
                ,this.Dayshifts);
        }
    }
}
