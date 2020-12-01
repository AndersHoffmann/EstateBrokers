using System;
using Entities;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;

namespace Database
{
   public class Case : Entities.Case
    {
        public int CaseID { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? ClosedDate { get; set; }
        public double Price { get; set; }
        public int RealtorID { get; set; }
        public Realtor Realtor { get; set; }
        public  Property Property { get; set; }

    }
}
