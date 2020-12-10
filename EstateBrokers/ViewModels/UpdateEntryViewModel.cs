using System;

namespace ViewModels
{
    public class UpdateEntryViewModel
    {
        public bool UpdateSuccess { get; set; }

        //For Case
        public string caseID { get; set; }
        public decimal realtorID { get; set; }
        public string creationDate { get; set; }
        public string? closedDate { get; set; }
        public decimal price { get; set; }

        //For Property
        public decimal estimatedPrice { get; set; }

        //For Property and Address
        public decimal postalCode { get; set; }
        public string addressLine1 { get; set; }

        //For Address
        public string addressLine2 { get; set; }
        public decimal ownershipCost { get; set; }
        public decimal exteriorArea { get; set; }
        public decimal interiorArea { get; set; }
        public decimal buildYear { get; set; }
    }
}
