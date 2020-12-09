using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gateways
{
   public interface IAddressCRUD
    {
        public int CreateAddress(int postalCode, string addressLine1, string addressLine2, double ownershipCost, int exteriorArea, int interiorArea, int buildYear);

        public Address ReadAddress(int postalCode, string addressLine1);

        public bool UpdateAddress(int postalCode, string addressLine1, string addressLine2, double ownershipCost, int exteriorArea, int interiorArea, int buildYear);

        public void DeleteAddress(int postalCode, string addressLine1);
    }
}
