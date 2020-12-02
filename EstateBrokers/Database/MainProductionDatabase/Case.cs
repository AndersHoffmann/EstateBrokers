using System;
using Entities;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using Entities.ObjectInterFaces;

namespace Database
{
   public class Case : ICase
    {
        public Case()
        {
        }

        public Case(int caseID, DateTime creationDate, DateTime? closedDate, double price, IRealtor realtor, IProperty property)
        {
            CaseID = caseID;
            CreationDate = creationDate;
            ClosedDate = closedDate;
            Price = price;
            Realtor = realtor;
            ConcreteRealtor = (Realtor)realtor;
            Property = property;
            ConcreteProperty = (Property)property;
            
        }

        public int CaseID { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? ClosedDate { get; set; }
        public double Price { get; set; }
        public int RealtorID { get; set; }
        public Realtor ConcreteRealtor { get; set; }
        [NotMapped]
        public IRealtor? Realtor { get; set; }
        public Property ConcreteProperty { get; set; }
        [NotMapped]
        public IProperty Property { get; set; }
    }
}
