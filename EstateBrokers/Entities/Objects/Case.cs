using Entities.ObjectInterFaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
   public class Case : ICase
    {
        public int CaseID { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? ClosedDate { get; set; }
        public Double Price { get; set; }
        public IRealtor? Realtor { get; set; }
        public IProperty Property { get; set; }
        public Case(int caseID, DateTime creationDate, DateTime? closedDate, double price, IRealtor? realtor, IProperty property)
        {
            CaseID = caseID;
            CreationDate = creationDate;
            ClosedDate = closedDate;
            Price = price;
            Realtor = realtor;
            Property = property;
        }
        public Case()
        {

        }
    }
   
}
