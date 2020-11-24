using System;
using System.Collections.Generic;
using System.Text;



namespace Database
{
   public class Realtor : Entities.Realtor
    {
        public int RealtorID { get; set; }
        public string Name { get; set; }
        public string PhoneNR { get; set; }
        public ICollection<Case> Case { get; set; }

    }
}
