using System;
using System.Collections.Generic;
using System.Text;

namespace Database
{
   public class Case
    {
        public int CaseID { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime ClosedDate { get; set; }
        public Double Price { get; set; }
        public Realtor Realtor { get; set; }
        public  ICollection<Property> Property { get; set; }

    }
}
