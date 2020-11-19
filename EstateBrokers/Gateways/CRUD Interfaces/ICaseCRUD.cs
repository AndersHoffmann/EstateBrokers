using Database;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gateways
{
    public interface ICaseCRUD
    {
        public void Create(DateTime creationDate, double price, Realtor realtor);

        public Case Read(int ID);

        public void Update(int ID, DateTime creationDate, DateTime closedDate, double price, Realtor realtor);

        public void Delete(int ID);
    }
}
