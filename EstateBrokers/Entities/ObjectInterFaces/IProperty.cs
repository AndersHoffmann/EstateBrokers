using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.ObjectInterFaces
{
    public interface IProperty
    {
        public int PropertyID { get; set; }
        public double EstimatedPrice { get; set; }
        public ICase Case { get; set; }
        public int PostalCode { get; set; }
        public string AddressLine1 { get; set; }
    }
}
