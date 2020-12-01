using Entities.ObjectInterFaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities
{
    public class Address : IAddress
    {

        public int PostalCode { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public double OwnershipCost { get; set; }
        public int ExteriorArea { get; set; }
        public int InteriorArea { get; set; }
        public int BuildYear { get; set; }
        public Address(int postalCode, string addressLine1, string addressLine2, double ownershipCost, int exteriorArea, int interiorArea, int buildYear)
        {
            PostalCode = postalCode;
            AddressLine1 = addressLine1;
            AddressLine2 = addressLine2;
            OwnershipCost = ownershipCost;
            ExteriorArea = exteriorArea;
            InteriorArea = interiorArea;
            BuildYear = buildYear;
        }
        public Address()
        {
                
        }

        public Address(int postalCode, string addressLine1, string addressLine2, int exteriorArea, int interiorArea, int buildYear)
        {
            PostalCode = postalCode;
            AddressLine1 = addressLine1;
            AddressLine2 = addressLine2;
            ExteriorArea = exteriorArea;
            InteriorArea = interiorArea;
            BuildYear = buildYear;
        }
    }
}
