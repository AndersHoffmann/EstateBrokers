using Entities.ObjectInterFaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Database
{
    static class CaseFactory
    {
        //GRASP - Creator
        public static ICase CreateCase(ICase Case = null)
        {

            if (Case is Database.Case) 
            {
                return new Entities.Case(Case.CaseID, Case.CreationDate, Case.ClosedDate, Case.Price, Case.Realtor, Case.Property);
            }
            if (Case is Entities.Case)
            {
                return new Database.Case(Case.CaseID, Case.CreationDate, Case.ClosedDate, Case.Price, Case.Realtor, Case.Property);
            }
            else
            {
                return new Entities.Case();
            }

        }

    }
}
