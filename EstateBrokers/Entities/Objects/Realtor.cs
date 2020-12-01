using Entities.ObjectInterFaces;
using System;
using System.Collections.Generic;
using System.Text;



namespace Entities
{
   public class Realtor : IRealtor
    {
        public int RealtorID { get; set; }
        public string Name { get; set; }
        public string PhoneNR { get; set; }
        public ICollection<ICase> Case { get; set; }

        public Realtor(int realtorID, string name, string phoneNR, ICollection<ICase> @case)
        {
            RealtorID = realtorID;
            Name = name;
            PhoneNR = phoneNR;
            Case = @case;
        }
        public Realtor()
        {
                
        }
    }
}
