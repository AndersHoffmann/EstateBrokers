using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gateways
{
    public interface ICaseCRUD
    {
        public int CreateCase(DateTime creationDate, double price, Realtor realtor);

        public Case ReadCase(int ID);

        public List<Case> ReadCases(int PostalCode);

        public void UpdateCase(int ID, DateTime creationDate, DateTime closedDate, double price, Realtor realtor);

        public void DeleteCase(int ID);
    }
}
