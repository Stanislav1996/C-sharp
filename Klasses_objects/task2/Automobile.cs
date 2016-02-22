using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    class Automobile:Car
    {
        public int razhod;
        public Automobile(int razhod,int prize)
        {
            this.razhod = razhod;
        }
        public override string ToString()
        {
            return String.Format("Razhod na gorivo{0} i cena {1} "
                , this.razhod
                , this.prize)
               ;
        }
    }
}
