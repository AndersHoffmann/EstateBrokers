using Entities.ObjectInterFaces;
using System;
using System.Collections.Generic;
using System.Text;



namespace Database
{
   public class Realtor : IRealtor
    {
        public int RealtorID { get; set; }
        public string Name { get; set; }
        public string PhoneNR { get; set; }
        public ICollection<ICase> Case { get; set; }
    }
}
