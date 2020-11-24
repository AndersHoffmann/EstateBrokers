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
        public double OwnershipCost { get; set; }
        public int ExteriorArea { get; set; }
        public int InteriorArea { get; set; }
        public int BuildYear { get; set; }
    }
}
