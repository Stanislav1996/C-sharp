using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program_main
{
    class Student
    {
        public string Name { get; set; }
        public string FamilyName { get; set; }
        public int FactNummber { get; set; }
        public int Group { get; set; }

    //    public  Student (string name,string familyname,int fact,int group)
     //   {
     //       this.Name = name;
     ///       this.FamilyName = FamilyName;
     //       this.FactNummber = fact;
     //       this.Group = group;
     //   }

        

        public override string ToString()
        {
            return String.Format("Name:{0}. Family name:{1}.Fakulteten Nomer: {2}.Group:{3} "
                , this.Name
                , this.FamilyName
                , this.FactNummber
                , this.Group);
        }
    }
}
