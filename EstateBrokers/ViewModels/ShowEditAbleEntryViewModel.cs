using System;

namespace ViewModels
{
    public class ShowEditAbleEntryViewModel
    {
        public bool UpdateSuccess { get; set; }

        //For Case
        public string caseID { get; set; }
        public string realtorID { get; set; }
        public string creationDate { get; set; }
        public string? closedDate { get; set; }
        public string price { get; set; }

        //For Property
        public string estimatedPrice { get; set; }

        //For Property and Address
        public string postalCode { get; set; }
        public string addressLine1 { get; set; }

        //For Address
        public string addressLine2 { get; set; }
        public string ownershipCost { get; set; }
        public string exteriorArea { get; set; }
        public string interiorArea { get; set; }
        public string buildYear { get; set; }
    }
}
