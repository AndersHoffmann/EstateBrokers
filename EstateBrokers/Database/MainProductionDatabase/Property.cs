using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using Entities.ObjectInterFaces;

namespace Database
{ 
   public class Property : IProperty
    {
        public Property()
        {
        }
        public Property(int propertyID, double estimatedPrice, ICase @case, int caseID, int postalCode, string addressLine1)
        {
            PropertyID = propertyID;
            EstimatedPrice = estimatedPrice;
            Case = @case;
            CaseID = caseID;
            PostalCode = postalCode;
            AddressLine1 = addressLine1;
            ConcreteCase = (Case)@case;
        }

        public int PropertyID { get; set; }
        public double EstimatedPrice { get; set; }

        public int CaseID { get; set; }
        public Case ConcreteCase { get; set; }
        [NotMapped]
        public ICase Case { get; set; }

        [ForeignKey("Address"), Column(Order = 0)]
        public int PostalCode { get; set; }
        [ForeignKey("Address")  , Column(Order = 1)]
        public string AddressLine1 { get; set; }
       
    }
}
