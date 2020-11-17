using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Database
{
    public class Address
    {
        [Key, Column(Order = 0)]
        public int PostalCode { get; set; }
        [Key, Column(Order = 1)]
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        double OwnershipCost { get; set; }
        int ExteriorArea { get; set; }
        int InteriorArea { get; set; }
        int BuildYear { get; set; }
    }
}
