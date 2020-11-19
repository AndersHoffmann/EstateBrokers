using Database;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gateways
{
    public interface ICaseCRUD
    {
        public void CreateCase(DateTime creationDate, double price, Realtor realtor);

        public Case ReadCase(int ID);

        public void UpdateCase(int ID, DateTime creationDate, DateTime closedDate, double price, Realtor realtor);

        public void Delete(int ID);
    }
}
