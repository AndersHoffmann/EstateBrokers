using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gateways
{
    public interface ICaseCRUD
    {
        public int CreateCase(DateTime creationDate, double price, int realtor);

        public Case ReadCase(int ID);

        public List<Case> ReadAllCases();

        public List<Case> ReadAPreDefinedNumberOfCasesWithNoRealtor(int number);

        public List<Case> ReadCases(int PostalCode);

        public bool UpdateCase(int ID, DateTime creationDate, DateTime? closedDate, double price, int realtorID);

        public void DeleteCase(int ID);
     
    }
}
