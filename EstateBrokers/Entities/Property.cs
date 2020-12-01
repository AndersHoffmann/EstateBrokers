﻿using Entities.ObjectInterFaces;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace Entities
{ 
   public class Property : IProperty
    {
        public int PropertyID { get; set; }
        public double EstimatedPrice { get; set; }
        public ICase Case { get; set; }
        public int PostalCode { get; set; }
        public string AddressLine1 { get; set; }

    }
}
