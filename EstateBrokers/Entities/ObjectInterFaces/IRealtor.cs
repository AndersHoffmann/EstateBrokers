using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.ObjectInterFaces
{
    public interface IRealtor
    {
        public int RealtorID { get; set; }
        public string Name { get; set; }
        public string PhoneNR { get; set; }
        public ICollection<ICase> Case { get; set; }
    }
}
