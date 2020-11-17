using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Database
   public class Property
    {
        public int PropertyID { get; set; }
        public int EstimatedPrice { get; set; }
        public Case Case { get; set; }

        [ForeignKey("Address"), Column(Order = 0)]
        public int PostalCode { get; set; }
        [ForeignKey("Address")  , Column(Order = 1)]
        public string AddressLine1 { get; set; }
    }
}
