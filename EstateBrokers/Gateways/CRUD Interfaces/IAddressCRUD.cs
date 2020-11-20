using Database;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gateways
{
   public interface IAddressCRUD
    {
        public void Create(int postalCode, string addressLine1, string addressLine2, double ownershipCost, int exteriorArea, int interiorArea, int buildYear);

        public Address Read(int postalCode, string addressLine1);

        public void Update(int postalCode, string addressLine1, string addressLine2, double ownershipCost, int exteriorArea, int interiorArea, int buildYear);

        public void Delete(int postalCode, string addressLine1);
    }
}
