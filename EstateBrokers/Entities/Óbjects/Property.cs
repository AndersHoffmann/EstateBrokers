using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Entities
{
    public class Property
    {
        public int PropertyID { get; set; }
        public int EstimatedPrice { get; set; }
        public Case Case { get; set; }
        public int PostalCode { get; set; }
        public string AddressLine1 { get; set; }
    }
}
