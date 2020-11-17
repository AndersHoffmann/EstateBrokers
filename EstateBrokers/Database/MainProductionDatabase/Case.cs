using System;
using System.Collections.Generic;
using System.Text;

namespace Database
{
   public class Case
    {
        int CaseID { get; set; }
        DateTime CreationDate { get; set; }
        DateTime ClosedDate { get; set; }
        Double Price { get; set; }
        Realtor Realtor { get; set; }
        public ICollection<Property> Property { get; set; }

    }
}
