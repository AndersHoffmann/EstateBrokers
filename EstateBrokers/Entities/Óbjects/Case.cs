using System;
using System.Collections.Generic;
using System.Text;

namespace Entities
{
    public class Case
    {
        int CaseID { get; set; }
        DateTime CreationDate { get; set; }
        DateTime ClosedDate { get; set; }
        Double Price { get; set; }
        Realtor Realtor { get; set; }

    }
}
