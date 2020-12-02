using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using Entities.ObjectInterFaces;




namespace Database
{
   public class Realtor : IRealtor
    {
        public Realtor()
        {
        }

        public Realtor(int realtorID, string name, string phoneNR, ICollection<ICase> @case)
        {
            RealtorID = realtorID;
            Name = name;
            PhoneNR = phoneNR;
            Case = @case;
            ConcreteCase =(ICollection<Case>) @case;
        }

        public int RealtorID { get; set; }
        public string Name { get; set; }
        public string PhoneNR { get; set; }
        public ICollection<Case> ConcreteCase { get; set; }
        [NotMapped]
        public ICollection<ICase> Case { get; set; }
    }
}
