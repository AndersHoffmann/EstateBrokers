using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.ObjectInterFaces
{
    public interface ICase
    {
        public int CaseID { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime? ClosedDate { get; set; }
        public Double Price { get; set; }
        public IRealtor? Realtor { get; set; }
        public IProperty Property { get; set; }
    }
}
