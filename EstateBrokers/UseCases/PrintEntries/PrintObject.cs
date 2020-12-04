using System;
using System.Collections.Generic;
using System.Text;

namespace UseCases.PrintEntries
{
    public class PrintObject
    {
        public string RealtorName { get; set; }
        public string RealtorPhone { get; set; }
        public int CaseID { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime ClosedDate { get; set; }
        public Double Price { get; set; }
        public int PostalCode { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public int ExteriorArea { get; set; }
        public int InteriorArea { get; set; }
        public double EstimatedPrice { get; set; }
        public int BuildYear { get; set; }
        public double AverageAreaPrice { get; set; }
    }
}
