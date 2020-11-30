﻿using System;

namespace UseCases.ShowCases
{
    public class ShowEntriesRequestModel
    {
        //For Case
        public int realtorID { get; set; }
        public DateTime creationDate { get; set; }
        public DateTime closedDate { get; set; }
        public Double price { get; set; }

        //For Property
        public double estimatedPrice { get; set; }

        //For Property and Address
        public int postalCode { get; set; }
        public string AddressLine1 { get; set; }

        //For Address
        public string AddressLine2 { get; set; }
        public double ownershipCost { get; set; }
        public int exteriorArea { get; set; }
        public int interiorArea { get; set; }
        public int buildYear { get; set; }

    }
}
