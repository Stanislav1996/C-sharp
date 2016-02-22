using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadacha2
{
    class Employee
    {
        public int Hours { get; set; }
        public int Payment { get; set; }
        public Employee(int Hours,int Payment)
        {
            this.Hours = Hours;
            this.Payment = Payment;
        }
    }
}
