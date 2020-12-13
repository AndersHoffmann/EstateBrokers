using System;
using System.Collections.Generic;
using System.Text;

namespace UseCases.UpdateEntry
{
    public class UpdatedEntryRequestModel
    {
        //For Case
        public int CaseID { get; set; }
        public int RealtorID { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? ClosedDate { get; set; }
        public double Price { get; set; }

        //For Property
        public double EstimatedPrice { get; set; }

        //For Property and Address
        public int PostalCode { get; set; }
        public string AddressLine1 { get; set; }

        //For Address
        public string AddressLine2 { get; set; }
        public double OwnershipCost { get; set; }
        public int ExteriorArea { get; set; }
        public int InteriorArea { get; set; }
        public int BuildYear { get; set; }

    }
}
