using System;
using Entities;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Database
{
    public class Address : Entities.Address
    {
        [Key, Column(Order = 0)]
        public int PostalCode { get; set; }
        [Key, Column(Order = 1)]
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public double OwnershipCost { get; set; }
        public int ExteriorArea { get; set; }
        public int InteriorArea { get; set; }
        public int BuildYear { get; set; }
    }
}
