using System;
using Entities;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;
using Entities.ObjectInterFaces;

namespace Database
{
   public class Case : ICase
    {
        public int CaseID { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? ClosedDate { get; set; }
        public double Price { get; set; }
        public int RealtorID { get; set; }
        public IRealtor Realtor { get; set; }
        public IProperty Property { get; set; }
    }
}
