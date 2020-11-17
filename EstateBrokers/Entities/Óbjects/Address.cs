using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities 
{
    public class Address
    { 
        public int PostalCode { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        double OwnershipCost { get; set; }
        int ExteriorArea { get; set; }
        int InteriorArea { get; set; }
        int BuildYear { get; set; }
    }
}
